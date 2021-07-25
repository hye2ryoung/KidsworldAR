#if UNITY_IOS && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif

public class iOSPermission
{

#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    extern static private void _verifyPermission(string gameObject, string callback);

    [DllImport("__Internal")]
    extern static private void _OpenSettings();
#endif

    public static void VerifyPermission(string gameObjectName, string callbackName)
    {
#if UNITY_IOS && !UNITY_EDITOR
        _verifyPermission(gameObjectName, callbackName);
#endif
    }

    public static void OpenSettings()
    {
#if UNITY_IOS && !UNITY_EDITOR
        _OpenSettings();
#endif
    }
}
