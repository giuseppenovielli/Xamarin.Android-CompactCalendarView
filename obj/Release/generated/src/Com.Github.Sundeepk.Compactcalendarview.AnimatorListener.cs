using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Sundeepk.Compactcalendarview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='AnimatorListener']"
	[global::Android.Runtime.Register ("com/github/sundeepk/compactcalendarview/AnimatorListener", DoNotGenerateAcw=true)]
	public abstract partial class AnimatorListener : global::Java.Lang.Object, global::Android.Animation.Animator.IAnimatorListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/sundeepk/compactcalendarview/AnimatorListener", typeof (AnimatorListener));
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

		protected AnimatorListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='AnimatorListener']/constructor[@name='AnimatorListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimatorListener ()
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

		static Delegate cb_onAnimationCancel_Landroid_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationCancel_Landroid_animation_Animator_Handler ()
		{
			if (cb_onAnimationCancel_Landroid_animation_Animator_ == null)
				cb_onAnimationCancel_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationCancel_Landroid_animation_Animator_);
			return cb_onAnimationCancel_Landroid_animation_Animator_;
		}

		static void n_OnAnimationCancel_Landroid_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.AnimatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.AnimatorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Animation.Animator animation = global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationCancel (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='AnimatorListener']/method[@name='onAnimationCancel' and count(parameter)=1 and parameter[1][@type='android.animation.Animator']]"
		[Register ("onAnimationCancel", "(Landroid/animation/Animator;)V", "GetOnAnimationCancel_Landroid_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationCancel (global::Android.Animation.Animator animation)
		{
			const string __id = "onAnimationCancel.(Landroid/animation/Animator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationEnd_Landroid_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationEnd_Landroid_animation_Animator_Handler ()
		{
			if (cb_onAnimationEnd_Landroid_animation_Animator_ == null)
				cb_onAnimationEnd_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationEnd_Landroid_animation_Animator_);
			return cb_onAnimationEnd_Landroid_animation_Animator_;
		}

		static void n_OnAnimationEnd_Landroid_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.AnimatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.AnimatorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Animation.Animator animation = global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationEnd (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='AnimatorListener']/method[@name='onAnimationEnd' and count(parameter)=1 and parameter[1][@type='android.animation.Animator']]"
		[Register ("onAnimationEnd", "(Landroid/animation/Animator;)V", "GetOnAnimationEnd_Landroid_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationEnd (global::Android.Animation.Animator animation)
		{
			const string __id = "onAnimationEnd.(Landroid/animation/Animator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationRepeat_Landroid_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationRepeat_Landroid_animation_Animator_Handler ()
		{
			if (cb_onAnimationRepeat_Landroid_animation_Animator_ == null)
				cb_onAnimationRepeat_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationRepeat_Landroid_animation_Animator_);
			return cb_onAnimationRepeat_Landroid_animation_Animator_;
		}

		static void n_OnAnimationRepeat_Landroid_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.AnimatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.AnimatorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Animation.Animator animation = global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationRepeat (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='AnimatorListener']/method[@name='onAnimationRepeat' and count(parameter)=1 and parameter[1][@type='android.animation.Animator']]"
		[Register ("onAnimationRepeat", "(Landroid/animation/Animator;)V", "GetOnAnimationRepeat_Landroid_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationRepeat (global::Android.Animation.Animator animation)
		{
			const string __id = "onAnimationRepeat.(Landroid/animation/Animator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationStart_Landroid_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationStart_Landroid_animation_Animator_Handler ()
		{
			if (cb_onAnimationStart_Landroid_animation_Animator_ == null)
				cb_onAnimationStart_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationStart_Landroid_animation_Animator_);
			return cb_onAnimationStart_Landroid_animation_Animator_;
		}

		static void n_OnAnimationStart_Landroid_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.AnimatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.AnimatorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Animation.Animator animation = global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationStart (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='AnimatorListener']/method[@name='onAnimationStart' and count(parameter)=1 and parameter[1][@type='android.animation.Animator']]"
		[Register ("onAnimationStart", "(Landroid/animation/Animator;)V", "GetOnAnimationStart_Landroid_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationStart (global::Android.Animation.Animator animation)
		{
			const string __id = "onAnimationStart.(Landroid/animation/Animator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/sundeepk/compactcalendarview/AnimatorListener", DoNotGenerateAcw=true)]
	internal partial class AnimatorListenerInvoker : AnimatorListener {

		public AnimatorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/sundeepk/compactcalendarview/AnimatorListener", typeof (AnimatorListenerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
