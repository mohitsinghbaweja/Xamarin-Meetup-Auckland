using System;
using ObjCRuntime;

namespace Xamillionaire.iOS.WatchKitExtension.Views.Interfaces
{
	public interface IVoteReceivedDelegate
	{
		void VoteReceived(bool vote);
	}
}

