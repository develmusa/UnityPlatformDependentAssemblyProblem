

public class Main
{
    public void Test()
    {
        /// Classes In Same Assembly 
        /// ---------------------

        // Works as intended
        // Class in context
        UnrestrictedClassSameAssembly.Test();

        // Works as intended
        // Class in context
#if UNITY_WSA_10_0
        UWPClassSameAssembly.Test();
#endif

        /// Classes In Other Assembly
        /// ---------------------

        // Works as intended
        // Class in context
        UnrestrictedClassOtherAssembly.Test();

        // Does NOT work as intended
        // The name UWPClassOtherAssembly does not exist in the current context
#if UNITY_WSA_10_0
        UWPClassOtherAssemblyUnityWSA.Test();
#endif

#if WINDOWS_UWP
        UWPClassOtherAssemblyWindowsUWP.Test(null);
#endif

        /// Classes In WSA Assembly
        /// ---------------------
        ///

        // Does NOT work as intended
        // The name ClassUWPAssembly does not exist in the current context
#if UNITY_WSA_10_0
        ClassUWPAssembly.Test(null);
#endif
    }
}