using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ME.Itangqi.Waveloadingview {

	// Metadata.xml XPath class reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']"
	[global::Android.Runtime.Register ("me/itangqi/waveloadingview/WaveLoadingView", DoNotGenerateAcw=true)]
	public partial class WaveLoadingView : global::Android.Views.View {

		// Metadata.xml XPath class reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView.ShapeType']"
		[global::Android.Runtime.Register ("me/itangqi/waveloadingview/WaveLoadingView$ShapeType", DoNotGenerateAcw=true)]
		public sealed partial class ShapeType : global::Java.Lang.Enum {


			static IntPtr CIRCLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView.ShapeType']/field[@name='CIRCLE']"
			[Register ("CIRCLE")]
			public static global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType Circle {
				get {
					if (CIRCLE_jfieldId == IntPtr.Zero)
						CIRCLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CIRCLE", "Lme/itangqi/waveloadingview/WaveLoadingView$ShapeType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CIRCLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SQUARE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView.ShapeType']/field[@name='SQUARE']"
			[Register ("SQUARE")]
			public static global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType Square {
				get {
					if (SQUARE_jfieldId == IntPtr.Zero)
						SQUARE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SQUARE", "Lme/itangqi/waveloadingview/WaveLoadingView$ShapeType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SQUARE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("me/itangqi/waveloadingview/WaveLoadingView$ShapeType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ShapeType); }
			}

			internal ShapeType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView.ShapeType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lme/itangqi/waveloadingview/WaveLoadingView$ShapeType;", "")]
			public static unsafe global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lme/itangqi/waveloadingview/WaveLoadingView$ShapeType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType __ret = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView.ShapeType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lme/itangqi/waveloadingview/WaveLoadingView$ShapeType;", "")]
			public static unsafe global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lme/itangqi/waveloadingview/WaveLoadingView$ShapeType;");
				try {
					return (global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("me/itangqi/waveloadingview/WaveLoadingView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WaveLoadingView); }
		}

		protected WaveLoadingView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/constructor[@name='WaveLoadingView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe WaveLoadingView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (WaveLoadingView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/constructor[@name='WaveLoadingView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WaveLoadingView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (WaveLoadingView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/constructor[@name='WaveLoadingView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe WaveLoadingView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (WaveLoadingView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static Delegate cb_getAmplitudeRatio;
#pragma warning disable 0169
		static Delegate GetGetAmplitudeRatioHandler ()
		{
			if (cb_getAmplitudeRatio == null)
				cb_getAmplitudeRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAmplitudeRatio);
			return cb_getAmplitudeRatio;
		}

		static float n_GetAmplitudeRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AmplitudeRatio;
		}
#pragma warning restore 0169

		static IntPtr id_getAmplitudeRatio;
		public virtual unsafe float AmplitudeRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getAmplitudeRatio' and count(parameter)=0]"
			[Register ("getAmplitudeRatio", "()F", "GetGetAmplitudeRatioHandler")]
			get {
				if (id_getAmplitudeRatio == IntPtr.Zero)
					id_getAmplitudeRatio = JNIEnv.GetMethodID (class_ref, "getAmplitudeRatio", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getAmplitudeRatio);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAmplitudeRatio", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getBorderColor;
#pragma warning disable 0169
		static Delegate GetGetBorderColorHandler ()
		{
			if (cb_getBorderColor == null)
				cb_getBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBorderColor);
			return cb_getBorderColor;
		}

		static int n_GetBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderColor;
		}
#pragma warning restore 0169

		static Delegate cb_setBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetBorderColor_IHandler ()
		{
			if (cb_setBorderColor_I == null)
				cb_setBorderColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBorderColor_I);
			return cb_setBorderColor_I;
		}

		static void n_SetBorderColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BorderColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBorderColor;
		static IntPtr id_setBorderColor_I;
		public virtual unsafe int BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getBorderColor' and count(parameter)=0]"
			[Register ("getBorderColor", "()I", "GetGetBorderColorHandler")]
			get {
				if (id_getBorderColor == IntPtr.Zero)
					id_getBorderColor = JNIEnv.GetMethodID (class_ref, "getBorderColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getBorderColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBorderColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBorderColor", "(I)V", "GetSetBorderColor_IHandler")]
			set {
				if (id_setBorderColor_I == IntPtr.Zero)
					id_setBorderColor_I = JNIEnv.GetMethodID (class_ref, "setBorderColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBorderColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBorderColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBorderWidth;
#pragma warning disable 0169
		static Delegate GetGetBorderWidthHandler ()
		{
			if (cb_getBorderWidth == null)
				cb_getBorderWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBorderWidth);
			return cb_getBorderWidth;
		}

		static float n_GetBorderWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setBorderWidth_F;
#pragma warning disable 0169
		static Delegate GetSetBorderWidth_FHandler ()
		{
			if (cb_setBorderWidth_F == null)
				cb_setBorderWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBorderWidth_F);
			return cb_setBorderWidth_F;
		}

		static void n_SetBorderWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BorderWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBorderWidth;
		static IntPtr id_setBorderWidth_F;
		public virtual unsafe float BorderWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getBorderWidth' and count(parameter)=0]"
			[Register ("getBorderWidth", "()F", "GetGetBorderWidthHandler")]
			get {
				if (id_getBorderWidth == IntPtr.Zero)
					id_getBorderWidth = JNIEnv.GetMethodID (class_ref, "getBorderWidth", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getBorderWidth);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBorderWidth", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setBorderWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBorderWidth", "(F)V", "GetSetBorderWidth_FHandler")]
			set {
				if (id_setBorderWidth_F == IntPtr.Zero)
					id_setBorderWidth_F = JNIEnv.GetMethodID (class_ref, "setBorderWidth", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBorderWidth_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBorderWidth", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBottomTitle;
#pragma warning disable 0169
		static Delegate GetGetBottomTitleHandler ()
		{
			if (cb_getBottomTitle == null)
				cb_getBottomTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBottomTitle);
			return cb_getBottomTitle;
		}

		static IntPtr n_GetBottomTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BottomTitle);
		}
#pragma warning restore 0169

		static Delegate cb_setBottomTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBottomTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setBottomTitle_Ljava_lang_String_ == null)
				cb_setBottomTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBottomTitle_Ljava_lang_String_);
			return cb_setBottomTitle_Ljava_lang_String_;
		}

		static void n_SetBottomTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BottomTitle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBottomTitle;
		static IntPtr id_setBottomTitle_Ljava_lang_String_;
		public virtual unsafe string BottomTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getBottomTitle' and count(parameter)=0]"
			[Register ("getBottomTitle", "()Ljava/lang/String;", "GetGetBottomTitleHandler")]
			get {
				if (id_getBottomTitle == IntPtr.Zero)
					id_getBottomTitle = JNIEnv.GetMethodID (class_ref, "getBottomTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBottomTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBottomTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setBottomTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBottomTitle", "(Ljava/lang/String;)V", "GetSetBottomTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setBottomTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setBottomTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBottomTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBottomTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBottomTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBottomTitleColor;
#pragma warning disable 0169
		static Delegate GetGetBottomTitleColorHandler ()
		{
			if (cb_getBottomTitleColor == null)
				cb_getBottomTitleColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBottomTitleColor);
			return cb_getBottomTitleColor;
		}

		static int n_GetBottomTitleColor (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BottomTitleColor;
		}
#pragma warning restore 0169

		static Delegate cb_setBottomTitleColor_I;
#pragma warning disable 0169
		static Delegate GetSetBottomTitleColor_IHandler ()
		{
			if (cb_setBottomTitleColor_I == null)
				cb_setBottomTitleColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBottomTitleColor_I);
			return cb_setBottomTitleColor_I;
		}

		static void n_SetBottomTitleColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BottomTitleColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBottomTitleColor;
		static IntPtr id_setBottomTitleColor_I;
		public virtual unsafe int BottomTitleColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getBottomTitleColor' and count(parameter)=0]"
			[Register ("getBottomTitleColor", "()I", "GetGetBottomTitleColorHandler")]
			get {
				if (id_getBottomTitleColor == IntPtr.Zero)
					id_getBottomTitleColor = JNIEnv.GetMethodID (class_ref, "getBottomTitleColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getBottomTitleColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBottomTitleColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setBottomTitleColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBottomTitleColor", "(I)V", "GetSetBottomTitleColor_IHandler")]
			set {
				if (id_setBottomTitleColor_I == IntPtr.Zero)
					id_setBottomTitleColor_I = JNIEnv.GetMethodID (class_ref, "setBottomTitleColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBottomTitleColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBottomTitleColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBottomTitleSize;
#pragma warning disable 0169
		static Delegate GetGetBottomTitleSizeHandler ()
		{
			if (cb_getBottomTitleSize == null)
				cb_getBottomTitleSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBottomTitleSize);
			return cb_getBottomTitleSize;
		}

		static float n_GetBottomTitleSize (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BottomTitleSize;
		}
#pragma warning restore 0169

		static Delegate cb_setBottomTitleSize_F;
#pragma warning disable 0169
		static Delegate GetSetBottomTitleSize_FHandler ()
		{
			if (cb_setBottomTitleSize_F == null)
				cb_setBottomTitleSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBottomTitleSize_F);
			return cb_setBottomTitleSize_F;
		}

		static void n_SetBottomTitleSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BottomTitleSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBottomTitleSize;
		static IntPtr id_setBottomTitleSize_F;
		public virtual unsafe float BottomTitleSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getBottomTitleSize' and count(parameter)=0]"
			[Register ("getBottomTitleSize", "()F", "GetGetBottomTitleSizeHandler")]
			get {
				if (id_getBottomTitleSize == IntPtr.Zero)
					id_getBottomTitleSize = JNIEnv.GetMethodID (class_ref, "getBottomTitleSize", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getBottomTitleSize);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBottomTitleSize", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setBottomTitleSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBottomTitleSize", "(F)V", "GetSetBottomTitleSize_FHandler")]
			set {
				if (id_setBottomTitleSize_F == IntPtr.Zero)
					id_setBottomTitleSize_F = JNIEnv.GetMethodID (class_ref, "setBottomTitleSize", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBottomTitleSize_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBottomTitleSize", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCenterTitle;
#pragma warning disable 0169
		static Delegate GetGetCenterTitleHandler ()
		{
			if (cb_getCenterTitle == null)
				cb_getCenterTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenterTitle);
			return cb_getCenterTitle;
		}

		static IntPtr n_GetCenterTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CenterTitle);
		}
#pragma warning restore 0169

		static Delegate cb_setCenterTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCenterTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setCenterTitle_Ljava_lang_String_ == null)
				cb_setCenterTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenterTitle_Ljava_lang_String_);
			return cb_setCenterTitle_Ljava_lang_String_;
		}

		static void n_SetCenterTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CenterTitle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCenterTitle;
		static IntPtr id_setCenterTitle_Ljava_lang_String_;
		public virtual unsafe string CenterTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getCenterTitle' and count(parameter)=0]"
			[Register ("getCenterTitle", "()Ljava/lang/String;", "GetGetCenterTitleHandler")]
			get {
				if (id_getCenterTitle == IntPtr.Zero)
					id_getCenterTitle = JNIEnv.GetMethodID (class_ref, "getCenterTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCenterTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCenterTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setCenterTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCenterTitle", "(Ljava/lang/String;)V", "GetSetCenterTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setCenterTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setCenterTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCenterTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCenterTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCenterTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCenterTitleColor;
#pragma warning disable 0169
		static Delegate GetGetCenterTitleColorHandler ()
		{
			if (cb_getCenterTitleColor == null)
				cb_getCenterTitleColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCenterTitleColor);
			return cb_getCenterTitleColor;
		}

		static int n_GetCenterTitleColor (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CenterTitleColor;
		}
#pragma warning restore 0169

		static Delegate cb_setCenterTitleColor_I;
#pragma warning disable 0169
		static Delegate GetSetCenterTitleColor_IHandler ()
		{
			if (cb_setCenterTitleColor_I == null)
				cb_setCenterTitleColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCenterTitleColor_I);
			return cb_setCenterTitleColor_I;
		}

		static void n_SetCenterTitleColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CenterTitleColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCenterTitleColor;
		static IntPtr id_setCenterTitleColor_I;
		public virtual unsafe int CenterTitleColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getCenterTitleColor' and count(parameter)=0]"
			[Register ("getCenterTitleColor", "()I", "GetGetCenterTitleColorHandler")]
			get {
				if (id_getCenterTitleColor == IntPtr.Zero)
					id_getCenterTitleColor = JNIEnv.GetMethodID (class_ref, "getCenterTitleColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCenterTitleColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCenterTitleColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setCenterTitleColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCenterTitleColor", "(I)V", "GetSetCenterTitleColor_IHandler")]
			set {
				if (id_setCenterTitleColor_I == IntPtr.Zero)
					id_setCenterTitleColor_I = JNIEnv.GetMethodID (class_ref, "setCenterTitleColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCenterTitleColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCenterTitleColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCenterTitleSize;
#pragma warning disable 0169
		static Delegate GetGetCenterTitleSizeHandler ()
		{
			if (cb_getCenterTitleSize == null)
				cb_getCenterTitleSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCenterTitleSize);
			return cb_getCenterTitleSize;
		}

		static float n_GetCenterTitleSize (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CenterTitleSize;
		}
#pragma warning restore 0169

		static Delegate cb_setCenterTitleSize_F;
#pragma warning disable 0169
		static Delegate GetSetCenterTitleSize_FHandler ()
		{
			if (cb_setCenterTitleSize_F == null)
				cb_setCenterTitleSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetCenterTitleSize_F);
			return cb_setCenterTitleSize_F;
		}

		static void n_SetCenterTitleSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CenterTitleSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCenterTitleSize;
		static IntPtr id_setCenterTitleSize_F;
		public virtual unsafe float CenterTitleSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getCenterTitleSize' and count(parameter)=0]"
			[Register ("getCenterTitleSize", "()F", "GetGetCenterTitleSizeHandler")]
			get {
				if (id_getCenterTitleSize == IntPtr.Zero)
					id_getCenterTitleSize = JNIEnv.GetMethodID (class_ref, "getCenterTitleSize", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getCenterTitleSize);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCenterTitleSize", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setCenterTitleSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setCenterTitleSize", "(F)V", "GetSetCenterTitleSize_FHandler")]
			set {
				if (id_setCenterTitleSize_F == IntPtr.Zero)
					id_setCenterTitleSize_F = JNIEnv.GetMethodID (class_ref, "setCenterTitleSize", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCenterTitleSize_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCenterTitleSize", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProgressValue;
#pragma warning disable 0169
		static Delegate GetGetProgressValueHandler ()
		{
			if (cb_getProgressValue == null)
				cb_getProgressValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProgressValue);
			return cb_getProgressValue;
		}

		static int n_GetProgressValue (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProgressValue;
		}
#pragma warning restore 0169

		static Delegate cb_setProgressValue_I;
#pragma warning disable 0169
		static Delegate GetSetProgressValue_IHandler ()
		{
			if (cb_setProgressValue_I == null)
				cb_setProgressValue_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProgressValue_I);
			return cb_setProgressValue_I;
		}

		static void n_SetProgressValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProgressValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProgressValue;
		static IntPtr id_setProgressValue_I;
		public virtual unsafe int ProgressValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getProgressValue' and count(parameter)=0]"
			[Register ("getProgressValue", "()I", "GetGetProgressValueHandler")]
			get {
				if (id_getProgressValue == IntPtr.Zero)
					id_getProgressValue = JNIEnv.GetMethodID (class_ref, "getProgressValue", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getProgressValue);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProgressValue", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setProgressValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setProgressValue", "(I)V", "GetSetProgressValue_IHandler")]
			set {
				if (id_setProgressValue_I == IntPtr.Zero)
					id_setProgressValue_I = JNIEnv.GetMethodID (class_ref, "setProgressValue", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setProgressValue_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProgressValue", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTopTitle;
#pragma warning disable 0169
		static Delegate GetGetTopTitleHandler ()
		{
			if (cb_getTopTitle == null)
				cb_getTopTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopTitle);
			return cb_getTopTitle;
		}

		static IntPtr n_GetTopTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TopTitle);
		}
