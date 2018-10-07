using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Sundeepk.Compactcalendarview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']"
	[global::Android.Runtime.Register ("com/github/sundeepk/compactcalendarview/CompactCalendarView", DoNotGenerateAcw=true)]
	public partial class CompactCalendarView : global::Android.Views.View {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/field[@name='FILL_LARGE_INDICATOR']"
		[Register ("FILL_LARGE_INDICATOR")]
		public const int FillLargeIndicator = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/field[@name='NO_FILL_LARGE_INDICATOR']"
		[Register ("NO_FILL_LARGE_INDICATOR")]
		public const int NoFillLargeIndicator = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/field[@name='SMALL_INDICATOR']"
		[Register ("SMALL_INDICATOR")]
		public const int SmallIndicator = (int) 3;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/interface[@name='CompactCalendarView.CompactCalendarAnimationListener']"
		[Register ("com/github/sundeepk/compactcalendarview/CompactCalendarView$CompactCalendarAnimationListener", "", "Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView/ICompactCalendarAnimationListenerInvoker")]
		public partial interface ICompactCalendarAnimationListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/interface[@name='CompactCalendarView.CompactCalendarAnimationListener']/method[@name='onClosed' and count(parameter)=0]"
			[Register ("onClosed", "()V", "GetOnClosedHandler:Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView/ICompactCalendarAnimationListenerInvoker, AndroidBindingCompactCalendarView")]
			void OnClosed ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/interface[@name='CompactCalendarView.CompactCalendarAnimationListener']/method[@name='onOpened' and count(parameter)=0]"
			[Register ("onOpened", "()V", "GetOnOpenedHandler:Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView/ICompactCalendarAnimationListenerInvoker, AndroidBindingCompactCalendarView")]
			void OnOpened ();

		}

		[global::Android.Runtime.Register ("com/github/sundeepk/compactcalendarview/CompactCalendarView$CompactCalendarAnimationListener", DoNotGenerateAcw=true)]
		internal class ICompactCalendarAnimationListenerInvoker : global::Java.Lang.Object, ICompactCalendarAnimationListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/sundeepk/compactcalendarview/CompactCalendarView$CompactCalendarAnimationListener", typeof (ICompactCalendarAnimationListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ICompactCalendarAnimationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICompactCalendarAnimationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.github.sundeepk.compactcalendarview.CompactCalendarView.CompactCalendarAnimationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICompactCalendarAnimationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onClosed;
#pragma warning disable 0169
			static Delegate GetOnClosedHandler ()
			{
				if (cb_onClosed == null)
					cb_onClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClosed);
				return cb_onClosed;
			}

			static void n_OnClosed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnClosed ();
			}
#pragma warning restore 0169

			IntPtr id_onClosed;
			public unsafe void OnClosed ()
			{
				if (id_onClosed == IntPtr.Zero)
					id_onClosed = JNIEnv.GetMethodID (class_ref, "onClosed", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClosed);
			}

			static Delegate cb_onOpened;
#pragma warning disable 0169
			static Delegate GetOnOpenedHandler ()
			{
				if (cb_onOpened == null)
					cb_onOpened = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnOpened);
				return cb_onOpened;
			}

			static void n_OnOpened (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnOpened ();
			}
