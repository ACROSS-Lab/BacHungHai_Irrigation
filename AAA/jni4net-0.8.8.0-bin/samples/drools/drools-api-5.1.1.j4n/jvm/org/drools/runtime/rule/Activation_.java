// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.runtime.rule;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class Activation_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.runtime.rule.Activation_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.runtime.rule.Activation_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __Activation extends system.Object implements org.drools.runtime.rule.Activation {
    
    protected __Activation(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/definition/rule/Rule;")
    public native org.drools.definition.rule.Rule getRule();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/List;")
    public native java.util.List getObjects();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/List;")
    public native java.util.List getFactHandles();
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/runtime/rule/PropagationContext;")
    public native org.drools.runtime.rule.PropagationContext getPropagationContext();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/util/List;")
    public native java.util.List getDeclarationIDs();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)Ljava/lang/Object;")
    public native java.lang.Object getDeclarationValue(java.lang.String par0);
}
//</generated-proxy>
