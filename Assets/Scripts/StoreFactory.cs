using System;

public static class StoreFactory
{
    public static IStore GetStore()
    {
#if UNITY_ANDROID
        return new AndroidStore();
#elif UNITY_IOS
        return new iOSStore();
#else
        throw new PlatformNotSupportedException("Platform not supported");
#endif
    }
}