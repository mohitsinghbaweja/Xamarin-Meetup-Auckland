// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Xamillionaire.iOS.WatchKitExtension.Views
{
	[Register ("AlertInterfaceController")]
	partial class AlertInterfaceController
	{
		[Outlet]
		WatchKit.WKInterfaceLabel Label { get; set; }

		[Action ("ButtonPressed")]
		partial void ButtonPressed ();
		
		void ReleaseDesignerOutlets ()
		{
			if (Label != null) {
				Label.Dispose ();
				Label = null;
			}
		}
	}
}
