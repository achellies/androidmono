namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlphaAnimation : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlphaAnimation()
		{
			InitJNI();
		}
		protected AlphaAnimation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _willChangeTransformationMatrix9895;
		public override bool willChangeTransformationMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation._willChangeTransformationMatrix9895);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._willChangeTransformationMatrix9895);
		}
		internal static global::MonoJavaBridge.MethodId _willChangeBounds9896;
		public override bool willChangeBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation._willChangeBounds9896);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._willChangeBounds9896);
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation9897;
		protected override void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation._applyTransformation9897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._applyTransformation9897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AlphaAnimation9898;
		public AlphaAnimation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._AlphaAnimation9898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AlphaAnimation9899;
		public AlphaAnimation(float arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AlphaAnimation.staticClass, global::android.view.animation.AlphaAnimation._AlphaAnimation9899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AlphaAnimation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AlphaAnimation"));
			global::android.view.animation.AlphaAnimation._willChangeTransformationMatrix9895 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "willChangeTransformationMatrix", "()Z");
			global::android.view.animation.AlphaAnimation._willChangeBounds9896 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "willChangeBounds", "()Z");
			global::android.view.animation.AlphaAnimation._applyTransformation9897 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.AlphaAnimation._AlphaAnimation9898 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.AlphaAnimation._AlphaAnimation9899 = @__env.GetMethodIDNoThrow(global::android.view.animation.AlphaAnimation.staticClass, "<init>", "(FF)V");
		}
	}
}
