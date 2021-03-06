namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.ServiceConnection_))]
	public interface ServiceConnection  : global::MonoJavaBridge.IJavaObject 
	{
		void onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1);
		void onServiceDisconnected(android.content.ComponentName arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.ServiceConnection))]
	public sealed partial class ServiceConnection_ : java.lang.Object, ServiceConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ServiceConnection_()
		{
			InitJNI();
		}
		internal ServiceConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onServiceConnected1755;
		 void android.content.ServiceConnection.onServiceConnected(android.content.ComponentName arg0, android.os.IBinder arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ServiceConnection_._onServiceConnected1755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ServiceConnection_.staticClass, global::android.content.ServiceConnection_._onServiceConnected1755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onServiceDisconnected1756;
		 void android.content.ServiceConnection.onServiceDisconnected(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ServiceConnection_._onServiceDisconnected1756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ServiceConnection_.staticClass, global::android.content.ServiceConnection_._onServiceDisconnected1756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ServiceConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ServiceConnection"));
			global::android.content.ServiceConnection_._onServiceConnected1755 = @__env.GetMethodIDNoThrow(global::android.content.ServiceConnection_.staticClass, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V");
			global::android.content.ServiceConnection_._onServiceDisconnected1756 = @__env.GetMethodIDNoThrow(global::android.content.ServiceConnection_.staticClass, "onServiceDisconnected", "(Landroid/content/ComponentName;)V");
		}
	}
}
