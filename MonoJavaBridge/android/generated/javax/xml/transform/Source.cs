namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.Source_))]
	public partial interface Source  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getSystemId();
		void setSystemId(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.Source))]
	internal sealed partial class Source_ : java.lang.Object, Source
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Source_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String javax.xml.transform.Source.getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.Source_.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.Source_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.xml.transform.Source.setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.Source_.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::javax.xml.transform.Source_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Source_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.Source_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/Source"));
		}
	}
}
