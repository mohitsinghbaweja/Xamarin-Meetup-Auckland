using System;
using WatchKit;
using Foundation;
using Xamillionaire.Core;
using Xamillionaire.iOS.WatchKitExtension.Services;
using Xamillionaire.iOS.WatchKitExtension.Views.Interfaces;


namespace Xamillionaire.iOS.WatchKitExtension.Views
{
	public partial class VoteInterfaceController : WKInterfaceController
	{
		public IVoteReceivedDelegate NotificationDelegate { get; set; }
		private VotingService _votingService;
		private IPlatformProvider _platformProvider;

		public VoteInterfaceController (IntPtr handle) : base (handle)
		{
			_platformProvider = new WatchKitPlatformProvider();
			_votingService = new VotingService(_platformProvider);
		}

		public override void Awake (NSObject context)
		{
			base.Awake (context);

			NotificationDelegate = (IVoteReceivedDelegate) context;

			// Configure interface objects here.
			Console.WriteLine ("{0} awake with context", this);
		}

		public override void WillActivate ()
		{
			// This method is called when the watch view controller is about to be visible to the user.
			Console.WriteLine ("{0} will activate", this);
		}

		public override void DidDeactivate ()
		{
			// This method is called when the watch view controller is no longer visible to the user.
			Console.WriteLine ("{0} did deactivate", this);
		}

		partial void VoteYes()
		{
			SendVote(true);
		}

		partial void VoteNo()
		{
			SendVote(false);
		}

		private async void SendVote(bool vote)
		{
			DismissController();
			var success = await _votingService.Vote(vote);
			NotificationDelegate.VoteReceived(success);
		}
	}
}

