import net.sf.jni4net.Bridge;

import java.io.IOException;

import mycsharpdemocalc.DemoCalc;
import mycsharpdemocalc.ICalc;

public class MyCalcUsageInJava {
    public static void main(String arsg[]) throws IOException {
        Bridge.init();
        Bridge.LoadAndRegisterAssemblyFrom(new java.io.File("MyCSharpDemoCalc.j4n.dll"));

        ICalc calc = new DemoCalc();
        final String result = calc.MySuperSmartFunctionIDontHaveInJava("C:\\git\\HydraulicTools\\RESULT2015.res11", "KIM_SON");

        System.out.printf("Answer to the Ultimate Question is : " + result);
    }
}
