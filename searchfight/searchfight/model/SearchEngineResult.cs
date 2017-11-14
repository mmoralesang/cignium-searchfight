/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 4:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace searchfight.model
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class SearchEngineResult
	{
		private SearchEngine engine;
		private String query;
		private long count;
		
		public SearchEngineResult(SearchEngine engine, String query, long count)
		{
			this.engine = engine;
			this.query = query;
			this.count = count;
		}
		
		public SearchEngine Engine {
			get { return engine; }
			set { engine = value; }
		}
		
		public string Query {
			get { return query; }
			set { query = value; }
		}
		
		public long Count {
			get { return count; }
			set { count = value; }
		}
		
	}
}
