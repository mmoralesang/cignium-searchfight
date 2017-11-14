/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 5:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

using HtmlAgilityPack;
using searchfight.htmldoc;
using searchfight.http;
using searchfight.model;

namespace searchfight.utils
{
	/// <summary>
	/// Description of HtmlUtil.
	/// </summary>
	public class HtmlUtil
	{
		public HtmlUtil()
		{
		}
		
		public static long processSearchEngine(SearchEngine engine, String q) 
		{
			long numResult = 0;
			String url = engine.EndPoint + q;
			
			Document doc = HttpClient.connect(url).get();
			Element element = null;
			string resultStr = null;
			
			if (engine.Name.Equals("google"))
			{
				element = doc.getElementById("resultStats");	
				resultStr = element.text();				
				numResult = getResultCount(resultStr);
			} 
			else if(engine.Name.Equals("bing")) 
			{
				element = doc.getElementById("b_tween").getFirstChild();
				resultStr = element.text();
				numResult = getResultCount(resultStr);
			}
			else if(engine.Name.Equals("yahoo")) 
			{
				element = doc.getElementByClass("compPagination");
				resultStr = element.text();				
				numResult = getResultCount(resultStr);
			}
			
			return numResult;
		}
		
		static long getResultCount(string resultStr)
		{
			return long.Parse(new Regex("[^\\d]").Replace(resultStr, ""));
		}
	}
}
