//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.runtime.conf {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class KeepReferenceOption : global::java.lang.Object, global::org.drools.runtime.conf.SingleValueKnowledgeSessionOption {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getPropertyName0;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf1;
        
        internal static global::net.sf.jni4net.jni.MethodId _values2;
        
        internal static global::net.sf.jni4net.jni.MethodId _isKeepReference3;
        
        internal static global::net.sf.jni4net.jni.FieldId _YES4;
        
        internal static global::net.sf.jni4net.jni.FieldId _NO5;
        
        internal static global::net.sf.jni4net.jni.FieldId _PROPERTY_NAME6;
        
        protected KeepReferenceOption(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.runtime.conf.KeepReferenceOption.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lorg/drools/runtime/conf/KeepReferenceOption;")]
        public static global::org.drools.runtime.conf.KeepReferenceOption YES {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::org.drools.runtime.conf.KeepReferenceOption>(@__env, @__env.GetStaticObjectFieldPtr(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, global::org.drools.runtime.conf.KeepReferenceOption._YES4));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lorg/drools/runtime/conf/KeepReferenceOption;")]
        public static global::org.drools.runtime.conf.KeepReferenceOption NO {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::org.drools.runtime.conf.KeepReferenceOption>(@__env, @__env.GetStaticObjectFieldPtr(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, global::org.drools.runtime.conf.KeepReferenceOption._NO5));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/String;")]
        public static global::java.lang.String PROPERTY_NAME {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.GetStaticObjectFieldPtr(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, global::org.drools.runtime.conf.KeepReferenceOption._PROPERTY_NAME6));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.runtime.conf.KeepReferenceOption.staticClass = @__class;
            global::org.drools.runtime.conf.KeepReferenceOption._getPropertyName0 = @__env.GetMethodID(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, "getPropertyName", "()Ljava/lang/String;");
            global::org.drools.runtime.conf.KeepReferenceOption._valueOf1 = @__env.GetStaticMethodID(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, "valueOf", "(Ljava/lang/String;)Lorg/drools/runtime/conf/KeepReferenceOption;");
            global::org.drools.runtime.conf.KeepReferenceOption._values2 = @__env.GetStaticMethodID(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, "values", "()[Lorg/drools/runtime/conf/KeepReferenceOption;");
            global::org.drools.runtime.conf.KeepReferenceOption._isKeepReference3 = @__env.GetMethodID(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, "isKeepReference", "()Z");
            global::org.drools.runtime.conf.KeepReferenceOption._YES4 = @__env.GetStaticFieldID(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, "YES", "Lorg/drools/runtime/conf/KeepReferenceOption;");
            global::org.drools.runtime.conf.KeepReferenceOption._NO5 = @__env.GetStaticFieldID(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, "NO", "Lorg/drools/runtime/conf/KeepReferenceOption;");
            global::org.drools.runtime.conf.KeepReferenceOption._PROPERTY_NAME6 = @__env.GetStaticFieldID(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, "PROPERTY_NAME", "Ljava/lang/String;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getPropertyName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.conf.KeepReferenceOption._getPropertyName0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Lorg/drools/runtime/conf/KeepReferenceOption;")]
        public static global::org.drools.runtime.conf.KeepReferenceOption valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::org.drools.runtime.conf.KeepReferenceOption>(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, global::org.drools.runtime.conf.KeepReferenceOption._valueOf1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Lorg/drools/runtime/conf/KeepReferenceOption;")]
        public static org.drools.runtime.conf.KeepReferenceOption[] values() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<org.drools.runtime.conf.KeepReferenceOption[], global::org.drools.runtime.conf.KeepReferenceOption>(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.runtime.conf.KeepReferenceOption.staticClass, global::org.drools.runtime.conf.KeepReferenceOption._values2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isKeepReference() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::org.drools.runtime.conf.KeepReferenceOption._isKeepReference3)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.runtime.conf.KeepReferenceOption(@__env);
            }
        }
    }
    #endregion
}
