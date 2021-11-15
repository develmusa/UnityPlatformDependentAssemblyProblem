public static class UnrestrictedClassOtherAssembly
{
    public static void Test() { }
}
#if UNITY_WSA_10_0 
public static class UWPClassOtherAssemblyUnityWSA
{
    public static void Test() { }
    public static void Test(Windows.Storage.StorageFolder sf) { }
}
#endif

#if WINDOWS_UWP 
public static class UWPClassOtherAssemblyWindowsUWP
{
    public static void Test(Windows.Storage.StorageFolder sf) { }
}
#endif
