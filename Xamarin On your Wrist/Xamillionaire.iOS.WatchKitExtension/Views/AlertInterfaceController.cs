using System;

using WatchKit;
using Foundation;
using UIKit;
using Xamillionaire.iOS.WatchKitExtension.Views.Interfaces;

namespace Xamillionaire.iOS.WatchKitExtension.Views
{
	public partial class AlertInterfaceController : WKInterfaceController
	{
		public string Messages { get; set; }

		private IVoteReceivedDelegate _voteReceivedDelegate;

		public override void Awake (NSObject context)
		{
			base.Awake (context);
			Label.SetText((NSString) context);

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

		partial void ButtonPressed()
		{
			DismissController();
		}
	}
}

