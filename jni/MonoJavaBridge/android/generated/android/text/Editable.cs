namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Editable : java.lang.CharSequence, GetChars, Spannable, java.lang.Appendable
	{
		new global::android.text.Editable append(java.lang.CharSequence arg0, int arg1, int arg2);
		new global::android.text.Editable append(java.lang.CharSequence arg0);
		new global::android.text.Editable append(char arg0);
		void clear();
		global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4);
		global::android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2);
		global::android.text.Editable delete(int arg0, int arg1);
		global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1);
		global::android.text.Editable insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3);
		void setFilters(android.text.InputFilter[] arg0);
		global::android.text.InputFilter[] getFilters();
		void clearSpans();
	}

	public partial class Editable_
	{
		public static global::java.lang.Class _class
		{
			get { return __Editable.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Editable : java.lang.Object, Editable
	{
		internal static global::java.lang.Class staticClass;
		static __Editable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.__Editable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.__Editable(@__env);
			}
		}
		internal __Editable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _append6748;
		 global::android.text.Editable android.text.Editable.append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._append6748, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._append6748, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append6749;
		 global::android.text.Editable android.text.Editable.append(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._append6749, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._append6749, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append6750;
		 global::android.text.Editable android.text.Editable.append(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._append6750, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._append6750, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear6751;
		 void android.text.Editable.clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.__Editable._clear6751);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._clear6751);
		}
		internal static global::net.sf.jni4net.jni.MethodId _replace6752;
		 global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._replace6752, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._replace6752, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _replace6753;
		 global::android.text.Editable android.text.Editable.replace(int arg0, int arg1, java.lang.CharSequence arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._replace6753, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._replace6753, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _delete6754;
		 global::android.text.Editable android.text.Editable.delete(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._delete6754, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._delete6754, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _insert6755;
		 global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._insert6755, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._insert6755, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _insert6756;
		 global::android.text.Editable android.text.Editable.insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._insert6756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.text.Editable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._insert6756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilters6757;
		 void android.text.Editable.setFilters(android.text.InputFilter[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.__Editable._setFilters6757, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.text.InputFilter[], android.text.InputFilter>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._setFilters6757, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.text.InputFilter[], android.text.InputFilter>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFilters6758;
		 global::android.text.InputFilter[] android.text.Editable.getFilters() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._getFilters6758));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._getFilters6758));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearSpans6759;
		 void android.text.Editable.clearSpans() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.__Editable._clearSpans6759);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._clearSpans6759);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString6760;
		 global::java.lang.String java.lang.CharSequence.toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._toString6760));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._toString6760));
		}
		internal static global::net.sf.jni4net.jni.MethodId _length6761;
		 int java.lang.CharSequence.length() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__Editable._length6761);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._length6761);
		}
		internal static global::net.sf.jni4net.jni.MethodId _charAt6762;
		 char java.lang.CharSequence.charAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::android.text.__Editable._charAt6762, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._charAt6762, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _subSequence6763;
		 global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._subSequence6763, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._subSequence6763, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChars6764;
		 void android.text.GetChars.getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.__Editable._getChars6764, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._getChars6764, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSpan6765;
		 void android.text.Spannable.setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.__Editable._setSpan6765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._setSpan6765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeSpan6766;
		 void android.text.Spannable.removeSpan(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.__Editable._removeSpan6766, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._removeSpan6766, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpans6767;
		 global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._getSpans6767, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._getSpans6767, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanStart6768;
		 int android.text.Spanned.getSpanStart(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__Editable._getSpanStart6768, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._getSpanStart6768, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanEnd6769;
		 int android.text.Spanned.getSpanEnd(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__Editable._getSpanEnd6769, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._getSpanEnd6769, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanFlags6770;
		 int android.text.Spanned.getSpanFlags(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__Editable._getSpanFlags6770, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._getSpanFlags6770, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextSpanTransition6771;
		 int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.__Editable._nextSpanTransition6771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._nextSpanTransition6771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append6772;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._append6772, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._append6772, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append6773;
		 global::java.lang.Appendable java.lang.Appendable.append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._append6773, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._append6773, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append6774;
		 global::java.lang.Appendable java.lang.Appendable.append(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.__Editable._append6774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.__Editable.staticClass, global::android.text.__Editable._append6774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.__Editable.staticClass = @__class;
			global::android.text.__Editable._append6748 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.__Editable._append6749 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.__Editable._append6750 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.append", "(C)Landroid/text/Editable;");
			global::android.text.__Editable._clear6751 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.clear", "()V");
			global::android.text.__Editable._replace6752 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.__Editable._replace6753 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.__Editable._delete6754 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.delete", "(II)Landroid/text/Editable;");
			global::android.text.__Editable._insert6755 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;");
			global::android.text.__Editable._insert6756 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;");
			global::android.text.__Editable._setFilters6757 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.setFilters", "([Landroid/text/InputFilter;)V");
			global::android.text.__Editable._getFilters6758 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.getFilters", "()[Landroid/text/InputFilter;");
			global::android.text.__Editable._clearSpans6759 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Editable.clearSpans", "()V");
			global::android.text.__Editable._toString6760 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "java.lang.CharSequence.toString", "()Ljava/lang/String;");
			global::android.text.__Editable._length6761 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "java.lang.CharSequence.length", "()I");
			global::android.text.__Editable._charAt6762 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "java.lang.CharSequence.charAt", "(I)C");
			global::android.text.__Editable._subSequence6763 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "java.lang.CharSequence.subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.__Editable._getChars6764 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.GetChars.getChars", "(II[CI)V");
			global::android.text.__Editable._setSpan6765 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Spannable.setSpan", "(Ljava/lang/Object;III)V");
			global::android.text.__Editable._removeSpan6766 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Spannable.removeSpan", "(Ljava/lang/Object;)V");
			global::android.text.__Editable._getSpans6767 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Spanned.getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.__Editable._getSpanStart6768 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Spanned.getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.__Editable._getSpanEnd6769 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Spanned.getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.__Editable._getSpanFlags6770 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Spanned.getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.__Editable._nextSpanTransition6771 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "android.text.Spanned.nextSpanTransition", "(IILjava/lang/Class;)I");
			global::android.text.__Editable._append6772 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "java.lang.Appendable.append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::android.text.__Editable._append6773 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "java.lang.Appendable.append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::android.text.__Editable._append6774 = @__env.GetMethodID(global::android.text.__Editable.staticClass, "java.lang.Appendable.append", "(C)Ljava/lang/Appendable;");
		}
	}
}
