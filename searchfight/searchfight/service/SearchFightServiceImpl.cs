/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 2:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using searchfight.model;
using searchfight.utils;

namespace searchfight.service
{
	/// <summary>
	/// Description of SearchFightServiceImple.
	/// </summary>
	public class SearchFightServiceImpl : SearchFightService
	{
		public SearchFightResponse ExecuteSearchFight(List<string> args) {
			SearchFightResponse response = new SearchFightResponse();
			
			foreach(SearchEngine engine in ConstantUtil.searchEngines) {
				foreach(string q in args) {
					long count = engine.search(q);
					response.addResult(engine, q, count);
				}		
			}

			return response;			
		}
	}
}
