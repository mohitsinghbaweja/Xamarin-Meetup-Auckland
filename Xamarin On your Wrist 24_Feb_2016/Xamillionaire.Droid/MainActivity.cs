using System;

using Android.App;
using Android.Content;
using Android.Gms;
using Android.Gms.Common;
using Android.Gms.Common.Apis;
using Android.Gms.Wearable;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Xamillionaire.Droid
{
	[Activity (Label = "Xamillionaire", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
								//, GoogleApiClient.IConnectionCallbacks, GoogleApiClient.IOnConnectionFailedListener
								//, IMessageApiMessageListener, IResultCallback
	{
		//private GoogleApiClient googleApiClient;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

//			googleApiClient = new GoogleApiClient.Builder (this)
//				.AddApi (WearableClass.API)
//				.AddConnectionCallbacks (this)
//				.AddOnConnectionFailedListener (this)
//				.Build ();
			
//			FindViewById (Resource.Id.myButton).Click += delegate {
//				OnStartWearableActivityClick (null);
//			};				
		}

//		public void OnStartWearableActivityClick (View v)
//		{
//			WearableClass.NodeApi.GetConnectedNodes (googleApiClient).SetResultCallback (this);
//		}
	}
}


