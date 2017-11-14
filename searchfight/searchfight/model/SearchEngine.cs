/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 3:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using searchfight.utils;

namespace searchfight.model
{
	/// <summary>
	/// Description of SearchEngine.
	/// </summary>
	public class SearchEngine
	{
		private String name;
		private String endPoint;		
		
		public SearchEngine(String name, String endPoint)
		{
			this.name = name;
			this.endPoint = endPoint;
		}
		
		public string Name {
			get { return name; }
			set { name = value; }
		}
		
		public string EndPoint {
			get { return endPoint; }
			set { endPoint = value; }
		}
		
		
		public long search(String q) 
		{
			return HtmlUtil.processSearchEngine(this, q);
		}
	}
}
