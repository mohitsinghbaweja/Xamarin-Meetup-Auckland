package md57261b73fbc806e80a8e7f90f67cdbd93;


public class WearableMessageListenerService
	extends com.google.android.gms.wearable.WearableListenerService
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMessageReceived:(Lcom/google/android/gms/wearable/MessageEvent;)V:GetOnMessageReceived_Lcom_google_android_gms_wearable_MessageEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamillionaire.Droid.Wear.WearableMessageListenerService, Xamillionaire.Droid.Wear, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WearableMessageListenerService.class, __md_methods);
	}


	public WearableMessageListenerService () throws java.lang.Throwable
	{
		super ();
		if (getClass () == WearableMessageListenerService.class)
			mono.android.TypeManager.Activate ("Xamillionaire.Droid.Wear.WearableMessageListenerService, Xamillionaire.Droid.Wear, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
