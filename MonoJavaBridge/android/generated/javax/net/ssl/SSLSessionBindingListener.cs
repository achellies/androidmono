namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.SSLSessionBindingListener_))]
	public partial interface SSLSessionBindingListener : java.util.EventListener
	{
		void valueBound(javax.net.ssl.SSLSessionBindingEvent arg0);
		void valueUnbound(javax.net.ssl.SSLSessionBindingEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLSessionBindingListener))]
	internal sealed partial class SSLSessionBindingListener_ : java.lang.Object, SSLSessionBindingListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SSLSessionBindingListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void javax.net.ssl.SSLSessionBindingListener.valueBound(javax.net.ssl.SSLSessionBindingEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSessionBindingListener_.staticClass, "valueBound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V", ref global::javax.net.ssl.SSLSessionBindingListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.net.ssl.SSLSessionBindingListener.valueUnbound(javax.net.ssl.SSLSessionBindingEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.SSLSessionBindingListener_.staticClass, "valueUnbound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V", ref global::javax.net.ssl.SSLSessionBindingListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SSLSessionBindingListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSessionBindingListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSessionBindingListener"));
		}
	}
}
