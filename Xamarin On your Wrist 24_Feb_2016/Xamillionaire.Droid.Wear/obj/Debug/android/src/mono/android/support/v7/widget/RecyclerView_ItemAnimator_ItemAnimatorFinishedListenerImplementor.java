package mono.android.support.v7.widget;


public class RecyclerView_ItemAnimator_ItemAnimatorFinishedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v7.widget.RecyclerView.ItemAnimator.ItemAnimatorFinishedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnimationsFinished:()V:GetOnAnimationsFinishedHandler:Android.Support.V7.Widget.RecyclerView/ItemAnimator/IItemAnimatorFinishedListenerInvoker, Xamarin.Android.Wearable\n" +
			"";
		mono.android.Runtime.register ("Android.Support.V7.Widget.RecyclerView+ItemAnimator+IItemAnimatorFinishedListenerImplementor, Xamarin.Android.Wearable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RecyclerView_ItemAnimator_ItemAnimatorFinishedListenerImplementor.class, __md_methods);
	}


	public RecyclerView_ItemAnimator_ItemAnimatorFinishedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RecyclerView_ItemAnimator_ItemAnimatorFinishedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Support.V7.Widget.RecyclerView+ItemAnimator+IItemAnimatorFinishedListenerImplementor, Xamarin.Android.Wearable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAnimationsFinished ()
	{
		n_onAnimationsFinished ();
	}

	private native void n_onAnimationsFinished ();

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