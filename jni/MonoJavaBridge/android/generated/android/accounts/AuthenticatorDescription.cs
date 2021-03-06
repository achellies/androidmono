namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthenticatorDescription : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthenticatorDescription()
		{
			InitJNI();
		}
		protected AuthenticatorDescription(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals110;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription._equals110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._equals110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString111;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription._toString111)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._toString111)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode112;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription._hashCode112);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._hashCode112);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel113;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription._writeToParcel113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._writeToParcel113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents114;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription._describeContents114);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._describeContents114);
		}
		internal static global::MonoJavaBridge.MethodId _newKey115;
		public static global::android.accounts.AuthenticatorDescription newKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._newKey115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.accounts.AuthenticatorDescription;
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticatorDescription116;
		public AuthenticatorDescription(java.lang.String arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AuthenticatorDescription.staticClass, global::android.accounts.AuthenticatorDescription._AuthenticatorDescription116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _type117;
		public global::java.lang.String type
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _labelId118;
		public int labelId
		{
			get
			{
				return default(int);
			}
		}
		internal static global::MonoJavaBridge.FieldId _iconId119;
		public int iconId
		{
			get
			{
				return default(int);
			}
		}
		internal static global::MonoJavaBridge.FieldId _smallIconId120;
		public int smallIconId
		{
			get
			{
				return default(int);
			}
		}
		internal static global::MonoJavaBridge.FieldId _accountPreferencesId121;
		public int accountPreferencesId
		{
			get
			{
				return default(int);
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName122;
		public global::java.lang.String packageName
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR123;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AuthenticatorDescription.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AuthenticatorDescription"));
			global::android.accounts.AuthenticatorDescription._equals110 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.accounts.AuthenticatorDescription._toString111 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "toString", "()Ljava/lang/String;");
			global::android.accounts.AuthenticatorDescription._hashCode112 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "hashCode", "()I");
			global::android.accounts.AuthenticatorDescription._writeToParcel113 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.accounts.AuthenticatorDescription._describeContents114 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "describeContents", "()I");
			global::android.accounts.AuthenticatorDescription._newKey115 = @__env.GetStaticMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "newKey", "(Ljava/lang/String;)Landroid/accounts/AuthenticatorDescription;");
			global::android.accounts.AuthenticatorDescription._AuthenticatorDescription116 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorDescription.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;IIII)V");
		}
	}
}
