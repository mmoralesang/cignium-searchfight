/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 2:13 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using searchfight.model;

namespace searchfight.service
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	public interface SearchFightService
	{
		
		SearchFightResponse ExecuteSearchFight(List<string> q);
		
	}
}
