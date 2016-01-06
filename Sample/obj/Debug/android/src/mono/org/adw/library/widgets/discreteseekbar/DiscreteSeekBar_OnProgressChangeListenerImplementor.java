package mono.org.adw.library.widgets.discreteseekbar;


public class DiscreteSeekBar_OnProgressChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.adw.library.widgets.discreteseekbar.DiscreteSeekBar.OnProgressChangeListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onProgressChanged:(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar;IZ)V:GetOnProgressChanged_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_IZHandler:Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar/IOnProgressChangeListenerInvoker, discreteSeekBar\n" +
			"n_onStartTrackingTouch:(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar;)V:GetOnStartTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_Handler:Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar/IOnProgressChangeListenerInvoker, discreteSeekBar\n" +
			"n_onStopTrackingTouch:(Lorg/adw/library/widgets/discreteseekbar/DiscreteSeekBar;)V:GetOnStopTrackingTouch_Lorg_adw_library_widgets_discreteseekbar_DiscreteSeekBar_Handler:Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar/IOnProgressChangeListenerInvoker, discreteSeekBar\n" +
			"";
		mono.android.Runtime.register ("Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar+IOnProgressChangeListenerImplementor, discreteSeekBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DiscreteSeekBar_OnProgressChangeListenerImplementor.class, __md_methods);
	}


	public DiscreteSeekBar_OnProgressChangeListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DiscreteSeekBar_OnProgressChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Org.Adw.Library.Widgets.Discreteseekbar.DiscreteSeekBar+IOnProgressChangeListenerImplementor, discreteSeekBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onProgressChanged (org.adw.library.widgets.discreteseekbar.DiscreteSeekBar p0, int p1, boolean p2)
	{
		n_onProgressChanged (p0, p1, p2);
	}

	private native void n_onProgressChanged (org.adw.library.widgets.discreteseekbar.DiscreteSeekBar p0, int p1, boolean p2);


	public void onStartTrackingTouch (org.adw.library.widgets.discreteseekbar.DiscreteSeekBar p0)
	{
		n_onStartTrackingTouch (p0);
	}

	private native void n_onStartTrackingTouch (org.adw.library.widgets.discreteseekbar.DiscreteSeekBar p0);


	public void onStopTrackingTouch (org.adw.library.widgets.discreteseekbar.DiscreteSeekBar p0)
	{
		n_onStopTrackingTouch (p0);
	}

	private native void n_onStopTrackingTouch (org.adw.library.widgets.discreteseekbar.DiscreteSeekBar p0);

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
