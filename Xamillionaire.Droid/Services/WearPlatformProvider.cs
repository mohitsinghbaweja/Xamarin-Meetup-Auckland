using System;
using Xamillionaire.Core;

namespace Xamillionaire.Droid
{
	public class WearPlatformProvider : IPlatformProvider
	{
		public string PlatformType {
			get {
				return "AndroidWear";
			}
		}
	}
}

