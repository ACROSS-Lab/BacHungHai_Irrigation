import net.sf.jni4net.Bridge;

import java.io.File;
import java.io.IOException;

import mycsharpdemocalc.DemoCalc;

public class MyCalcUsageInJava {
    public static void main(String arsg[]) throws IOException {
    	System.setProperty("user.dir","C:\\git\\BacHungHai_Irrigation\\AAA\\jni4net-0.8.8.0-bin\\samples\\myCSharpDemoCalc\\work");
		Bridge.setVerbose(true);
        Bridge.init();

//        Bridge.init(new File(System.getProperty("user.dir")));
//        Bridge.LoadAndRegisterAssemblyFrom(new File("C:\\git\\BacHungHai_Irrigation\\AAA\\jni4net-0.8.8.0-bin\\samples\\myCSharpDemoCalc\\work\\DHI.Generic.MikeZero.DFS.dll"));
//
//        Bridge.LoadAndRegisterAssemblyFrom(new File("C:\\git\\BacHungHai_Irrigation\\AAA\\jni4net-0.8.8.0-bin\\samples\\myCSharpDemoCalc\\work\\DHI.DHIfl.dll"));
//
//        Bridge.LoadAndRegisterAssemblyFrom(new File("C:\\git\\BacHungHai_Irrigation\\AAA\\jni4net-0.8.8.0-bin\\samples\\myCSharpDemoCalc\\work\\DHI.Generic.MikeZero.EUM.dll"));
//
//        Bridge.LoadAndRegisterAssemblyFrom(new File("C:\\git\\BacHungHai_Irrigation\\AAA\\jni4net-0.8.8.0-bin\\samples\\myCSharpDemoCalc\\work\\DHI.PFS.dll"));
//
//        Bridge.LoadAndRegisterAssemblyFrom(new File("C:\\git\\BacHungHai_Irrigation\\AAA\\jni4net-0.8.8.0-bin\\samples\\myCSharpDemoCalc\\work\\jni4net.n.w64.v40-0.8.8.0.dll"));
//        Bridge.LoadAndRegisterAssemblyFrom(new File("C:\\git\\BacHungHai_Irrigation\\AAA\\jni4net-0.8.8.0-bin\\samples\\myCSharpDemoCalc\\work\\jni4net.n-0.8.8.0.dll"));
//        Bridge.LoadAndRegisterAssemblyFrom(new File("C:\\git\\BacHungHai_Irrigation\\AAA\\jni4net-0.8.8.0-bin\\samples\\myCSharpDemoCalc\\work\\MyCSharpDemoCalc.dll"));
//        Bridge.LoadAndRegisterAssemblyFrom(new File("C:\\git\\BacHungHai_Irrigation\\AAA\\jni4net-0.8.8.0-bin\\samples\\myCSharpDemoCalc\\work\\MyCSharpDemoCalc.j4n.dll"));
        Bridge.LoadAndRegisterAssemblyFrom(new File("MyCSharpDemoCalc.j4n.dll"));

        DemoCalc calc = new DemoCalc();
        final String result = calc.MySuperSmartFunctionIDontHaveInJava("C:\\git\\HydraulicTools\\RESULT2015.res11", "KIM_SON");

        System.out.printf("Answer to the Ultimate Question is : " + result);
    }
}
