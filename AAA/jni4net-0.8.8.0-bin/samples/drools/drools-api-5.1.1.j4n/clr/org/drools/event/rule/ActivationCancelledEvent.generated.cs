//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.@event.rule {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface ActivationCancelledEvent : global::org.drools.@event.rule.ActivationEvent {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/event/rule/ActivationCancelledCause;")]
        global::org.drools.@event.rule.ActivationCancelledCause getCause();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class ActivationCancelledEvent_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.@event.rule.@__ActivationCancelledEvent.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.@event.rule.ActivationCancelledEvent), typeof(global::org.drools.@event.rule.ActivationCancelledEvent_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.@event.rule.ActivationCancelledEvent), typeof(global::org.drools.@event.rule.ActivationCancelledEvent_))]
    internal sealed partial class @__ActivationCancelledEvent : global::java.lang.Object, global::org.drools.@event.rule.ActivationCancelledEvent {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getKnowledgeRuntime0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getActivation1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCause2;
        
        private @__ActivationCancelledEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.@event.rule.@__ActivationCancelledEvent.staticClass = @__class;
            global::org.drools.@event.rule.@__ActivationCancelledEvent._getKnowledgeRuntime0 = @__env.GetMethodID(global::org.drools.@event.rule.@__ActivationCancelledEvent.staticClass, "getKnowledgeRuntime", "()Lorg/drools/runtime/KnowledgeRuntime;");
            global::org.drools.@event.rule.@__ActivationCancelledEvent._getActivation1 = @__env.GetMethodID(global::org.drools.@event.rule.@__ActivationCancelledEvent.staticClass, "getActivation", "()Lorg/drools/runtime/rule/Activation;");
            global::org.drools.@event.rule.@__ActivationCancelledEvent._getCause2 = @__env.GetMethodID(global::org.drools.@event.rule.@__ActivationCancelledEvent.staticClass, "getCause", "()Lorg/drools/event/rule/ActivationCancelledCause;");
        }
        
        public global::org.drools.runtime.KnowledgeRuntime getKnowledgeRuntime() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.KnowledgeRuntime>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.rule.@__ActivationCancelledEvent._getKnowledgeRuntime0));
            }
        }
        
        public global::org.drools.runtime.rule.Activation getActivation() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.Activation>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.rule.@__ActivationCancelledEvent._getActivation1));
            }
        }
        
        public global::org.drools.@event.rule.ActivationCancelledCause getCause() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::org.drools.@event.rule.ActivationCancelledCause>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.rule.@__ActivationCancelledEvent._getCause2));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ActivationCancelledEvent);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getKnowledgeRuntime", "getKnowledgeRuntime0", "()Lorg/drools/runtime/KnowledgeRuntime;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getActivation", "getActivation1", "()Lorg/drools/runtime/rule/Activation;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCause", "getCause2", "()Lorg/drools/event/rule/ActivationCancelledCause;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getKnowledgeRuntime0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/KnowledgeRuntime;
            // ()Lorg/drools/runtime/KnowledgeRuntime;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.rule.ActivationCancelledEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.ActivationCancelledEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.KnowledgeRuntime>(@__env, ((global::org.drools.@event.KnowledgeRuntimeEvent)(@__real)).getKnowledgeRuntime());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getActivation1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/rule/Activation;
            // ()Lorg/drools/runtime/rule/Activation;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.rule.ActivationCancelledEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.ActivationCancelledEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.rule.Activation>(@__env, ((global::org.drools.@event.rule.ActivationEvent)(@__real)).getActivation());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getCause2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/event/rule/ActivationCancelledCause;
            // ()Lorg/drools/event/rule/ActivationCancelledCause;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.rule.ActivationCancelledEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.ActivationCancelledEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getCause());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.@event.rule.@__ActivationCancelledEvent(@__env);
            }
        }
    }
    #endregion
}
