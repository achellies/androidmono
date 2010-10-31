namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.DoubleBuffer_))]
	public abstract partial class DoubleBuffer : java.nio.Buffer, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DoubleBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract double get();
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer.staticClass, "get", "([D)Ljava/nio/DoubleBuffer;", ref global::java.nio.DoubleBuffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.nio.DoubleBuffer get(double[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer.staticClass, "get", "([DII)Ljava/nio/DoubleBuffer;", ref global::java.nio.DoubleBuffer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract double get(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.nio.DoubleBuffer put(java.nio.DoubleBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer.staticClass, "put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;", ref global::java.nio.DoubleBuffer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.nio.DoubleBuffer put(double arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract global::java.nio.DoubleBuffer put(int arg0, double arg1);
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer.staticClass, "put", "([DII)Ljava/nio/DoubleBuffer;", ref global::java.nio.DoubleBuffer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.nio.DoubleBuffer put(double[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer.staticClass, "put", "([D)Ljava/nio/DoubleBuffer;", ref global::java.nio.DoubleBuffer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.DoubleBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.DoubleBuffer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.DoubleBuffer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.DoubleBuffer._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.DoubleBuffer.staticClass, "hashCode", "()I", ref global::java.nio.DoubleBuffer._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.DoubleBuffer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int compareTo(java.nio.DoubleBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/nio/DoubleBuffer;)I", ref global::java.nio.DoubleBuffer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract bool isDirect();
		private static global::MonoJavaBridge.MethodId _m15;
		public sealed override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.DoubleBuffer.staticClass, "hasArray", "()Z", ref global::java.nio.DoubleBuffer._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer.staticClass, "array", "()Ljava/lang/Object;", ref global::java.nio.DoubleBuffer._m16) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public sealed override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.DoubleBuffer.staticClass, "arrayOffset", "()I", ref global::java.nio.DoubleBuffer._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.DoubleBuffer._m18.native == global::System.IntPtr.Zero)
				global::java.nio.DoubleBuffer._m18 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "wrap", "([DII)Ljava/nio/DoubleBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.nio.DoubleBuffer wrap(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.DoubleBuffer._m19.native == global::System.IntPtr.Zero)
				global::java.nio.DoubleBuffer._m19 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "wrap", "([D)Ljava/nio/DoubleBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.nio.DoubleBuffer allocate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.DoubleBuffer._m20.native == global::System.IntPtr.Zero)
				global::java.nio.DoubleBuffer._m20 = @__env.GetStaticMethodIDNoThrow(global::java.nio.DoubleBuffer.staticClass, "allocate", "(I)Ljava/nio/DoubleBuffer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.DoubleBuffer.staticClass, global::java.nio.DoubleBuffer._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract global::java.nio.DoubleBuffer duplicate();
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract global::java.nio.DoubleBuffer slice();
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract global::java.nio.DoubleBuffer asReadOnlyBuffer();
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract global::java.nio.DoubleBuffer compact();
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract global::java.nio.ByteOrder order();
		static DoubleBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.DoubleBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/DoubleBuffer"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.DoubleBuffer))]
	internal sealed partial class DoubleBuffer_ : java.nio.DoubleBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DoubleBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override double get()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.nio.DoubleBuffer_.staticClass, "get", "()D", ref global::java.nio.DoubleBuffer_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override double get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.nio.DoubleBuffer_.staticClass, "get", "(I)D", ref global::java.nio.DoubleBuffer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.nio.DoubleBuffer put(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer_.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;", ref global::java.nio.DoubleBuffer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.DoubleBuffer put(int arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer_.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;", ref global::java.nio.DoubleBuffer_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isDirect()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.DoubleBuffer_.staticClass, "isDirect", "()Z", ref global::java.nio.DoubleBuffer_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.nio.DoubleBuffer duplicate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer_.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;", ref global::java.nio.DoubleBuffer_._m5) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.nio.DoubleBuffer slice()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer_.staticClass, "slice", "()Ljava/nio/DoubleBuffer;", ref global::java.nio.DoubleBuffer_._m6) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.DoubleBuffer asReadOnlyBuffer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer_.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;", ref global::java.nio.DoubleBuffer_._m7) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.nio.DoubleBuffer compact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.DoubleBuffer_.staticClass, "compact", "()Ljava/nio/DoubleBuffer;", ref global::java.nio.DoubleBuffer_._m8) as java.nio.DoubleBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.nio.ByteOrder order()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.nio.ByteOrder>(this, global::java.nio.DoubleBuffer_.staticClass, "order", "()Ljava/nio/ByteOrder;", ref global::java.nio.DoubleBuffer_._m9) as java.nio.ByteOrder;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.DoubleBuffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.DoubleBuffer_._m10);
		}
		static DoubleBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.DoubleBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/DoubleBuffer"));
		}
	}
}