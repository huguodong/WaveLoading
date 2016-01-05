package mono.org.adw.library.widgets.discreteseekbar.internal.drawable;


public class MarkerDrawable_MarkerAnimationListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.adw.library.widgets.discreteseekbar.internal.drawable.MarkerDrawable.MarkerAnimationListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onClosingComplete:()V:GetOnClosingCompleteHandler:Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable/IMarkerAnimationListenerInvoker, discreteSeekBar\n" +
			"n_onOpeningComplete:()V:GetOnOpeningCompleteHandler:Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable/IMarkerAnimationListenerInvoker, discreteSeekBar\n" +
			"";
		mono.android.Runtime.register ("Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable+IMarkerAnimationListenerImplementor, discreteSeekBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MarkerDrawable_MarkerAnimationListenerImplementor.class, __md_methods);
	}


	public MarkerDrawable_MarkerAnimationListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MarkerDrawable_MarkerAnimationListenerImplementor.class)
			mono.android.TypeManager.Activate ("Org.Adw.Library.Widgets.Discreteseekbar.Internal.Drawable.MarkerDrawable+IMarkerAnimationListenerImplementor, discreteSeekBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onClosingComplete ()
	{
		n_onClosingComplete ();
	}

	private native void n_onClosingComplete ();


	public void onOpeningComplete ()
	{
		n_onOpeningComplete ();
	}

	private native void n_onOpeningComplete ();

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
