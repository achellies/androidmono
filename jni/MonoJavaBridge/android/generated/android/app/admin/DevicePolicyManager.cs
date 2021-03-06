namespace android.app.admin
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DevicePolicyManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DevicePolicyManager()
		{
			InitJNI();
		}
		protected DevicePolicyManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAdminActive897;
		public virtual bool isAdminActive(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._isAdminActive897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._isAdminActive897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActiveAdmins898;
		public virtual global::java.util.List getActiveAdmins() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._getActiveAdmins898)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getActiveAdmins898)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _removeActiveAdmin899;
		public virtual void removeActiveAdmin(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._removeActiveAdmin899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._removeActiveAdmin899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPasswordQuality900;
		public virtual void setPasswordQuality(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._setPasswordQuality900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setPasswordQuality900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPasswordQuality901;
		public virtual int getPasswordQuality(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._getPasswordQuality901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getPasswordQuality901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPasswordMinimumLength902;
		public virtual void setPasswordMinimumLength(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._setPasswordMinimumLength902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setPasswordMinimumLength902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPasswordMinimumLength903;
		public virtual int getPasswordMinimumLength(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._getPasswordMinimumLength903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getPasswordMinimumLength903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPasswordMaximumLength904;
		public virtual int getPasswordMaximumLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._getPasswordMaximumLength904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getPasswordMaximumLength904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isActivePasswordSufficient905;
		public virtual bool isActivePasswordSufficient() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._isActivePasswordSufficient905);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._isActivePasswordSufficient905);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFailedPasswordAttempts906;
		public virtual int getCurrentFailedPasswordAttempts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._getCurrentFailedPasswordAttempts906);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getCurrentFailedPasswordAttempts906);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumFailedPasswordsForWipe907;
		public virtual void setMaximumFailedPasswordsForWipe(android.content.ComponentName arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._setMaximumFailedPasswordsForWipe907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setMaximumFailedPasswordsForWipe907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumFailedPasswordsForWipe908;
		public virtual int getMaximumFailedPasswordsForWipe(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._getMaximumFailedPasswordsForWipe908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getMaximumFailedPasswordsForWipe908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetPassword909;
		public virtual bool resetPassword(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._resetPassword909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._resetPassword909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumTimeToLock910;
		public virtual void setMaximumTimeToLock(android.content.ComponentName arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._setMaximumTimeToLock910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._setMaximumTimeToLock910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumTimeToLock911;
		public virtual long getMaximumTimeToLock(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._getMaximumTimeToLock911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._getMaximumTimeToLock911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lockNow912;
		public virtual void lockNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._lockNow912);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._lockNow912);
		}
		internal static global::MonoJavaBridge.MethodId _wipeData913;
		public virtual void wipeData(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager._wipeData913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DevicePolicyManager.staticClass, global::android.app.admin.DevicePolicyManager._wipeData913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.lang.String ACTION_ADD_DEVICE_ADMIN
		{
			get
			{
				return "android.app.action.ADD_DEVICE_ADMIN";
			}
		}
		public static global::java.lang.String EXTRA_DEVICE_ADMIN
		{
			get
			{
				return "android.app.extra.DEVICE_ADMIN";
			}
		}
		public static global::java.lang.String EXTRA_ADD_EXPLANATION
		{
			get
			{
				return "android.app.extra.ADD_EXPLANATION";
			}
		}
		public static global::java.lang.String ACTION_SET_NEW_PASSWORD
		{
			get
			{
				return "android.app.action.SET_NEW_PASSWORD";
			}
		}
		public static int PASSWORD_QUALITY_UNSPECIFIED
		{
			get
			{
				return 0;
			}
		}
		public static int PASSWORD_QUALITY_SOMETHING
		{
			get
			{
				return 65536;
			}
		}
		public static int PASSWORD_QUALITY_NUMERIC
		{
			get
			{
				return 131072;
			}
		}
		public static int PASSWORD_QUALITY_ALPHABETIC
		{
			get
			{
				return 262144;
			}
		}
		public static int PASSWORD_QUALITY_ALPHANUMERIC
		{
			get
			{
				return 327680;
			}
		}
		public static int RESET_PASSWORD_REQUIRE_ENTRY
		{
			get
			{
				return 1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.admin.DevicePolicyManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/admin/DevicePolicyManager"));
			global::android.app.admin.DevicePolicyManager._isAdminActive897 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "isAdminActive", "(Landroid/content/ComponentName;)Z");
			global::android.app.admin.DevicePolicyManager._getActiveAdmins898 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getActiveAdmins", "()Ljava/util/List;");
			global::android.app.admin.DevicePolicyManager._removeActiveAdmin899 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "removeActiveAdmin", "(Landroid/content/ComponentName;)V");
			global::android.app.admin.DevicePolicyManager._setPasswordQuality900 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "setPasswordQuality", "(Landroid/content/ComponentName;I)V");
			global::android.app.admin.DevicePolicyManager._getPasswordQuality901 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordQuality", "(Landroid/content/ComponentName;)I");
			global::android.app.admin.DevicePolicyManager._setPasswordMinimumLength902 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "setPasswordMinimumLength", "(Landroid/content/ComponentName;I)V");
			global::android.app.admin.DevicePolicyManager._getPasswordMinimumLength903 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordMinimumLength", "(Landroid/content/ComponentName;)I");
			global::android.app.admin.DevicePolicyManager._getPasswordMaximumLength904 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getPasswordMaximumLength", "(I)I");
			global::android.app.admin.DevicePolicyManager._isActivePasswordSufficient905 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "isActivePasswordSufficient", "()Z");
			global::android.app.admin.DevicePolicyManager._getCurrentFailedPasswordAttempts906 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getCurrentFailedPasswordAttempts", "()I");
			global::android.app.admin.DevicePolicyManager._setMaximumFailedPasswordsForWipe907 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "setMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;I)V");
			global::android.app.admin.DevicePolicyManager._getMaximumFailedPasswordsForWipe908 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getMaximumFailedPasswordsForWipe", "(Landroid/content/ComponentName;)I");
			global::android.app.admin.DevicePolicyManager._resetPassword909 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "resetPassword", "(Ljava/lang/String;I)Z");
			global::android.app.admin.DevicePolicyManager._setMaximumTimeToLock910 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "setMaximumTimeToLock", "(Landroid/content/ComponentName;J)V");
			global::android.app.admin.DevicePolicyManager._getMaximumTimeToLock911 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "getMaximumTimeToLock", "(Landroid/content/ComponentName;)J");
			global::android.app.admin.DevicePolicyManager._lockNow912 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "lockNow", "()V");
			global::android.app.admin.DevicePolicyManager._wipeData913 = @__env.GetMethodIDNoThrow(global::android.app.admin.DevicePolicyManager.staticClass, "wipeData", "(I)V");
		}
	}
}
