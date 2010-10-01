namespace android.database
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class CursorJoiner : java.lang.Object, java.util.Iterator, java.lang.Iterable
	{
		internal static global::java.lang.Class staticClass;
		static CursorJoiner()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.CursorJoiner), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.CursorJoiner(@__env);
			}
		}
		internal CursorJoiner(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Result : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static Result()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.CursorJoiner.Result), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.database.CursorJoiner.Result(@__env);
				}
			}
			internal Result(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values2254;
			public static global::android.database.CursorJoiner.Result[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.database.CursorJoiner.Result.staticClass, global::android.database.CursorJoiner.Result._values2254));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2255;
			public static global::android.database.CursorJoiner.Result valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorJoiner.Result>(@__env, @__env.CallStaticObjectMethodPtr(android.database.CursorJoiner.Result.staticClass, global::android.database.CursorJoiner.Result._valueOf2255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _BOTH2256;
			public static global::android.database.CursorJoiner.Result BOTH
			{
				get
				{
					return default(global::android.database.CursorJoiner.Result);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _LEFT2257;
			public static global::android.database.CursorJoiner.Result LEFT
			{
				get
				{
					return default(global::android.database.CursorJoiner.Result);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RIGHT2258;
			public static global::android.database.CursorJoiner.Result RIGHT
			{
				get
				{
					return default(global::android.database.CursorJoiner.Result);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.database.CursorJoiner.Result.staticClass = @__class;
				global::android.database.CursorJoiner.Result._values2254 = @__env.GetStaticMethodID(global::android.database.CursorJoiner.Result.staticClass, "values", "()[Landroid/database/CursorJoiner/Result;");
				global::android.database.CursorJoiner.Result._valueOf2255 = @__env.GetStaticMethodID(global::android.database.CursorJoiner.Result.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/database/CursorJoiner$Result;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _iterator2259;
		public global::java.util.Iterator iterator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorJoiner._iterator2259));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Iterator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._iterator2259));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasNext2260;
		public bool hasNext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.CursorJoiner._hasNext2260);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._hasNext2260);
		}
		internal static global::net.sf.jni4net.jni.MethodId _next2261;
		public global::java.lang.Object next() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorJoiner._next2261));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._next2261));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove2262;
		public void remove() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.CursorJoiner._remove2262);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._remove2262);
		}
		internal static global::net.sf.jni4net.jni.MethodId _CursorJoiner2263;
		public CursorJoiner(android.database.Cursor arg0, java.lang.String[] arg1, android.database.Cursor arg2, java.lang.String[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.CursorJoiner.staticClass, global::android.database.CursorJoiner._CursorJoiner2263, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.CursorJoiner.staticClass = @__class;
			global::android.database.CursorJoiner._iterator2259 = @__env.GetMethodID(global::android.database.CursorJoiner.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::android.database.CursorJoiner._hasNext2260 = @__env.GetMethodID(global::android.database.CursorJoiner.staticClass, "hasNext", "()Z");
			global::android.database.CursorJoiner._next2261 = @__env.GetMethodID(global::android.database.CursorJoiner.staticClass, "next", "()Ljava/lang/Object;");
			global::android.database.CursorJoiner._remove2262 = @__env.GetMethodID(global::android.database.CursorJoiner.staticClass, "remove", "()V");
			global::android.database.CursorJoiner._CursorJoiner2263 = @__env.GetMethodID(global::android.database.CursorJoiner.staticClass, "<init>", "(Landroid/database/Cursor;[Ljava/lang/String;Landroid/database/Cursor;[Ljava/lang/String;)V");
		}
	}
}
