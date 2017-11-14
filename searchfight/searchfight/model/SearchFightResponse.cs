/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 4:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace searchfight.model
{
	/// <summary>
	/// Description of SearchFightResponse.
	/// </summary>
	public class SearchFightResponse
	{
		private List<SearchEngineResult> results = new List<SearchEngineResult>();
		
		public SearchFightResponse()
		{		
		}
		
		public void addResult(SearchEngine engine, String q, long count) 
		{
			results.Add(new SearchEngineResult(engine, q, count));
		}
		
		public List<SearchEngineResult> Results {
			get { return results; }
		}
		
	}
}
