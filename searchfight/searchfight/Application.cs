/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 1:11 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using searchfight.model;
using searchfight.service;
using searchfight.utils;

namespace searchfight
{
	class Application
	{
		private SearchFightService service;
		
		public Application() {
			SearchFightServiceImpl serviceImpl = new SearchFightServiceImpl();
			this.service = (SearchFightService)serviceImpl;
		}
		
		public static void Main(string[] args)
		{
			Application app = new Application();
			app.RunSearchFight(args);
		}
		
		private void RunSearchFight(string[] args)
		{
			List<string> list = new List<string>();
			for(int i=0; i<args.Length; i++) {
				list.Add(args[i]);
			}
			
			// Execute Search Fight
			SearchFightResponse response = service.ExecuteSearchFight(list);
			
			// Get results
			List<SearchEngineResult> results = response.Results;
			
			// show results
			showRanking(results, list);
		}
		
		private void showRanking(List<SearchEngineResult> results, List<string> args)
		{
			// Print result by arg
			foreach(String p in args)
			{
				StringBuilder sb = new StringBuilder(p);
				sb.Append(": ");
				results.FindAll(r => r.Query.Equals(p)).ForEach(i => {
					sb.Append(i.Engine.Name);
					sb.Append(": ");
					sb.Append(i.Count);
					sb.Append(" ");
				});
				
				Console.WriteLine(sb);
			}
			
			// Print result by engine
			ConstantUtil.searchEngines.ForEach(e => {   
				List<SearchEngineResult> list = results.FindAll(item => item.Engine.Name.Equals(e.Name));
				List<SearchEngineResult> sortedList = list.OrderBy(o => o.Count).ToList();
				
				SearchEngineResult greater = sortedList.Last();
				
				StringBuilder sb = new StringBuilder(greater.Engine.Name);
				sb.Append(" ");
				sb.Append("winner: ");
				sb.Append(greater.Query);
				
				Console.WriteLine(sb);
			});
			
			// Print total winner
			List<SearchEngineResult> sortedResults = results.OrderBy(o => o.Count).ToList();
			SearchEngineResult total = sortedResults.Last();
			
			StringBuilder sb2 = new StringBuilder("Total winner: ");
			sb2.Append(total.Query);
			
			Console.WriteLine(sb2);
		}
	}
}