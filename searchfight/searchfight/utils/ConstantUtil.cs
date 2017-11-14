/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 3:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using searchfight.model;

namespace searchfight.utils
{
	
	/// <summary>
	/// Description of ConstantUtil.
	/// </summary>
	public class ConstantUtil {	
		public static List<SearchEngine> searchEngines;
		
		static ConstantUtil() {
			searchEngines = new List<SearchEngine>();
			searchEngines.Add(new SearchEngine("google", "https://www.google.com/search?q="));
			searchEngines.Add(new SearchEngine("bing", "https://www.bing.com/search?q="));
			//searchEngines.Add(new SearchEngine("yahoo", "https://search.yahoo.com/search?p="));
		}
	
	}
}
