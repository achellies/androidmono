namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicScheme : org.apache.http.impl.auth.RFC2617Scheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicScheme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String SchemeName
		{
			get
			{
				return getSchemeName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getSchemeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.BasicScheme.staticClass, "getSchemeName", "()Ljava/lang/String;", ref global::org.apache.http.impl.auth.BasicScheme._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void processChallenge(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.auth.BasicScheme.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.impl.auth.BasicScheme._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool isConnectionBased()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.BasicScheme.staticClass, "isConnectionBased", "()Z", ref global::org.apache.http.impl.auth.BasicScheme._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isComplete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.BasicScheme.staticClass, "isComplete", "()Z", ref global::org.apache.http.impl.auth.BasicScheme._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.impl.auth.BasicScheme.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;", ref global::org.apache.http.impl.auth.BasicScheme._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.BasicScheme._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.BasicScheme._m5 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Ljava/lang/String;Z)Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallStaticObjectMethod(org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public BasicScheme() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.BasicScheme._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.BasicScheme._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._m6);
			Init(@__env, handle);
		}
		static BasicScheme()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.BasicScheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/BasicScheme"));
		}
	}
}