#pragma warning restore 0169

		static Delegate cb_setTopTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTopTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTopTitle_Ljava_lang_String_ == null)
				cb_setTopTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTopTitle_Ljava_lang_String_);
			return cb_setTopTitle_Ljava_lang_String_;
		}

		static void n_SetTopTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TopTitle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTopTitle;
		static IntPtr id_setTopTitle_Ljava_lang_String_;
		public virtual unsafe string TopTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getTopTitle' and count(parameter)=0]"
			[Register ("getTopTitle", "()Ljava/lang/String;", "GetGetTopTitleHandler")]
			get {
				if (id_getTopTitle == IntPtr.Zero)
					id_getTopTitle = JNIEnv.GetMethodID (class_ref, "getTopTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTopTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setTopTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTopTitle", "(Ljava/lang/String;)V", "GetSetTopTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTopTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTopTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTopTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTopTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTopTitleColor;
#pragma warning disable 0169
		static Delegate GetGetTopTitleColorHandler ()
		{
			if (cb_getTopTitleColor == null)
				cb_getTopTitleColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTopTitleColor);
			return cb_getTopTitleColor;
		}

		static int n_GetTopTitleColor (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopTitleColor;
		}
#pragma warning restore 0169

		static Delegate cb_setTopTitleColor_I;
#pragma warning disable 0169
		static Delegate GetSetTopTitleColor_IHandler ()
		{
			if (cb_setTopTitleColor_I == null)
				cb_setTopTitleColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTopTitleColor_I);
			return cb_setTopTitleColor_I;
		}

		static void n_SetTopTitleColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TopTitleColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTopTitleColor;
		static IntPtr id_setTopTitleColor_I;
		public virtual unsafe int TopTitleColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getTopTitleColor' and count(parameter)=0]"
			[Register ("getTopTitleColor", "()I", "GetGetTopTitleColorHandler")]
			get {
				if (id_getTopTitleColor == IntPtr.Zero)
					id_getTopTitleColor = JNIEnv.GetMethodID (class_ref, "getTopTitleColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTopTitleColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopTitleColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setTopTitleColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTopTitleColor", "(I)V", "GetSetTopTitleColor_IHandler")]
			set {
				if (id_setTopTitleColor_I == IntPtr.Zero)
					id_setTopTitleColor_I = JNIEnv.GetMethodID (class_ref, "setTopTitleColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTopTitleColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopTitleColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWaterLevelRatio;
#pragma warning disable 0169
		static Delegate GetGetWaterLevelRatioHandler ()
		{
			if (cb_getWaterLevelRatio == null)
				cb_getWaterLevelRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWaterLevelRatio);
			return cb_getWaterLevelRatio;
		}

		static float n_GetWaterLevelRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WaterLevelRatio;
		}
