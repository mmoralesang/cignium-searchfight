/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 5:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using searchfight.htmldoc;

namespace searchfight.http
{
	/// <summary>
	/// Description of HttpContent.
	/// </summary>
	public class HttpContent
	{
		private String url;
		private String html;
		
		public HttpContent(String url, String html)
		{
			this.url = url;
			this.html = html;	
		}
		
		public Document get() {
			return Parser.parseInput(url, html);
		}
	}
}
