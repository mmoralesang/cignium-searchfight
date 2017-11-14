/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 5:51 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace searchfight.htmldoc
{
	/// <summary>
	/// Description of Document.
	/// </summary>
	public class Document
	{
		private string url;
		private string html;
		private HtmlDocument d;
		
		public Document(string url, string html)
		{
			this.url = url;
			this.html = html;
			
			this.d = new HtmlDocument();
			d.LoadHtml(html);
		}
		
		public Element getElementById(string id)
		{
			HtmlNode node = d.GetElementbyId(id);
			return new Element(node);
		}
		
		
		public Element getElementByClass(string className)
		{
			return null;
		}
	}
}