#pragma warning restore 0169

			IntPtr id_onOpened;
			public unsafe void OnOpened ()
			{
				if (id_onOpened == IntPtr.Zero)
					id_onOpened = JNIEnv.GetMethodID (class_ref, "onOpened", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpened);
			}

		}

		[global::Android.Runtime.Register ("mono/com/github/sundeepk/compactcalendarview/CompactCalendarView_CompactCalendarAnimationListenerImplementor")]
		internal sealed partial class ICompactCalendarAnimationListenerImplementor : global::Java.Lang.Object, ICompactCalendarAnimationListener {

			object sender;

			public ICompactCalendarAnimationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/github/sundeepk/compactcalendarview/CompactCalendarView_CompactCalendarAnimationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnClosedHandler;
#pragma warning restore 0649

			public void OnClosed ()
			{
				var __h = OnClosedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnOpenedHandler;
#pragma warning restore 0649

			public void OnOpened ()
			{
				var __h = OnOpenedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (ICompactCalendarAnimationListenerImplementor value)
			{
				return value.OnClosedHandler == null && value.OnOpenedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/interface[@name='CompactCalendarView.CompactCalendarViewListener']"
		[Register ("com/github/sundeepk/compactcalendarview/CompactCalendarView$CompactCalendarViewListener", "", "Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView/ICompactCalendarViewListenerInvoker")]
		public partial interface ICompactCalendarViewListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/interface[@name='CompactCalendarView.CompactCalendarViewListener']/method[@name='onDayClick' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("onDayClick", "(Ljava/util/Date;)V", "GetOnDayClick_Ljava_util_Date_Handler:Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView/ICompactCalendarViewListenerInvoker, AndroidBindingCompactCalendarView")]
			void OnDayClick (global::Java.Util.Date p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/interface[@name='CompactCalendarView.CompactCalendarViewListener']/method[@name='onMonthScroll' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("onMonthScroll", "(Ljava/util/Date;)V", "GetOnMonthScroll_Ljava_util_Date_Handler:Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView/ICompactCalendarViewListenerInvoker, AndroidBindingCompactCalendarView")]
			void OnMonthScroll (global::Java.Util.Date p0);

		}

		[global::Android.Runtime.Register ("com/github/sundeepk/compactcalendarview/CompactCalendarView$CompactCalendarViewListener", DoNotGenerateAcw=true)]
		internal class ICompactCalendarViewListenerInvoker : global::Java.Lang.Object, ICompactCalendarViewListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/sundeepk/compactcalendarview/CompactCalendarView$CompactCalendarViewListener", typeof (ICompactCalendarViewListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ICompactCalendarViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICompactCalendarViewListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.github.sundeepk.compactcalendarview.CompactCalendarView.CompactCalendarViewListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICompactCalendarViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDayClick_Ljava_util_Date_;
#pragma warning disable 0169
			static Delegate GetOnDayClick_Ljava_util_Date_Handler ()
			{
				if (cb_onDayClick_Ljava_util_Date_ == null)
					cb_onDayClick_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDayClick_Ljava_util_Date_);
				return cb_onDayClick_Ljava_util_Date_;
			}

			static void n_OnDayClick_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDayClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDayClick_Ljava_util_Date_;
			public unsafe void OnDayClick (global::Java.Util.Date p0)
			{
				if (id_onDayClick_Ljava_util_Date_ == IntPtr.Zero)
					id_onDayClick_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "onDayClick", "(Ljava/util/Date;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDayClick_Ljava_util_Date_, __args);
			}

			static Delegate cb_onMonthScroll_Ljava_util_Date_;
#pragma warning disable 0169
			static Delegate GetOnMonthScroll_Ljava_util_Date_Handler ()
			{
				if (cb_onMonthScroll_Ljava_util_Date_ == null)
					cb_onMonthScroll_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMonthScroll_Ljava_util_Date_);
				return cb_onMonthScroll_Ljava_util_Date_;
			}

			static void n_OnMonthScroll_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMonthScroll (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMonthScroll_Ljava_util_Date_;
			public unsafe void OnMonthScroll (global::Java.Util.Date p0)
			{
				if (id_onMonthScroll_Ljava_util_Date_ == IntPtr.Zero)
					id_onMonthScroll_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "onMonthScroll", "(Ljava/util/Date;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMonthScroll_Ljava_util_Date_, __args);
			}

		}

		// event args for com.github.sundeepk.compactcalendarview.CompactCalendarView.CompactCalendarViewListener.onDayClick
		public partial class DayClickEventArgs : global::System.EventArgs {

			public DayClickEventArgs (global::Java.Util.Date p0)
			{
				this.p0 = p0;
			}

			global::Java.Util.Date p0;
			public global::Java.Util.Date P0 {
				get { return p0; }
			}
		}

		// event args for com.github.sundeepk.compactcalendarview.CompactCalendarView.CompactCalendarViewListener.onMonthScroll
		public partial class MonthScrollEventArgs : global::System.EventArgs {

			public MonthScrollEventArgs (global::Java.Util.Date p0)
			{
				this.p0 = p0;
			}

			global::Java.Util.Date p0;
			public global::Java.Util.Date P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/github/sundeepk/compactcalendarview/CompactCalendarView_CompactCalendarViewListenerImplementor")]
		internal sealed partial class ICompactCalendarViewListenerImplementor : global::Java.Lang.Object, ICompactCalendarViewListener {

			object sender;

			public ICompactCalendarViewListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/github/sundeepk/compactcalendarview/CompactCalendarView_CompactCalendarViewListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DayClickEventArgs> OnDayClickHandler;
#pragma warning restore 0649

			public void OnDayClick (global::Java.Util.Date p0)
			{
				var __h = OnDayClickHandler;
				if (__h != null)
					__h (sender, new DayClickEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MonthScrollEventArgs> OnMonthScrollHandler;
#pragma warning restore 0649

			public void OnMonthScroll (global::Java.Util.Date p0)
			{
				var __h = OnMonthScrollHandler;
				if (__h != null)
					__h (sender, new MonthScrollEventArgs (p0));
			}

			internal static bool __IsEmpty (ICompactCalendarViewListenerImplementor value)
			{
				return value.OnDayClickHandler == null && value.OnMonthScrollHandler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/sundeepk/compactcalendarview/CompactCalendarView", typeof (CompactCalendarView));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected CompactCalendarView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/constructor[@name='CompactCalendarView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CompactCalendarView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/constructor[@name='CompactCalendarView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CompactCalendarView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/constructor[@name='CompactCalendarView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CompactCalendarView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getFirstDayOfCurrentMonth;
#pragma warning disable 0169
		static Delegate GetGetFirstDayOfCurrentMonthHandler ()
		{
			if (cb_getFirstDayOfCurrentMonth == null)
				cb_getFirstDayOfCurrentMonth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstDayOfCurrentMonth);
			return cb_getFirstDayOfCurrentMonth;
		}

		static IntPtr n_GetFirstDayOfCurrentMonth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FirstDayOfCurrentMonth);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Date FirstDayOfCurrentMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='getFirstDayOfCurrentMonth' and count(parameter)=0]"
			[Register ("getFirstDayOfCurrentMonth", "()Ljava/util/Date;", "GetGetFirstDayOfCurrentMonthHandler")]
			get {
				const string __id = "getFirstDayOfCurrentMonth.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeightPerDay;
#pragma warning disable 0169
		static Delegate GetGetHeightPerDayHandler ()
		{
			if (cb_getHeightPerDay == null)
				cb_getHeightPerDay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeightPerDay);
			return cb_getHeightPerDay;
		}

		static int n_GetHeightPerDay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeightPerDay;
		}
#pragma warning restore 0169

		public virtual unsafe int HeightPerDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='getHeightPerDay' and count(parameter)=0]"
			[Register ("getHeightPerDay", "()I", "GetGetHeightPerDayHandler")]
			get {
				const string __id = "getHeightPerDay.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAnimating;
#pragma warning disable 0169
		static Delegate GetIsAnimatingHandler ()
		{
			if (cb_isAnimating == null)
				cb_isAnimating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnimating);
			return cb_isAnimating;
		}

		static bool n_IsAnimating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimating;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAnimating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='isAnimating' and count(parameter)=0]"
			[Register ("isAnimating", "()Z", "GetIsAnimatingHandler")]
			get {
				const string __id = "isAnimating.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWeekNumberForCurrentMonth;
#pragma warning disable 0169
		static Delegate GetGetWeekNumberForCurrentMonthHandler ()
		{
			if (cb_getWeekNumberForCurrentMonth == null)
				cb_getWeekNumberForCurrentMonth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWeekNumberForCurrentMonth);
			return cb_getWeekNumberForCurrentMonth;
		}

		static int n_GetWeekNumberForCurrentMonth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WeekNumberForCurrentMonth;
		}
