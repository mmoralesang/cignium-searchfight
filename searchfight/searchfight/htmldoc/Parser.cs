/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 6:19 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace searchfight.htmldoc
{
	/// <summary>
	/// Description of Parser.
	/// </summary>
	public class Parser
	{
		public Parser()
		{
		}
				
		public static Document parseInput(string url, string html)
		{
			return new Document(url, html);
		}
	}
}
