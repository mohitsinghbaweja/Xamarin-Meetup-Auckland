using System;
using Newtonsoft.Json;

namespace Xamillionaire.Core
{
	public class VoteAnswer
	{
		[JsonProperty("IsTrue")]
		public bool IsTrue { get; set; }

		[JsonProperty("Platform")]
		public string Platform { get; set; }
	}
}

