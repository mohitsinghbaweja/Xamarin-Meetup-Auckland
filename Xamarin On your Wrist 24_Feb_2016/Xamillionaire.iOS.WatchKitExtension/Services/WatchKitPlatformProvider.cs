using System;
using Xamillionaire.Core;

namespace Xamillionaire.iOS.WatchKitExtension.Services
{
	public class WatchKitPlatformProvider : IPlatformProvider
	{
		#region IPlatformProvider implementation

		public string PlatformType {
			get {
				return "WatchKit";
			}
		}

		#endregion
	}
}