#pragma warning restore 0169

		static Delegate cb_setWaterLevelRatio_F;
#pragma warning disable 0169
		static Delegate GetSetWaterLevelRatio_FHandler ()
		{
			if (cb_setWaterLevelRatio_F == null)
				cb_setWaterLevelRatio_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetWaterLevelRatio_F);
			return cb_setWaterLevelRatio_F;
		}

		static void n_SetWaterLevelRatio_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaterLevelRatio = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWaterLevelRatio;
		static IntPtr id_setWaterLevelRatio_F;
		public virtual unsafe float WaterLevelRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getWaterLevelRatio' and count(parameter)=0]"
			[Register ("getWaterLevelRatio", "()F", "GetGetWaterLevelRatioHandler")]
			get {
				if (id_getWaterLevelRatio == IntPtr.Zero)
					id_getWaterLevelRatio = JNIEnv.GetMethodID (class_ref, "getWaterLevelRatio", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getWaterLevelRatio);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWaterLevelRatio", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setWaterLevelRatio' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setWaterLevelRatio", "(F)V", "GetSetWaterLevelRatio_FHandler")]
			set {
				if (id_setWaterLevelRatio_F == IntPtr.Zero)
					id_setWaterLevelRatio_F = JNIEnv.GetMethodID (class_ref, "setWaterLevelRatio", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWaterLevelRatio_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWaterLevelRatio", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWaveColor;
#pragma warning disable 0169
		static Delegate GetGetWaveColorHandler ()
		{
			if (cb_getWaveColor == null)
				cb_getWaveColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWaveColor);
			return cb_getWaveColor;
		}

		static int n_GetWaveColor (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WaveColor;
		}
#pragma warning restore 0169

		static Delegate cb_setWaveColor_I;
#pragma warning disable 0169
		static Delegate GetSetWaveColor_IHandler ()
		{
			if (cb_setWaveColor_I == null)
				cb_setWaveColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWaveColor_I);
			return cb_setWaveColor_I;
		}

		static void n_SetWaveColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaveColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWaveColor;
		static IntPtr id_setWaveColor_I;
		public virtual unsafe int WaveColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getWaveColor' and count(parameter)=0]"
			[Register ("getWaveColor", "()I", "GetGetWaveColorHandler")]
			get {
				if (id_getWaveColor == IntPtr.Zero)
					id_getWaveColor = JNIEnv.GetMethodID (class_ref, "getWaveColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getWaveColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWaveColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setWaveColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWaveColor", "(I)V", "GetSetWaveColor_IHandler")]
			set {
				if (id_setWaveColor_I == IntPtr.Zero)
					id_setWaveColor_I = JNIEnv.GetMethodID (class_ref, "setWaveColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWaveColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWaveColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWaveShiftRatio;
#pragma warning disable 0169
		static Delegate GetGetWaveShiftRatioHandler ()
		{
			if (cb_getWaveShiftRatio == null)
				cb_getWaveShiftRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWaveShiftRatio);
			return cb_getWaveShiftRatio;
		}

		static float n_GetWaveShiftRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WaveShiftRatio;
		}
