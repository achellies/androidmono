namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.WindowManager_))]
	public interface WindowManager : ViewManager
	{
		global::android.view.Display getDefaultDisplay();
		void removeViewImmediate(android.view.View arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.WindowManager))]
	public sealed partial class WindowManager_ : java.lang.Object, WindowManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WindowManager_()
		{
			InitJNI();
		}
		internal WindowManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultDisplay9836;
		 global::android.view.Display android.view.WindowManager.getDefaultDisplay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.WindowManager_._getDefaultDisplay9836)) as android.view.Display;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.WindowManager_.staticClass, global::android.view.WindowManager_._getDefaultDisplay9836)) as android.view.Display;
		}
		internal static global::MonoJavaBridge.MethodId _removeViewImmediate9837;
		 void android.view.WindowManager.removeViewImmediate(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.WindowManager_._removeViewImmediate9837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.WindowManager_.staticClass, global::android.view.WindowManager_._removeViewImmediate9837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView9838;
		 void android.view.ViewManager.addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.WindowManager_._addView9838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.WindowManager_.staticClass, global::android.view.WindowManager_._addView9838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateViewLayout9839;
		 void android.view.ViewManager.updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.WindowManager_._updateViewLayout9839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.WindowManager_.staticClass, global::android.view.WindowManager_._updateViewLayout9839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeView9840;
		 void android.view.ViewManager.removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.WindowManager_._removeView9840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.WindowManager_.staticClass, global::android.view.WindowManager_._removeView9840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.WindowManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/WindowManager"));
			global::android.view.WindowManager_._getDefaultDisplay9836 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_.staticClass, "getDefaultDisplay", "()Landroid/view/Display;");
			global::android.view.WindowManager_._removeViewImmediate9837 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_.staticClass, "removeViewImmediate", "(Landroid/view/View;)V");
			global::android.view.WindowManager_._addView9838 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.WindowManager_._updateViewLayout9839 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.WindowManager_._removeView9840 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_.staticClass, "removeView", "(Landroid/view/View;)V");
		}
	}
}
