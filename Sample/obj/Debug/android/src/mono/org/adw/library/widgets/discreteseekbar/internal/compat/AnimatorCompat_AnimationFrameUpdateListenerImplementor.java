package mono.org.adw.library.widgets.discreteseekbar.internal.compat;


public class AnimatorCompat_AnimationFrameUpdateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.adw.library.widgets.discreteseekbar.internal.compat.AnimatorCompat.AnimationFrameUpdateListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAnimationFrame:(F)V:GetOnAnimationFrame_FHandler:Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat/IAnimationFrameUpdateListenerInvoker, discreteSeekBar\n" +
			"";
		mono.android.Runtime.register ("Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat+IAnimationFrameUpdateListenerImplementor, discreteSeekBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AnimatorCompat_AnimationFrameUpdateListenerImplementor.class, __md_methods);
	}


	public AnimatorCompat_AnimationFrameUpdateListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AnimatorCompat_AnimationFrameUpdateListenerImplementor.class)
			mono.android.TypeManager.Activate ("Org.Adw.Library.Widgets.Discreteseekbar.Internal.Compat.AnimatorCompat+IAnimationFrameUpdateListenerImplementor, discreteSeekBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAnimationFrame (float p0)
	{
		n_onAnimationFrame (p0);
	}

	private native void n_onAnimationFrame (float p0);

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