#pragma warning restore 0169

		static Delegate cb_setWaveShiftRatio_F;
#pragma warning disable 0169
		static Delegate GetSetWaveShiftRatio_FHandler ()
		{
			if (cb_setWaveShiftRatio_F == null)
				cb_setWaveShiftRatio_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetWaveShiftRatio_F);
			return cb_setWaveShiftRatio_F;
		}

		static void n_SetWaveShiftRatio_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaveShiftRatio = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWaveShiftRatio;
		static IntPtr id_setWaveShiftRatio_F;
		public virtual unsafe float WaveShiftRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getWaveShiftRatio' and count(parameter)=0]"
			[Register ("getWaveShiftRatio", "()F", "GetGetWaveShiftRatioHandler")]
			get {
				if (id_getWaveShiftRatio == IntPtr.Zero)
					id_getWaveShiftRatio = JNIEnv.GetMethodID (class_ref, "getWaveShiftRatio", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getWaveShiftRatio);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWaveShiftRatio", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setWaveShiftRatio' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setWaveShiftRatio", "(F)V", "GetSetWaveShiftRatio_FHandler")]
			set {
				if (id_setWaveShiftRatio_F == IntPtr.Zero)
					id_setWaveShiftRatio_F = JNIEnv.GetMethodID (class_ref, "setWaveShiftRatio", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWaveShiftRatio_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWaveShiftRatio", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShapeType;
#pragma warning disable 0169
		static Delegate GetGetShapeTypeHandler ()
		{
			if (cb_getShapeType == null)
				cb_getShapeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShapeType);
			return cb_getShapeType;
		}

		static int n_GetShapeType (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetShapeType ();
		}
#pragma warning restore 0169

		static IntPtr id_getShapeType;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getShapeType' and count(parameter)=0]"
		[Register ("getShapeType", "()I", "GetGetShapeTypeHandler")]
		public virtual unsafe int GetShapeType ()
		{
			if (id_getShapeType == IntPtr.Zero)
				id_getShapeType = JNIEnv.GetMethodID (class_ref, "getShapeType", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getShapeType);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShapeType", "()I"));
			} finally {
			}
		}

		static Delegate cb_getsetTopTitleSize;
