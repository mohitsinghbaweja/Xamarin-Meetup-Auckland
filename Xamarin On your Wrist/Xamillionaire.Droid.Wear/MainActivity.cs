using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;

using Android.Support.Wearable.Activity;
using Android.Support.Wearable.Views;

using Android.Gms.Common.Apis;
using Android.Gms.Wearable;
using Xamillionaire.Core;


namespace Xamillionaire.Droid.Wear
{
	[Activity (Label = "Xamillionaire", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : InsetActivity, IDataApiDataListener, IGoogleApiClientConnectionCallbacks, IGoogleApiClientOnConnectionFailedListener
	{

		const string someotheraction = "/xamillionaire/someotheraction";
		const string answerYesPath = "/xamillionaire/answer/yes";
		const string answerNoPath = "/xamillionaire/answer/no";

		GridViewPager pager;
		TextView label;
		Handler handler;

		IGoogleApiClient client;
		INode phoneNode;

		ImageButton yesButton;
		ImageButton noButton;

		IPlatformProvider _platformProvider;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			handler = new Handler ();
			client = new GoogleApiClientBuilder (this, this, this).AddApi (WearableClass.Api).Build ();

			_platformProvider = new WearPlatformProvider ();
		}
			
		public override void OnReadyForContent ()
		{
			//SetContentView (Resource.Layout.GridViewPagerLayout);
			//SetContentView (Resource.Layout.BoxLayout);
			SetContentView (Resource.Layout.Main);

			//pager = FindViewById<GridViewPager> (Resource.Id.pager);
			//label = FindViewById<TextView> (Resource.Id.loading);
			//var boxLayout = FindViewById<BoxInsetLayout> (Resource.Id.frame_layout);

			var watchViewStub = FindViewById<WatchViewStub> (Resource.Id.watch_view_stub);
			watchViewStub.LayoutInflated +=	(s, e) => {		

				yesButton = watchViewStub.FindViewById<ImageButton> (Resource.Id.answer_yes);
				noButton = watchViewStub.FindViewById<ImageButton> (Resource.Id.answer_no);

				yesButton.Click += (object sender, EventArgs evtArgs) => {
					//WearableClass.MessageApi.SendMessage (client, phoneNode.Id, answerYesPath, new byte[0]);				
					(new VotingService(_platformProvider)).Vote(true);

					//Add a toast
				};

				noButton.Click += (object sender, EventArgs evtArgs) => {
					//WearableClass.MessageApi.SendMessage (client, phoneNode.Id, answerNoPath, new byte[0]);
					(new VotingService(_platformProvider)).Vote(false);
				};
			};
		}

		protected override void OnStart ()
		{
			base.OnStart ();
			client.Connect ();
		}

		protected override void OnStop ()
		{
			base.OnStop ();
			client.Disconnect ();
		}

		public void OnConnected (Bundle p0)
		{
			WearableClass.DataApi.AddListener (client, this);

			//Initialize/connect to phone
			ConnectToPhone ();
		}
			
		public void OnConnectionSuspended (int reason)
		{
			Android.Util.Log.Error ("GMS", "Connection suspended " + reason);
			WearableClass.DataApi.RemoveListener (client, this);
		}

		public void OnConnectionFailed (Android.Gms.Common.ConnectionResult result)
		{
			Android.Util.Log.Error ("GMS", "Connection failed " + result.ErrorCode);
		}

		public void OnDataChanged (DataEventBuffer dataEvents)
		{
		}

		void ConnectToPhone ()
		{
			Task.Run (() => {
				var apiResult = WearableClass.NodeApi.GetConnectedNodes(client).Await().JavaCast<INodeApiGetConnectedNodesResult> ();
				var nodes = apiResult.Nodes;

				phoneNode = nodes.FirstOrDefault ();
				if (phoneNode == null) {
					//handle error
					return;
				}

				// Try to see if we have the data already
				//var uri = new Android.Net.Uri.Builder ().Scheme (PutDataRequest.WearUriScheme).Authority (phoneNode.Id).Path (someotheraction).Build ();
				//var dataResult = WearableClass.DataApi.GetDataItem (client, uri).Await ().JavaCast<IDataApiDataItemResult> ();
			});
		}
	}
}



