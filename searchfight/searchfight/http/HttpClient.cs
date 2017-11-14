/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 13/11/2017
 * Time: 5:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Net;
using System.Text;

namespace searchfight.http
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class HttpClient
	{
		public HttpClient()
		{
		}
		
		public static HttpContent connect(string url)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			string data = null;
						
			if(response.StatusCode == HttpStatusCode.OK) 
			{
				Stream receiveStream = response.GetResponseStream();
				StreamReader readStream = null;
				
				if (response.CharacterSet == null)
				  {
				     readStream = new StreamReader(receiveStream);
				  }
				  else
				  {
				     readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
				  }								
				  
				  data = readStream.ReadToEnd();
				  
				  response.Close();
  				  readStream.Close();
			}
			
			return new HttpContent(url, data);
		}
	}
}
