// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package mycsharpdemocalc;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class ICalc_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return mycsharpdemocalc.ICalc_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        mycsharpdemocalc.ICalc_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __ICalc extends system.Object implements mycsharpdemocalc.ICalc {
    
    protected __ICalc(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/String;)LSystem/String;")
    public native java.lang.String MySuperSmartFunctionIDontHaveInJava(java.lang.String filename, java.lang.String gate_name);
}
//</generated-proxy>