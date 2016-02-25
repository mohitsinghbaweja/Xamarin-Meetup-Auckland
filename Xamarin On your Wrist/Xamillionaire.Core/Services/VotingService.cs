using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Xamillionaire.Core
{
	public class VotingService
	{
		private IPlatformProvider _platformProvider;

		public VotingService(IPlatformProvider platformProvider)
		{
			_platformProvider = platformProvider;
		}
		
		public async Task<bool> Vote(bool answer)
		{
			var vote = new VoteAnswer
			{
				IsTrue = answer,
				Platform = _platformProvider.PlatformType
			};

			var json = JsonConvert.SerializeObject(vote);

			var client = new HttpClient();
			var content = new StringContent(json, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("http://xamillionaire.azurewebsites.net/api/submitVote", content);
			return response.IsSuccessStatusCode;
		}
	}
}