#pragma warning disable 0169
		static Delegate GetGetsetTopTitleSizeHandler ()
		{
			if (cb_getsetTopTitleSize == null)
				cb_getsetTopTitleSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetsetTopTitleSize);
			return cb_getsetTopTitleSize;
		}

		static float n_GetsetTopTitleSize (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetsetTopTitleSize ();
		}
#pragma warning restore 0169

		static IntPtr id_getsetTopTitleSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='getsetTopTitleSize' and count(parameter)=0]"
		[Register ("getsetTopTitleSize", "()F", "GetGetsetTopTitleSizeHandler")]
		public virtual unsafe float GetsetTopTitleSize ()
		{
			if (id_getsetTopTitleSize == IntPtr.Zero)
				id_getsetTopTitleSize = JNIEnv.GetMethodID (class_ref, "getsetTopTitleSize", "()F");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getsetTopTitleSize);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getsetTopTitleSize", "()F"));
			} finally {
			}
		}

		static Delegate cb_onDraw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetOnDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_onDraw_Landroid_graphics_Canvas_ == null)
				cb_onDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDraw_Landroid_graphics_Canvas_);
			return cb_onDraw_Landroid_graphics_Canvas_;
		}

		static void n_OnDraw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDraw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='onDraw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("onDraw", "(Landroid/graphics/Canvas;)V", "GetOnDraw_Landroid_graphics_Canvas_Handler")]
		public virtual unsafe void OnDraw (global::Android.Graphics.Canvas p0)
		{
			if (id_onDraw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_onDraw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "onDraw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDraw_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDraw", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAmplitudeRatio_I;
#pragma warning disable 0169
		static Delegate GetSetAmplitudeRatio_IHandler ()
		{
			if (cb_setAmplitudeRatio_I == null)
				cb_setAmplitudeRatio_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAmplitudeRatio_I);
			return cb_setAmplitudeRatio_I;
		}

		static void n_SetAmplitudeRatio_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAmplitudeRatio (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAmplitudeRatio_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setAmplitudeRatio' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAmplitudeRatio", "(I)V", "GetSetAmplitudeRatio_IHandler")]
		public virtual unsafe void SetAmplitudeRatio (int p0)
		{
			if (id_setAmplitudeRatio_I == IntPtr.Zero)
				id_setAmplitudeRatio_I = JNIEnv.GetMethodID (class_ref, "setAmplitudeRatio", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAmplitudeRatio_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAmplitudeRatio", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_;
#pragma warning disable 0169
		static Delegate GetSetShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_Handler ()
		{
			if (cb_setShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_ == null)
				cb_setShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_);
			return cb_setShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_;
		}

		static void n_SetShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType p0 = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetShapeType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setShapeType' and count(parameter)=1 and parameter[1][@type='me.itangqi.waveloadingview.WaveLoadingView.ShapeType']]"
		[Register ("setShapeType", "(Lme/itangqi/waveloadingview/WaveLoadingView$ShapeType;)V", "GetSetShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_Handler")]
		public virtual unsafe void SetShapeType (global::ME.Itangqi.Waveloadingview.WaveLoadingView.ShapeType p0)
		{
			if (id_setShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_ == IntPtr.Zero)
				id_setShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_ = JNIEnv.GetMethodID (class_ref, "setShapeType", "(Lme/itangqi/waveloadingview/WaveLoadingView$ShapeType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShapeType_Lme_itangqi_waveloadingview_WaveLoadingView_ShapeType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShapeType", "(Lme/itangqi/waveloadingview/WaveLoadingView$ShapeType;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTopTitleSize_F;
#pragma warning disable 0169
		static Delegate GetSetTopTitleSize_FHandler ()
		{
			if (cb_setTopTitleSize_F == null)
				cb_setTopTitleSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTopTitleSize_F);
			return cb_setTopTitleSize_F;
		}

		static void n_SetTopTitleSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTopTitleSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTopTitleSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='setTopTitleSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTopTitleSize", "(F)V", "GetSetTopTitleSize_FHandler")]
		public virtual unsafe void SetTopTitleSize (float p0)
		{
			if (id_setTopTitleSize_F == IntPtr.Zero)
				id_setTopTitleSize_F = JNIEnv.GetMethodID (class_ref, "setTopTitleSize", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTopTitleSize_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopTitleSize", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sp2px_F;
#pragma warning disable 0169
		static Delegate GetSp2px_FHandler ()
		{
			if (cb_sp2px_F == null)
				cb_sp2px_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, int>) n_Sp2px_F);
			return cb_sp2px_F;
		}

		static int n_Sp2px_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::ME.Itangqi.Waveloadingview.WaveLoadingView __this = global::Java.Lang.Object.GetObject<global::ME.Itangqi.Waveloadingview.WaveLoadingView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sp2px (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sp2px_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.itangqi.waveloadingview']/class[@name='WaveLoadingView']/method[@name='sp2px' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("sp2px", "(F)I", "GetSp2px_FHandler")]
		public virtual unsafe int Sp2px (float p0)
		{
			if (id_sp2px_F == IntPtr.Zero)
				id_sp2px_F = JNIEnv.GetMethodID (class_ref, "sp2px", "(F)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_sp2px_F, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sp2px", "(F)I"), __args);
			} finally {
			}
		}

	}
}
