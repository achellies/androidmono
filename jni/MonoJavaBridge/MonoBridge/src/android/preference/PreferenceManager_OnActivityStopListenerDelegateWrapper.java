package android.preference;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class PreferenceManager_OnActivityStopListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.preference.PreferenceManager.OnActivityStopListener
{
	static
	{
		MonoBridge.link(PreferenceManager_OnActivityStopListenerDelegateWrapper.class, "onActivityStop", "()V", "");

	}

	@Override
	public native void onActivityStop();


	long myGCHandle;
	public long getGCHandle() {
		return myGCHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGCHandle = gcHandle;
	}

	@Override
	protected void finalize() throws Throwable {
	    super.finalize();
	    MonoBridge.releaseGCHandle(myGCHandle);
	}
}