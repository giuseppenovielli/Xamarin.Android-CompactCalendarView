using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Sundeepk.Compactcalendarview.Comparators {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview.comparators']/class[@name='EventComparator']"
	[global::Android.Runtime.Register ("com/github/sundeepk/compactcalendarview/comparators/EventComparator", DoNotGenerateAcw=true)]
	public partial class EventComparator : global::Java.Lang.Object, global::Java.Util.IComparator {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/sundeepk/compactcalendarview/comparators/EventComparator", typeof (EventComparator));
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

		protected EventComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview.comparators']/class[@name='EventComparator']/constructor[@name='EventComparator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventComparator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_compare_Lcom_github_sundeepk_compactcalendarview_domain_Event_Lcom_github_sundeepk_compactcalendarview_domain_Event_;
#pragma warning disable 0169
		static Delegate GetCompare_Lcom_github_sundeepk_compactcalendarview_domain_Event_Lcom_github_sundeepk_compactcalendarview_domain_Event_Handler ()
		{
			if (cb_compare_Lcom_github_sundeepk_compactcalendarview_domain_Event_Lcom_github_sundeepk_compactcalendarview_domain_Event_ == null)
				cb_compare_Lcom_github_sundeepk_compactcalendarview_domain_Event_Lcom_github_sundeepk_compactcalendarview_domain_Event_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Lcom_github_sundeepk_compactcalendarview_domain_Event_Lcom_github_sundeepk_compactcalendarview_domain_Event_);
			return cb_compare_Lcom_github_sundeepk_compactcalendarview_domain_Event_Lcom_github_sundeepk_compactcalendarview_domain_Event_;
		}

		static int n_Compare_Lcom_github_sundeepk_compactcalendarview_domain_Event_Lcom_github_sundeepk_compactcalendarview_domain_Event_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lhs, IntPtr native_rhs)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.Comparators.EventComparator __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.Comparators.EventComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event lhs = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> (native_lhs, JniHandleOwnership.DoNotTransfer);
			global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event rhs = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event> (native_rhs, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Compare (lhs, rhs);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview.comparators']/class[@name='EventComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='com.github.sundeepk.compactcalendarview.domain.Event'] and parameter[2][@type='com.github.sundeepk.compactcalendarview.domain.Event']]"
		[Register ("compare", "(Lcom/github/sundeepk/compactcalendarview/domain/Event;Lcom/github/sundeepk/compactcalendarview/domain/Event;)I", "GetCompare_Lcom_github_sundeepk_compactcalendarview_domain_Event_Lcom_github_sundeepk_compactcalendarview_domain_Event_Handler")]
		public virtual unsafe int Compare (global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event lhs, global::Com.Github.Sundeepk.Compactcalendarview.Domain.Event rhs)
		{
			const string __id = "compare.(Lcom/github/sundeepk/compactcalendarview/domain/Event;Lcom/github/sundeepk/compactcalendarview/domain/Event;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((lhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lhs).Handle);
				__args [1] = new JniArgumentValue ((rhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rhs).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_compare_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static int n_Compare_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o1, IntPtr native_o2)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.Comparators.EventComparator __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.Comparators.EventComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object o1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object o2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Compare (o1, o2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview.comparators']/class[@name='EventComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe int Compare (global::Java.Lang.Object o1, global::Java.Lang.Object o2)
		{
			const string __id = "compare.(Ljava/lang/Object;Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((o1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o1).Handle);
				__args [1] = new JniArgumentValue ((o2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
