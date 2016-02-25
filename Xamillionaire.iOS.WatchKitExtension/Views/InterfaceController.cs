using System;

using WatchKit;
using Foundation;
using UIKit;
using Xamillionaire.iOS.WatchKitExtension.Views.Interfaces;

namespace Xamillionaire.iOS.WatchKitExtension.Views
{
	public partial class InterfaceController : WKInterfaceController, IVoteReceivedDelegate
	{
		private const string failureString = "Sorry, Xamillionaire could not be reached. Please try again.";
		private const string successString = "Thanks for playing who Wants To Be a Xamillionaire? Please play again.";

		public override void Awake (NSObject context)
		{
			base.Awake (context);

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

		partial void Action()
		{
			PresentController("VoteInterfaceController", this);
//			Button.SetEnabled(false);
		}

		public void VoteReceived(bool result)
		{
//			Button.SetEnabled(true);
			var message = result ? successString : failureString;
			PresentController("Alert", message);
		}
	}
}

