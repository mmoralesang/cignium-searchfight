/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 6:01 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HtmlAgilityPack;

namespace searchfight.htmldoc
{
	/// <summary>
	/// Description of Element.
	/// </summary>
	public class Element
	{
		private HtmlNode node;
		
		public Element(HtmlNode node)
		{
			this.node = node;
		}
		
		public string html()
		{			
			return node.OuterHtml;
		}
		
		public string text()
		{
			return node.InnerText;
		}
		
		public Element getLastChild()
		{
			return new Element(node.LastChild);
		}
		
		public Element getFirstChild()
		{
			return new Element(node.FirstChild);
		}
	}
}
