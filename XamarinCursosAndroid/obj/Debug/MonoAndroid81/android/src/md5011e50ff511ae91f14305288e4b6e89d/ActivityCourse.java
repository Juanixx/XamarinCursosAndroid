package md5011e50ff511ae91f14305288e4b6e89d;


public class ActivityCourse
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("XamarinCursosAndroid.ActivityCourse, XamarinCursosAndroid", ActivityCourse.class, __md_methods);
	}


	public ActivityCourse ()
	{
		super ();
		if (getClass () == ActivityCourse.class)
			mono.android.TypeManager.Activate ("XamarinCursosAndroid.ActivityCourse, XamarinCursosAndroid", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
