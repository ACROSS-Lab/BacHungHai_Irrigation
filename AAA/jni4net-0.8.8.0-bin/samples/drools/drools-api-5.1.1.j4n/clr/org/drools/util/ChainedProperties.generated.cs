//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class ChainedProperties : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _writeExternal0;
        
        internal static global::net.sf.jni4net.jni.MethodId _readExternal1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProperty2;
        
        internal static global::net.sf.jni4net.jni.MethodId _addProperties3;
        
        internal static global::net.sf.jni4net.jni.MethodId _mapStartsWith4;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorChainedProperties5;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorChainedProperties6;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorChainedProperties7;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)V")]
        public ChainedProperties(global::java.lang.String par0, global::java.lang.ClassLoader par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.NewObject(global::org.drools.util.ChainedProperties.staticClass, global::org.drools.util.ChainedProperties.@__ctorChainedProperties5, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;Z)V")]
        public ChainedProperties(global::java.lang.String par0, global::java.lang.ClassLoader par1, bool par2) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            @__env.NewObject(global::org.drools.util.ChainedProperties.staticClass, global::org.drools.util.ChainedProperties.@__ctorChainedProperties6, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public ChainedProperties() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::org.drools.util.ChainedProperties.staticClass, global::org.drools.util.ChainedProperties.@__ctorChainedProperties7, this);
            }
        }
        
        protected ChainedProperties(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.util.ChainedProperties.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.util.ChainedProperties.staticClass = @__class;
            global::org.drools.util.ChainedProperties._writeExternal0 = @__env.GetMethodID(global::org.drools.util.ChainedProperties.staticClass, "writeExternal", "(Ljava/io/ObjectOutput;)V");
            global::org.drools.util.ChainedProperties._readExternal1 = @__env.GetMethodID(global::org.drools.util.ChainedProperties.staticClass, "readExternal", "(Ljava/io/ObjectInput;)V");
            global::org.drools.util.ChainedProperties._getProperty2 = @__env.GetMethodID(global::org.drools.util.ChainedProperties.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            global::org.drools.util.ChainedProperties._addProperties3 = @__env.GetMethodID(global::org.drools.util.ChainedProperties.staticClass, "addProperties", "(Ljava/util/Properties;)V");
            global::org.drools.util.ChainedProperties._mapStartsWith4 = @__env.GetMethodID(global::org.drools.util.ChainedProperties.staticClass, "mapStartsWith", "(Ljava/util/Map;Ljava/lang/String;Z)V");
            global::org.drools.util.ChainedProperties.@__ctorChainedProperties5 = @__env.GetMethodID(global::org.drools.util.ChainedProperties.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;)V");
            global::org.drools.util.ChainedProperties.@__ctorChainedProperties6 = @__env.GetMethodID(global::org.drools.util.ChainedProperties.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;Z)V");
            global::org.drools.util.ChainedProperties.@__ctorChainedProperties7 = @__env.GetMethodID(global::org.drools.util.ChainedProperties.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/ObjectOutput;)V")]
        public virtual void writeExternal(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.util.ChainedProperties._writeExternal0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/ObjectInput;)V")]
        public virtual void readExternal(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.util.ChainedProperties._readExternal1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
        public virtual global::java.lang.String getProperty(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.util.ChainedProperties._getProperty2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Properties;)V")]
        public virtual void addProperties(global::java.util.Properties par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.util.ChainedProperties._addProperties3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Map;Ljava/lang/String;Z)V")]
        public virtual void mapStartsWith(global::java.util.Map par0, global::java.lang.String par1, bool par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            @__env.CallVoidMethod(this, global::org.drools.util.ChainedProperties._mapStartsWith4, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Map>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.util.ChainedProperties(@__env);
            }
        }
    }
    #endregion
}
