namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2109SpecFactory : java.lang.Object, org.apache.http.cookie.CookieSpecFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RFC2109SpecFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.apache.http.cookie.CookieSpec newInstance(org.apache.http.@params.HttpParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.cookie.CookieSpec>(this, global::org.apache.http.impl.cookie.RFC2109SpecFactory.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;", ref global::org.apache.http.impl.cookie.RFC2109SpecFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.cookie.CookieSpec;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public RFC2109SpecFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2109SpecFactory._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2109SpecFactory._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109SpecFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2109SpecFactory.staticClass, global::org.apache.http.impl.cookie.RFC2109SpecFactory._m1);
			Init(@__env, handle);
		}
		static RFC2109SpecFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2109SpecFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2109SpecFactory"));
		}
	}
}