#pragma warning restore 0169

		public virtual unsafe int WeekNumberForCurrentMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='getWeekNumberForCurrentMonth' and count(parameter)=0]"
			[Register ("getWeekNumberForCurrentMonth", "()I", "GetGetWeekNumberForCurrentMonthHandler")]
			get {
				const string __id = "getWeekNumberForCurrentMonth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_;
#pragma warning disable 0169
		static Delegate GetAddEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Handler ()
		{
			if (cb_addEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_ == null)
				cb_addEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_);
			return cb_addEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_;
		}

		static void n_AddEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event e = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddEvent (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='addEvent' and count(parameter)=1 and parameter[1][@type='com.github.sundeepk.compactcalendarview.domain.Event']]"
		[Register ("addEvent", "(Lcom/github/sundeepk/compactcalendarview/domain/Event;)V", "GetAddEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Handler")]
		public virtual unsafe void AddEvent (global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event e)
		{
			const string __id = "addEvent.(Lcom/github/sundeepk/compactcalendarview/domain/Event;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z;
#pragma warning disable 0169
		static Delegate GetAddEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_ZHandler ()
		{
			if (cb_addEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z == null)
				cb_addEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z);
			return cb_addEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z;
		}

		static void n_AddEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_e, bool shouldInvalidate)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event e = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddEvent (e, shouldInvalidate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='addEvent' and count(parameter)=2 and parameter[1][@type='com.github.sundeepk.compactcalendarview.domain.Event'] and parameter[2][@type='boolean']]"
		[Register ("addEvent", "(Lcom/github/sundeepk/compactcalendarview/domain/Event;Z)V", "GetAddEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_ZHandler")]
		public virtual unsafe void AddEvent (global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event e, bool shouldInvalidate)
		{
			const string __id = "addEvent.(Lcom/github/sundeepk/compactcalendarview/domain/Event;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue (shouldInvalidate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addEvents_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddEvents_Ljava_util_List_Handler ()
		{
			if (cb_addEvents_Ljava_util_List_ == null)
				cb_addEvents_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddEvents_Ljava_util_List_);
			return cb_addEvents_Ljava_util_List_;
		}

		static void n_AddEvents_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_events)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var events = global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.FromJniHandle (native_events, JniHandleOwnership.DoNotTransfer);
			__this.AddEvents (events);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='addEvents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.sundeepk.compactcalendarview.domain.Event&gt;']]"
		[Register ("addEvents", "(Ljava/util/List;)V", "GetAddEvents_Ljava_util_List_Handler")]
		public virtual unsafe void AddEvents (global::System.Collections.Generic.IList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> events)
		{
			const string __id = "addEvents.(Ljava/util/List;)V";
			IntPtr native_events = global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.ToLocalJniHandle (events);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_events);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_events);
			}
		}

		static Delegate cb_displayOtherMonthDays_Z;
