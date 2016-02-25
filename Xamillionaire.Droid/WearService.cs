using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

using Android.Gms.Wearable;
using Android.Gms.Common.Apis;
using Xamillionaire.Core;

namespace Xamillionaire.Droid
{
	[Service]
	[IntentFilter (new[] { "com.google.android.gms.wearable.BIND_LISTENER" })]
	public class WearService : WearableListenerService
	{
		const string someotheraction = "/xamillionaire/someotheraction";
		const string answerYesPath = "/xamillionaire/answer/yes";
		const string answerNoPath = "/xamillionaire/answer/no";

		const string platform = "android";

		private IPlatformProvider _platformProvider;
		private VotingService _votingService;

		public WearService()
		{
			_platformProvider = new WearPlatformProvider ();
			_votingService = new VotingService (_platformProvider);
		}

		public override void OnMessageReceived (IMessageEvent messageEvent)
		{
			base.OnMessageReceived (messageEvent);
			//check the message path here	
			HandleMessage (messageEvent);
		}

		async void HandleMessage (IMessageEvent message)
		{
			try 
			{
				Android.Util.Log.Info ("WearIntegration", "Received Message");

				var client = new GoogleApiClientBuilder(this).AddApi (WearableClass.Api).Build();

				var result = client.BlockingConnect (30, Java.Util.Concurrent.TimeUnit.Seconds);
				if (!result.IsSuccess)
					return;
				
				var path = message.Path;

				try 
				{
					if (path == answerYesPath)
					{
						_votingService.Vote(true);
					}
					else if (path == answerNoPath)
					{
						_votingService.Vote(false);
					}
				} 
				finally 
				{
					client.Disconnect ();
				}
			} catch (Exception e) 
			{
				Android.Util.Log.Error ("WearIntegration", e.ToString ());
			}
		}
	}
}

