package md50856c04aed6619f9f0272fbb49f3914c;


public class WearService
	extends com.google.android.gms.wearable.WearableListenerService
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMessageReceived:(Lcom/google/android/gms/wearable/MessageEvent;)V:GetOnMessageReceived_Lcom_google_android_gms_wearable_MessageEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamillionaire.Droid.WearService, Xamillionaire.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WearService.class, __md_methods);
	}


	public WearService () throws java.lang.Throwable
	{
		super ();
		if (getClass () == WearService.class)
			mono.android.TypeManager.Activate ("Xamillionaire.Droid.WearService, Xamillionaire.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMessageReceived (com.google.android.gms.wearable.MessageEvent p0)
	{
		n_onMessageReceived (p0);
	}

	private native void n_onMessageReceived (com.google.android.gms.wearable.MessageEvent p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