#pragma warning disable 0169
		static Delegate GetDisplayOtherMonthDays_ZHandler ()
		{
			if (cb_displayOtherMonthDays_Z == null)
				cb_displayOtherMonthDays_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_DisplayOtherMonthDays_Z);
			return cb_displayOtherMonthDays_Z;
		}

		static void n_DisplayOtherMonthDays_Z (IntPtr jnienv, IntPtr native__this, bool displayOtherMonthDays)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayOtherMonthDays (displayOtherMonthDays);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='displayOtherMonthDays' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("displayOtherMonthDays", "(Z)V", "GetDisplayOtherMonthDays_ZHandler")]
		public virtual unsafe void DisplayOtherMonthDays (bool displayOtherMonthDays)
		{
			const string __id = "displayOtherMonthDays.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (displayOtherMonthDays);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getEvents_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetGetEvents_Ljava_util_Date_Handler ()
		{
			if (cb_getEvents_Ljava_util_Date_ == null)
				cb_getEvents_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEvents_Ljava_util_Date_);
			return cb_getEvents_Ljava_util_Date_;
		}

		static IntPtr n_GetEvents_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.ToLocalJniHandle (__this.GetEvents (date));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='getEvents' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("getEvents", "(Ljava/util/Date;)Ljava/util/List;", "GetGetEvents_Ljava_util_Date_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> GetEvents (global::Java.Util.Date date)
		{
			const string __id = "getEvents.(Ljava/util/Date;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEvents_J;
#pragma warning disable 0169
		static Delegate GetGetEvents_JHandler ()
		{
			if (cb_getEvents_J == null)
				cb_getEvents_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetEvents_J);
			return cb_getEvents_J;
		}

		static IntPtr n_GetEvents_J (IntPtr jnienv, IntPtr native__this, long epochMillis)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.ToLocalJniHandle (__this.GetEvents (epochMillis));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='getEvents' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getEvents", "(J)Ljava/util/List;", "GetGetEvents_JHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> GetEvents (long epochMillis)
		{
			const string __id = "getEvents.(J)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (epochMillis);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEventsForMonth_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetGetEventsForMonth_Ljava_util_Date_Handler ()
		{
			if (cb_getEventsForMonth_Ljava_util_Date_ == null)
				cb_getEventsForMonth_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEventsForMonth_Ljava_util_Date_);
			return cb_getEventsForMonth_Ljava_util_Date_;
		}

		static IntPtr n_GetEventsForMonth_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.ToLocalJniHandle (__this.GetEventsForMonth (date));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='getEventsForMonth' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("getEventsForMonth", "(Ljava/util/Date;)Ljava/util/List;", "GetGetEventsForMonth_Ljava_util_Date_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> GetEventsForMonth (global::Java.Util.Date date)
		{
			const string __id = "getEventsForMonth.(Ljava/util/Date;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEventsForMonth_J;
#pragma warning disable 0169
		static Delegate GetGetEventsForMonth_JHandler ()
		{
			if (cb_getEventsForMonth_J == null)
				cb_getEventsForMonth_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetEventsForMonth_J);
			return cb_getEventsForMonth_J;
		}

		static IntPtr n_GetEventsForMonth_J (IntPtr jnienv, IntPtr native__this, long epochMillis)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.ToLocalJniHandle (__this.GetEventsForMonth (epochMillis));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='getEventsForMonth' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getEventsForMonth", "(J)Ljava/util/List;", "GetGetEventsForMonth_JHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> GetEventsForMonth (long epochMillis)
		{
			const string __id = "getEventsForMonth.(J)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (epochMillis);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideCalendar;
#pragma warning disable 0169
		static Delegate GetHideCalendarHandler ()
		{
			if (cb_hideCalendar == null)
				cb_hideCalendar = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideCalendar);
			return cb_hideCalendar;
		}

		static void n_HideCalendar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideCalendar ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='hideCalendar' and count(parameter)=0]"
		[Register ("hideCalendar", "()V", "GetHideCalendarHandler")]
		public virtual unsafe void HideCalendar ()
		{
			const string __id = "hideCalendar.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_hideCalendarWithAnimation;
#pragma warning disable 0169
		static Delegate GetHideCalendarWithAnimationHandler ()
		{
			if (cb_hideCalendarWithAnimation == null)
				cb_hideCalendarWithAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideCalendarWithAnimation);
			return cb_hideCalendarWithAnimation;
		}

		static void n_HideCalendarWithAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideCalendarWithAnimation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='hideCalendarWithAnimation' and count(parameter)=0]"
		[Register ("hideCalendarWithAnimation", "()V", "GetHideCalendarWithAnimationHandler")]
		public virtual unsafe void HideCalendarWithAnimation ()
		{
			const string __id = "hideCalendarWithAnimation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeAllEvents;
#pragma warning disable 0169
		static Delegate GetRemoveAllEventsHandler ()
		{
			if (cb_removeAllEvents == null)
				cb_removeAllEvents = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllEvents);
			return cb_removeAllEvents;
		}

		static void n_RemoveAllEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllEvents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='removeAllEvents' and count(parameter)=0]"
		[Register ("removeAllEvents", "()V", "GetRemoveAllEventsHandler")]
		public virtual unsafe void RemoveAllEvents ()
		{
			const string __id = "removeAllEvents.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_;
#pragma warning disable 0169
		static Delegate GetRemoveEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Handler ()
		{
			if (cb_removeEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_ == null)
				cb_removeEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_);
			return cb_removeEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_;
		}

		static void n_RemoveEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event e = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEvent (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='removeEvent' and count(parameter)=1 and parameter[1][@type='com.github.sundeepk.compactcalendarview.domain.Event']]"
		[Register ("removeEvent", "(Lcom/github/sundeepk/compactcalendarview/domain/Event;)V", "GetRemoveEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Handler")]
		public virtual unsafe void RemoveEvent (global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event e)
		{
			const string __id = "removeEvent.(Lcom/github/sundeepk/compactcalendarview/domain/Event;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z;
#pragma warning disable 0169
		static Delegate GetRemoveEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_ZHandler ()
		{
			if (cb_removeEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z == null)
				cb_removeEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_RemoveEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z);
			return cb_removeEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z;
		}

		static void n_RemoveEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_e, bool shouldInvalidate)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event e = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEvent (e, shouldInvalidate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='removeEvent' and count(parameter)=2 and parameter[1][@type='com.github.sundeepk.compactcalendarview.domain.Event'] and parameter[2][@type='boolean']]"
		[Register ("removeEvent", "(Lcom/github/sundeepk/compactcalendarview/domain/Event;Z)V", "GetRemoveEvent_Lcom_github_sundeepk_compactcalendarview_domain_Event_ZHandler")]
		public virtual unsafe void RemoveEvent (global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event e, bool shouldInvalidate)
		{
			const string __id = "removeEvent.(Lcom/github/sundeepk/compactcalendarview/domain/Event;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue (shouldInvalidate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeEvents_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetRemoveEvents_Ljava_util_Date_Handler ()
		{
			if (cb_removeEvents_Ljava_util_Date_ == null)
				cb_removeEvents_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveEvents_Ljava_util_Date_);
			return cb_removeEvents_Ljava_util_Date_;
		}

		static void n_RemoveEvents_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEvents (date);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='removeEvents' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("removeEvents", "(Ljava/util/Date;)V", "GetRemoveEvents_Ljava_util_Date_Handler")]
		public virtual unsafe void RemoveEvents (global::Java.Util.Date date)
		{
			const string __id = "removeEvents.(Ljava/util/Date;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeEvents_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetRemoveEvents_Ljava_util_List_Handler ()
		{
			if (cb_removeEvents_Ljava_util_List_ == null)
				cb_removeEvents_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveEvents_Ljava_util_List_);
			return cb_removeEvents_Ljava_util_List_;
		}

		static void n_RemoveEvents_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_events)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var events = global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.FromJniHandle (native_events, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEvents (events);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='removeEvents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.sundeepk.compactcalendarview.domain.Event&gt;']]"
		[Register ("removeEvents", "(Ljava/util/List;)V", "GetRemoveEvents_Ljava_util_List_Handler")]
		public virtual unsafe void RemoveEvents (global::System.Collections.Generic.IList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> events)
		{
			const string __id = "removeEvents.(Ljava/util/List;)V";
			IntPtr native_events = global::Android.Runtime.JavaList<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event>.ToLocalJniHandle (events);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_events);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_events);
			}
		}

		static Delegate cb_removeEvents_J;
