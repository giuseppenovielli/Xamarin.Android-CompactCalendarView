using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Sundeepk.Compactcalendarview.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview.domain']/class[@name='Event']"
	[global::Android.Runtime.Register ("com/github/sundeepk/compactcalendarview/domain/Event", DoNotGenerateAcw=true)]
	public partial class Event : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/sundeepk/compactcalendarview/domain/Event", typeof (Event));
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

		protected Event (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview.domain']/class[@name='Event']/constructor[@name='Event' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register (".ctor", "(IJ)V", "")]
		public unsafe Event (int color, long timeInMillis)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (timeInMillis);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview.domain']/class[@name='Event']/constructor[@name='Event' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.Object']]"
		[Register (".ctor", "(IJLjava/lang/Object;)V", "")]
		public unsafe Event (int color, long timeInMillis, global::Java.Lang.Object data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IJLjava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (timeInMillis);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		public virtual unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview.domain']/class[@name='Event']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				const string __id = "getColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview.domain']/class[@name='Event']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/Object;", "GetGetDataHandler")]
			get {
				const string __id = "getData.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeInMillis;
#pragma warning disable 0169
		static Delegate GetGetTimeInMillisHandler ()
		{
			if (cb_getTimeInMillis == null)
				cb_getTimeInMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeInMillis);
			return cb_getTimeInMillis;
		}

		static long n_GetTimeInMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeInMillis;
		}
#pragma warning restore 0169

		public virtual unsafe long TimeInMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview.domain']/class[@name='Event']/method[@name='getTimeInMillis' and count(parameter)=0]"
			[Register ("getTimeInMillis", "()J", "GetGetTimeInMillisHandler")]
			get {
				const string __id = "getTimeInMillis.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
