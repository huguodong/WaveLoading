using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ME.Itangqi.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='me.itangqi.library']/class[@name='R']"
	[global::Android.Runtime.Register ("me/itangqi/library/R", DoNotGenerateAcw=true)]
	public sealed partial class R : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']"
		[global::Android.Runtime.Register ("me/itangqi/library/R$attr", DoNotGenerateAcw=true)]
		public sealed partial class Attr : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='borderColor']"
			[Register ("borderColor")]
			public const int BorderColor = (int) 2130771969;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='borderWidth']"
			[Register ("borderWidth")]
			public const int BorderWidth = (int) 2130771968;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='progressValue']"
			[Register ("progressValue")]
			public const int ProgressValue = (int) 2130771970;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='shapeType']"
			[Register ("shapeType")]
			public const int ShapeType = (int) 2130771971;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='titleBottom']"
			[Register ("titleBottom")]
			public const int TitleBottom = (int) 2130771982;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='titleBottomColor']"
			[Register ("titleBottomColor")]
			public const int TitleBottomColor = (int) 2130771979;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='titleBottomSize']"
			[Register ("titleBottomSize")]
			public const int TitleBottomSize = (int) 2130771976;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='titleCenter']"
			[Register ("titleCenter")]
			public const int TitleCenter = (int) 2130771981;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='titleCenterColor']"
			[Register ("titleCenterColor")]
			public const int TitleCenterColor = (int) 2130771978;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='titleCenterSize']"
			[Register ("titleCenterSize")]
			public const int TitleCenterSize = (int) 2130771975;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='titleTop']"
			[Register ("titleTop")]
			public const int TitleTop = (int) 2130771980;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='titleTopColor']"
			[Register ("titleTopColor")]
			public const int TitleTopColor = (int) 2130771977;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='titleTopSize']"
			[Register ("titleTopSize")]
			public const int TitleTopSize = (int) 2130771974;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='waveAmplitude']"
			[Register ("waveAmplitude")]
			public const int WaveAmplitude = (int) 2130771973;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/field[@name='waveColor']"
			[Register ("waveColor")]
			public const int WaveColor = (int) 2130771972;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("me/itangqi/library/R$attr", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Attr); }
			}

			internal Attr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.attr']/constructor[@name='R.attr' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Attr ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Attr)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.id']"
		[global::Android.Runtime.Register ("me/itangqi/library/R$id", DoNotGenerateAcw=true)]
		public sealed partial class Id : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.id']/field[@name='circle']"
			[Register ("circle")]
			public const int Circle = (int) 2130837504;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.id']/field[@name='square']"
			[Register ("square")]
			public const int Square = (int) 2130837505;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("me/itangqi/library/R$id", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Id); }
			}

			internal Id (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.id']/constructor[@name='R.id' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Id ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Id)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.string']"
		[global::Android.Runtime.Register ("me/itangqi/library/R$string", DoNotGenerateAcw=true)]
		public sealed partial class String : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.string']/field[@name='app_name']"
			[Register ("app_name")]
			public const int AppName = (int) 2130903040;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("me/itangqi/library/R$string", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (String); }
			}

			internal String (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.string']/constructor[@name='R.string' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe String ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (String)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']"
		[global::Android.Runtime.Register ("me/itangqi/library/R$styleable", DoNotGenerateAcw=true)]
		public sealed partial class Styleable : global::Java.Lang.Object {


			static IntPtr WaveLoadingView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView']"
			[Register ("WaveLoadingView")]
			public static IList<int> WaveLoadingView {
				get {
					if (WaveLoadingView_jfieldId == IntPtr.Zero)
						WaveLoadingView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WaveLoadingView", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, WaveLoadingView_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_borderColor']"
			[Register ("WaveLoadingView_borderColor")]
			public const int WaveLoadingViewBorderColor = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_borderWidth']"
			[Register ("WaveLoadingView_borderWidth")]
			public const int WaveLoadingViewBorderWidth = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_progressValue']"
			[Register ("WaveLoadingView_progressValue")]
			public const int WaveLoadingViewProgressValue = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_shapeType']"
			[Register ("WaveLoadingView_shapeType")]
			public const int WaveLoadingViewShapeType = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_titleBottom']"
			[Register ("WaveLoadingView_titleBottom")]
			public const int WaveLoadingViewTitleBottom = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_titleBottomColor']"
			[Register ("WaveLoadingView_titleBottomColor")]
			public const int WaveLoadingViewTitleBottomColor = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_titleBottomSize']"
			[Register ("WaveLoadingView_titleBottomSize")]
			public const int WaveLoadingViewTitleBottomSize = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_titleCenter']"
			[Register ("WaveLoadingView_titleCenter")]
			public const int WaveLoadingViewTitleCenter = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_titleCenterColor']"
			[Register ("WaveLoadingView_titleCenterColor")]
			public const int WaveLoadingViewTitleCenterColor = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_titleCenterSize']"
			[Register ("WaveLoadingView_titleCenterSize")]
			public const int WaveLoadingViewTitleCenterSize = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_titleTop']"
			[Register ("WaveLoadingView_titleTop")]
			public const int WaveLoadingViewTitleTop = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_titleTopColor']"
			[Register ("WaveLoadingView_titleTopColor")]
			public const int WaveLoadingViewTitleTopColor = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_titleTopSize']"
			[Register ("WaveLoadingView_titleTopSize")]
			public const int WaveLoadingViewTitleTopSize = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_waveAmplitude']"
			[Register ("WaveLoadingView_waveAmplitude")]
			public const int WaveLoadingViewWaveAmplitude = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/field[@name='WaveLoadingView_waveColor']"
			[Register ("WaveLoadingView_waveColor")]
			public const int WaveLoadingViewWaveColor = (int) 4;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("me/itangqi/library/R$styleable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Styleable); }
			}

			internal Styleable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='me.itangqi.library']/class[@name='R.styleable']/constructor[@name='R.styleable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Styleable ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Styleable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("me/itangqi/library/R", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (R); }
		}

		internal R (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.itangqi.library']/class[@name='R']/constructor[@name='R' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe R ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (R)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