#pragma warning disable 0169
		static Delegate GetRemoveEvents_JHandler ()
		{
			if (cb_removeEvents_J == null)
				cb_removeEvents_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_RemoveEvents_J);
			return cb_removeEvents_J;
		}

		static void n_RemoveEvents_J (IntPtr jnienv, IntPtr native__this, long epochMillis)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveEvents (epochMillis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='removeEvents' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("removeEvents", "(J)V", "GetRemoveEvents_JHandler")]
		public virtual unsafe void RemoveEvents (long epochMillis)
		{
			const string __id = "removeEvents.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (epochMillis);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_scrollLeft;
#pragma warning disable 0169
		static Delegate GetScrollLeftHandler ()
		{
			if (cb_scrollLeft == null)
				cb_scrollLeft = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ScrollLeft);
			return cb_scrollLeft;
		}

		static void n_ScrollLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollLeft ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='scrollLeft' and count(parameter)=0]"
		[Register ("scrollLeft", "()V", "GetScrollLeftHandler")]
		public virtual unsafe void ScrollLeft ()
		{
			const string __id = "scrollLeft.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_scrollRight;
#pragma warning disable 0169
		static Delegate GetScrollRightHandler ()
		{
			if (cb_scrollRight == null)
				cb_scrollRight = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ScrollRight);
			return cb_scrollRight;
		}

		static void n_ScrollRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollRight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='scrollRight' and count(parameter)=0]"
		[Register ("scrollRight", "()V", "GetScrollRightHandler")]
		public virtual unsafe void ScrollRight ()
		{
			const string __id = "scrollRight.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setAnimationListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarAnimationListener_;
#pragma warning disable 0169
		static Delegate GetSetAnimationListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarAnimationListener_Handler ()
		{
			if (cb_setAnimationListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarAnimationListener_ == null)
				cb_setAnimationListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarAnimationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnimationListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarAnimationListener_);
			return cb_setAnimationListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarAnimationListener_;
		}

		static void n_SetAnimationListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarAnimationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_compactCalendarAnimationListener)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener compactCalendarAnimationListener = (global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener)global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener> (native_compactCalendarAnimationListener, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationListener (compactCalendarAnimationListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setAnimationListener' and count(parameter)=1 and parameter[1][@type='com.github.sundeepk.compactcalendarview.CompactCalendarView.CompactCalendarAnimationListener']]"
		[Register ("setAnimationListener", "(Lcom/github/sundeepk/compactcalendarview/CompactCalendarView$CompactCalendarAnimationListener;)V", "GetSetAnimationListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarAnimationListener_Handler")]
		public virtual unsafe void SetAnimationListener (global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener compactCalendarAnimationListener)
		{
			const string __id = "setAnimationListener.(Lcom/github/sundeepk/compactcalendarview/CompactCalendarView$CompactCalendarAnimationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((compactCalendarAnimationListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compactCalendarAnimationListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCalendarBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetCalendarBackgroundColor_IHandler ()
		{
			if (cb_setCalendarBackgroundColor_I == null)
				cb_setCalendarBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCalendarBackgroundColor_I);
			return cb_setCalendarBackgroundColor_I;
		}

		static void n_SetCalendarBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int calenderBackgroundColor)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCalendarBackgroundColor (calenderBackgroundColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setCalendarBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCalendarBackgroundColor", "(I)V", "GetSetCalendarBackgroundColor_IHandler")]
		public virtual unsafe void SetCalendarBackgroundColor (int calenderBackgroundColor)
		{
			const string __id = "setCalendarBackgroundColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (calenderBackgroundColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCurrentDate_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetCurrentDate_Ljava_util_Date_Handler ()
		{
			if (cb_setCurrentDate_Ljava_util_Date_ == null)
				cb_setCurrentDate_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrentDate_Ljava_util_Date_);
			return cb_setCurrentDate_Ljava_util_Date_;
		}

		static void n_SetCurrentDate_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dateTimeMonth)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date dateTimeMonth = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_dateTimeMonth, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentDate (dateTimeMonth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setCurrentDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("setCurrentDate", "(Ljava/util/Date;)V", "GetSetCurrentDate_Ljava_util_Date_Handler")]
		public virtual unsafe void SetCurrentDate (global::Java.Util.Date dateTimeMonth)
		{
			const string __id = "setCurrentDate.(Ljava/util/Date;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dateTimeMonth == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dateTimeMonth).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCurrentDayBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentDayBackgroundColor_IHandler ()
		{
			if (cb_setCurrentDayBackgroundColor_I == null)
				cb_setCurrentDayBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentDayBackgroundColor_I);
			return cb_setCurrentDayBackgroundColor_I;
		}

		static void n_SetCurrentDayBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int currentDayBackgroundColor)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentDayBackgroundColor (currentDayBackgroundColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setCurrentDayBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentDayBackgroundColor", "(I)V", "GetSetCurrentDayBackgroundColor_IHandler")]
		public virtual unsafe void SetCurrentDayBackgroundColor (int currentDayBackgroundColor)
		{
			const string __id = "setCurrentDayBackgroundColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (currentDayBackgroundColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCurrentDayIndicatorStyle_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentDayIndicatorStyle_IHandler ()
		{
			if (cb_setCurrentDayIndicatorStyle_I == null)
				cb_setCurrentDayIndicatorStyle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentDayIndicatorStyle_I);
			return cb_setCurrentDayIndicatorStyle_I;
		}

		static void n_SetCurrentDayIndicatorStyle_I (IntPtr jnienv, IntPtr native__this, int currentDayIndicatorStyle)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentDayIndicatorStyle (currentDayIndicatorStyle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setCurrentDayIndicatorStyle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentDayIndicatorStyle", "(I)V", "GetSetCurrentDayIndicatorStyle_IHandler")]
		public virtual unsafe void SetCurrentDayIndicatorStyle (int currentDayIndicatorStyle)
		{
			const string __id = "setCurrentDayIndicatorStyle.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (currentDayIndicatorStyle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCurrentDayTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentDayTextColor_IHandler ()
		{
			if (cb_setCurrentDayTextColor_I == null)
				cb_setCurrentDayTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentDayTextColor_I);
			return cb_setCurrentDayTextColor_I;
		}

		static void n_SetCurrentDayTextColor_I (IntPtr jnienv, IntPtr native__this, int currentDayTextColor)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentDayTextColor (currentDayTextColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setCurrentDayTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentDayTextColor", "(I)V", "GetSetCurrentDayTextColor_IHandler")]
		public virtual unsafe void SetCurrentDayTextColor (int currentDayTextColor)
		{
			const string __id = "setCurrentDayTextColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (currentDayTextColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCurrentSelectedDayBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentSelectedDayBackgroundColor_IHandler ()
		{
			if (cb_setCurrentSelectedDayBackgroundColor_I == null)
				cb_setCurrentSelectedDayBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentSelectedDayBackgroundColor_I);
			return cb_setCurrentSelectedDayBackgroundColor_I;
		}

		static void n_SetCurrentSelectedDayBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int currentSelectedDayBackgroundColor)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentSelectedDayBackgroundColor (currentSelectedDayBackgroundColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setCurrentSelectedDayBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentSelectedDayBackgroundColor", "(I)V", "GetSetCurrentSelectedDayBackgroundColor_IHandler")]
		public virtual unsafe void SetCurrentSelectedDayBackgroundColor (int currentSelectedDayBackgroundColor)
		{
			const string __id = "setCurrentSelectedDayBackgroundColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (currentSelectedDayBackgroundColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCurrentSelectedDayIndicatorStyle_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentSelectedDayIndicatorStyle_IHandler ()
		{
			if (cb_setCurrentSelectedDayIndicatorStyle_I == null)
				cb_setCurrentSelectedDayIndicatorStyle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentSelectedDayIndicatorStyle_I);
			return cb_setCurrentSelectedDayIndicatorStyle_I;
		}

		static void n_SetCurrentSelectedDayIndicatorStyle_I (IntPtr jnienv, IntPtr native__this, int currentSelectedDayIndicatorStyle)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentSelectedDayIndicatorStyle (currentSelectedDayIndicatorStyle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setCurrentSelectedDayIndicatorStyle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentSelectedDayIndicatorStyle", "(I)V", "GetSetCurrentSelectedDayIndicatorStyle_IHandler")]
		public virtual unsafe void SetCurrentSelectedDayIndicatorStyle (int currentSelectedDayIndicatorStyle)
		{
			const string __id = "setCurrentSelectedDayIndicatorStyle.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (currentSelectedDayIndicatorStyle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCurrentSelectedDayTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentSelectedDayTextColor_IHandler ()
		{
			if (cb_setCurrentSelectedDayTextColor_I == null)
				cb_setCurrentSelectedDayTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentSelectedDayTextColor_I);
			return cb_setCurrentSelectedDayTextColor_I;
		}

		static void n_SetCurrentSelectedDayTextColor_I (IntPtr jnienv, IntPtr native__this, int currentSelectedDayTextColor)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentSelectedDayTextColor (currentSelectedDayTextColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setCurrentSelectedDayTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCurrentSelectedDayTextColor", "(I)V", "GetSetCurrentSelectedDayTextColor_IHandler")]
		public virtual unsafe void SetCurrentSelectedDayTextColor (int currentSelectedDayTextColor)
		{
			const string __id = "setCurrentSelectedDayTextColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (currentSelectedDayTextColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDayColumnNames_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDayColumnNames_arrayLjava_lang_String_Handler ()
		{
			if (cb_setDayColumnNames_arrayLjava_lang_String_ == null)
				cb_setDayColumnNames_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDayColumnNames_arrayLjava_lang_String_);
			return cb_setDayColumnNames_arrayLjava_lang_String_;
		}

		static void n_SetDayColumnNames_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dayColumnNames)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] dayColumnNames = (string[]) JNIEnv.GetArray (native_dayColumnNames, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetDayColumnNames (dayColumnNames);
			if (dayColumnNames != null)
				JNIEnv.CopyArray (dayColumnNames, native_dayColumnNames);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setDayColumnNames' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setDayColumnNames", "([Ljava/lang/String;)V", "GetSetDayColumnNames_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetDayColumnNames (string[] dayColumnNames)
		{
			const string __id = "setDayColumnNames.([Ljava/lang/String;)V";
			IntPtr native_dayColumnNames = JNIEnv.NewArray (dayColumnNames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dayColumnNames);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (dayColumnNames != null) {
					JNIEnv.CopyArray (native_dayColumnNames, dayColumnNames);
					JNIEnv.DeleteLocalRef (native_dayColumnNames);
				}
			}
		}

		static Delegate cb_setEventIndicatorStyle_I;
#pragma warning disable 0169
		static Delegate GetSetEventIndicatorStyle_IHandler ()
		{
			if (cb_setEventIndicatorStyle_I == null)
				cb_setEventIndicatorStyle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetEventIndicatorStyle_I);
			return cb_setEventIndicatorStyle_I;
		}

		static void n_SetEventIndicatorStyle_I (IntPtr jnienv, IntPtr native__this, int eventIndicatorStyle)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEventIndicatorStyle (eventIndicatorStyle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setEventIndicatorStyle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setEventIndicatorStyle", "(I)V", "GetSetEventIndicatorStyle_IHandler")]
		public virtual unsafe void SetEventIndicatorStyle (int eventIndicatorStyle)
		{
			const string __id = "setEventIndicatorStyle.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (eventIndicatorStyle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFirstDayOfWeek_I;
#pragma warning disable 0169
		static Delegate GetSetFirstDayOfWeek_IHandler ()
		{
			if (cb_setFirstDayOfWeek_I == null)
				cb_setFirstDayOfWeek_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFirstDayOfWeek_I);
			return cb_setFirstDayOfWeek_I;
		}

		static void n_SetFirstDayOfWeek_I (IntPtr jnienv, IntPtr native__this, int dayOfWeek)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFirstDayOfWeek (dayOfWeek);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setFirstDayOfWeek' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFirstDayOfWeek", "(I)V", "GetSetFirstDayOfWeek_IHandler")]
		public virtual unsafe void SetFirstDayOfWeek (int dayOfWeek)
		{
			const string __id = "setFirstDayOfWeek.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dayOfWeek);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIsRtl_Z;
#pragma warning disable 0169
		static Delegate GetSetIsRtl_ZHandler ()
		{
			if (cb_setIsRtl_Z == null)
				cb_setIsRtl_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsRtl_Z);
			return cb_setIsRtl_Z;
		}

		static void n_SetIsRtl_Z (IntPtr jnienv, IntPtr native__this, bool isRtl)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIsRtl (isRtl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setIsRtl' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsRtl", "(Z)V", "GetSetIsRtl_ZHandler")]
		public virtual unsafe void SetIsRtl (bool isRtl)
		{
			const string __id = "setIsRtl.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isRtl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarViewListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarViewListener_Handler ()
		{
			if (cb_setListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarViewListener_ == null)
				cb_setListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarViewListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarViewListener_);
			return cb_setListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarViewListener_;
		}

		static void n_SetListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarViewListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarViewListener listener = (global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarViewListener)global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarViewListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.github.sundeepk.compactcalendarview.CompactCalendarView.CompactCalendarViewListener']]"
		[Register ("setListener", "(Lcom/github/sundeepk/compactcalendarview/CompactCalendarView$CompactCalendarViewListener;)V", "GetSetListener_Lcom_github_sundeepk_compactcalendarview_CompactCalendarView_CompactCalendarViewListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarViewListener listener)
		{
			const string __id = "setListener.(Lcom/github/sundeepk/compactcalendarview/CompactCalendarView$CompactCalendarViewListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLocale_Ljava_util_TimeZone_Ljava_util_Locale_;
#pragma warning disable 0169
		static Delegate GetSetLocale_Ljava_util_TimeZone_Ljava_util_Locale_Handler ()
		{
			if (cb_setLocale_Ljava_util_TimeZone_Ljava_util_Locale_ == null)
				cb_setLocale_Ljava_util_TimeZone_Ljava_util_Locale_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocale_Ljava_util_TimeZone_Ljava_util_Locale_);
			return cb_setLocale_Ljava_util_TimeZone_Ljava_util_Locale_;
		}

		static void n_SetLocale_Ljava_util_TimeZone_Ljava_util_Locale_ (IntPtr jnienv, IntPtr native__this, IntPtr native_timeZone, IntPtr native_locale)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.TimeZone timeZone = global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (native_timeZone, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Locale locale = global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (native_locale, JniHandleOwnership.DoNotTransfer);
			__this.SetLocale (timeZone, locale);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setLocale' and count(parameter)=2 and parameter[1][@type='java.util.TimeZone'] and parameter[2][@type='java.util.Locale']]"
		[Register ("setLocale", "(Ljava/util/TimeZone;Ljava/util/Locale;)V", "GetSetLocale_Ljava_util_TimeZone_Ljava_util_Locale_Handler")]
		public virtual unsafe void SetLocale (global::Java.Util.TimeZone timeZone, global::Java.Util.Locale locale)
		{
			const string __id = "setLocale.(Ljava/util/TimeZone;Ljava/util/Locale;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((timeZone == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeZone).Handle);
				__args [1] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShouldDrawDaysHeader_Z;
#pragma warning disable 0169
		static Delegate GetSetShouldDrawDaysHeader_ZHandler ()
		{
			if (cb_setShouldDrawDaysHeader_Z == null)
				cb_setShouldDrawDaysHeader_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShouldDrawDaysHeader_Z);
			return cb_setShouldDrawDaysHeader_Z;
		}

		static void n_SetShouldDrawDaysHeader_Z (IntPtr jnienv, IntPtr native__this, bool shouldDrawDaysHeader)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShouldDrawDaysHeader (shouldDrawDaysHeader);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setShouldDrawDaysHeader' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShouldDrawDaysHeader", "(Z)V", "GetSetShouldDrawDaysHeader_ZHandler")]
		public virtual unsafe void SetShouldDrawDaysHeader (bool shouldDrawDaysHeader)
		{
			const string __id = "setShouldDrawDaysHeader.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shouldDrawDaysHeader);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTargetHeight_I;
#pragma warning disable 0169
		static Delegate GetSetTargetHeight_IHandler ()
		{
			if (cb_setTargetHeight_I == null)
				cb_setTargetHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTargetHeight_I);
			return cb_setTargetHeight_I;
		}

		static void n_SetTargetHeight_I (IntPtr jnienv, IntPtr native__this, int targetHeight)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTargetHeight (targetHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setTargetHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTargetHeight", "(I)V", "GetSetTargetHeight_IHandler")]
		public virtual unsafe void SetTargetHeight (int targetHeight)
		{
			const string __id = "setTargetHeight.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (targetHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUseThreeLetterAbbreviation_Z;
#pragma warning disable 0169
		static Delegate GetSetUseThreeLetterAbbreviation_ZHandler ()
		{
			if (cb_setUseThreeLetterAbbreviation_Z == null)
				cb_setUseThreeLetterAbbreviation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseThreeLetterAbbreviation_Z);
			return cb_setUseThreeLetterAbbreviation_Z;
		}

		static void n_SetUseThreeLetterAbbreviation_Z (IntPtr jnienv, IntPtr native__this, bool useThreeLetterAbbreviation)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseThreeLetterAbbreviation (useThreeLetterAbbreviation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='setUseThreeLetterAbbreviation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseThreeLetterAbbreviation", "(Z)V", "GetSetUseThreeLetterAbbreviation_ZHandler")]
		public virtual unsafe void SetUseThreeLetterAbbreviation (bool useThreeLetterAbbreviation)
		{
			const string __id = "setUseThreeLetterAbbreviation.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (useThreeLetterAbbreviation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_shouldDrawIndicatorsBelowSelectedDays_Z;
#pragma warning disable 0169
		static Delegate GetShouldDrawIndicatorsBelowSelectedDays_ZHandler ()
		{
			if (cb_shouldDrawIndicatorsBelowSelectedDays_Z == null)
				cb_shouldDrawIndicatorsBelowSelectedDays_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShouldDrawIndicatorsBelowSelectedDays_Z);
			return cb_shouldDrawIndicatorsBelowSelectedDays_Z;
		}

		static void n_ShouldDrawIndicatorsBelowSelectedDays_Z (IntPtr jnienv, IntPtr native__this, bool shouldDrawIndicatorsBelowSelectedDays)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShouldDrawIndicatorsBelowSelectedDays (shouldDrawIndicatorsBelowSelectedDays);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='shouldDrawIndicatorsBelowSelectedDays' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("shouldDrawIndicatorsBelowSelectedDays", "(Z)V", "GetShouldDrawIndicatorsBelowSelectedDays_ZHandler")]
		public virtual unsafe void ShouldDrawIndicatorsBelowSelectedDays (bool shouldDrawIndicatorsBelowSelectedDays)
		{
			const string __id = "shouldDrawIndicatorsBelowSelectedDays.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shouldDrawIndicatorsBelowSelectedDays);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_shouldScrollMonth_Z;
#pragma warning disable 0169
		static Delegate GetShouldScrollMonth_ZHandler ()
		{
			if (cb_shouldScrollMonth_Z == null)
				cb_shouldScrollMonth_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShouldScrollMonth_Z);
			return cb_shouldScrollMonth_Z;
		}

		static void n_ShouldScrollMonth_Z (IntPtr jnienv, IntPtr native__this, bool enableHorizontalScroll)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShouldScrollMonth (enableHorizontalScroll);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='shouldScrollMonth' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("shouldScrollMonth", "(Z)V", "GetShouldScrollMonth_ZHandler")]
		public virtual unsafe void ShouldScrollMonth (bool enableHorizontalScroll)
		{
			const string __id = "shouldScrollMonth.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enableHorizontalScroll);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_shouldSelectFirstDayOfMonthOnScroll_Z;
#pragma warning disable 0169
		static Delegate GetShouldSelectFirstDayOfMonthOnScroll_ZHandler ()
		{
			if (cb_shouldSelectFirstDayOfMonthOnScroll_Z == null)
				cb_shouldSelectFirstDayOfMonthOnScroll_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShouldSelectFirstDayOfMonthOnScroll_Z);
			return cb_shouldSelectFirstDayOfMonthOnScroll_Z;
		}

		static void n_ShouldSelectFirstDayOfMonthOnScroll_Z (IntPtr jnienv, IntPtr native__this, bool shouldSelectFirstDayOfMonthOnScroll)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShouldSelectFirstDayOfMonthOnScroll (shouldSelectFirstDayOfMonthOnScroll);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='shouldSelectFirstDayOfMonthOnScroll' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("shouldSelectFirstDayOfMonthOnScroll", "(Z)V", "GetShouldSelectFirstDayOfMonthOnScroll_ZHandler")]
		public virtual unsafe void ShouldSelectFirstDayOfMonthOnScroll (bool shouldSelectFirstDayOfMonthOnScroll)
		{
			const string __id = "shouldSelectFirstDayOfMonthOnScroll.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shouldSelectFirstDayOfMonthOnScroll);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showCalendar;
#pragma warning disable 0169
		static Delegate GetShowCalendarHandler ()
		{
			if (cb_showCalendar == null)
				cb_showCalendar = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowCalendar);
			return cb_showCalendar;
		}

		static void n_ShowCalendar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowCalendar ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='showCalendar' and count(parameter)=0]"
		[Register ("showCalendar", "()V", "GetShowCalendarHandler")]
		public virtual unsafe void ShowCalendar ()
		{
			const string __id = "showCalendar.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_showCalendarWithAnimation;
#pragma warning disable 0169
		static Delegate GetShowCalendarWithAnimationHandler ()
		{
			if (cb_showCalendarWithAnimation == null)
				cb_showCalendarWithAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowCalendarWithAnimation);
			return cb_showCalendarWithAnimation;
		}

		static void n_ShowCalendarWithAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowCalendarWithAnimation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='CompactCalendarView']/method[@name='showCalendarWithAnimation' and count(parameter)=0]"
		[Register ("showCalendarWithAnimation", "()V", "GetShowCalendarWithAnimationHandler")]
		public virtual unsafe void ShowCalendarWithAnimation ()
		{
			const string __id = "showCalendarWithAnimation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener"
		public event EventHandler Closed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener, global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						__CreateICompactCalendarAnimationListenerImplementor,
						SetAnimationListener,
						__h => __h.OnClosedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener, global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListenerImplementor.__IsEmpty,
						__v => SetAnimationListener (null),
						__h => __h.OnClosedHandler -= value);
			}
		}

		public event EventHandler Opened {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener, global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						__CreateICompactCalendarAnimationListenerImplementor,
						SetAnimationListener,
						__h => __h.OnOpenedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListener, global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListenerImplementor.__IsEmpty,
						__v => SetAnimationListener (null),
						__h => __h.OnOpenedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetAnimationListener;

		global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListenerImplementor __CreateICompactCalendarAnimationListenerImplementor ()
		{
			return new global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarAnimationListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarViewListener"

		global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarViewListenerImplementor __CreateICompactCalendarViewListenerImplementor ()
		{
			return new global::Com.Github.Sundeepk.Compactcalendarview.CompactCalendarView.ICompactCalendarViewListenerImplementor (this);
		}
#endregion
	}
}
