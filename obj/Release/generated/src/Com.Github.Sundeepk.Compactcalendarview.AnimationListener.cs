using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Github.Sundeepk.Compactcalendarview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='AnimationListener']"
	[global::Android.Runtime.Register ("com/github/sundeepk/compactcalendarview/AnimationListener", DoNotGenerateAcw=true)]
	public abstract partial class AnimationListener : global::Java.Lang.Object, global::Android.Views.Animations.Animation.IAnimationListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/sundeepk/compactcalendarview/AnimationListener", typeof (AnimationListener));
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

		protected AnimationListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='AnimationListener']/constructor[@name='AnimationListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimationListener ()
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

		static Delegate cb_onAnimationEnd_Landroid_view_animation_Animation_;
#pragma warning disable 0169
		static Delegate GetOnAnimationEnd_Landroid_view_animation_Animation_Handler ()
		{
			if (cb_onAnimationEnd_Landroid_view_animation_Animation_ == null)
				cb_onAnimationEnd_Landroid_view_animation_Animation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationEnd_Landroid_view_animation_Animation_);
			return cb_onAnimationEnd_Landroid_view_animation_Animation_;
		}

		static void n_OnAnimationEnd_Landroid_view_animation_Animation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.AnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.AnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.Animation animation = global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationEnd (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='AnimationListener']/method[@name='onAnimationEnd' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
		[Register ("onAnimationEnd", "(Landroid/view/animation/Animation;)V", "GetOnAnimationEnd_Landroid_view_animation_Animation_Handler")]
		public virtual unsafe void OnAnimationEnd (global::Android.Views.Animations.Animation animation)
		{
			const string __id = "onAnimationEnd.(Landroid/view/animation/Animation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationRepeat_Landroid_view_animation_Animation_;
#pragma warning disable 0169
		static Delegate GetOnAnimationRepeat_Landroid_view_animation_Animation_Handler ()
		{
			if (cb_onAnimationRepeat_Landroid_view_animation_Animation_ == null)
				cb_onAnimationRepeat_Landroid_view_animation_Animation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationRepeat_Landroid_view_animation_Animation_);
			return cb_onAnimationRepeat_Landroid_view_animation_Animation_;
		}

		static void n_OnAnimationRepeat_Landroid_view_animation_Animation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.AnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.AnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.Animation animation = global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationRepeat (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='AnimationListener']/method[@name='onAnimationRepeat' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
		[Register ("onAnimationRepeat", "(Landroid/view/animation/Animation;)V", "GetOnAnimationRepeat_Landroid_view_animation_Animation_Handler")]
		public virtual unsafe void OnAnimationRepeat (global::Android.Views.Animations.Animation animation)
		{
			const string __id = "onAnimationRepeat.(Landroid/view/animation/Animation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationStart_Landroid_view_animation_Animation_;
#pragma warning disable 0169
		static Delegate GetOnAnimationStart_Landroid_view_animation_Animation_Handler ()
		{
			if (cb_onAnimationStart_Landroid_view_animation_Animation_ == null)
				cb_onAnimationStart_Landroid_view_animation_Animation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationStart_Landroid_view_animation_Animation_);
			return cb_onAnimationStart_Landroid_view_animation_Animation_;
		}

		static void n_OnAnimationStart_Landroid_view_animation_Animation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::Com.Github.Sundeepk.Compactcalendarview.AnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Github.Sundeepk.Compactcalendarview.AnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.Animation animation = global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationStart (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.sundeepk.compactcalendarview']/class[@name='AnimationListener']/method[@name='onAnimationStart' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
		[Register ("onAnimationStart", "(Landroid/view/animation/Animation;)V", "GetOnAnimationStart_Landroid_view_animation_Animation_Handler")]
		public virtual unsafe void OnAnimationStart (global::Android.Views.Animations.Animation animation)
		{
			const string __id = "onAnimationStart.(Landroid/view/animation/Animation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/sundeepk/compactcalendarview/AnimationListener", DoNotGenerateAcw=true)]
	internal partial class AnimationListenerInvoker : AnimationListener {

		public AnimationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/sundeepk/compactcalendarview/AnimationListener", typeof (AnimationListenerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
