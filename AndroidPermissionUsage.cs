using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class AndroidPermissionUsage : MonoBehaviour
{
    //Android Permission Setting
    public string[] WantedPermissions = {"android.permission.READ_EXTERNAL_STORAGE",
                                         "android.permission.CAMERA"};

    private string currentPermission;
    public GameObject canvas_popup;
    public GameObject canvas_denied;

    public void Start()
    {
        CallPermission();
        
    }

    public void CallPermission()
    {
#if UNITY_ANDROID
        bool isAnyFailed = false;

        // 한개라도 permission이 제대로 안되있다면 true를 반환함
        for (int i = 0; i < WantedPermissions.Length; i++)
        {
            if (CheckPermissions(WantedPermissions[i]) == false)
            {
                isAnyFailed = true;
                //return;
            }
        }

        if (isAnyFailed)
        {
            Debug.LogWarning("권한이 없습니다, 권한 승인을 해주세요");
            // 퍼미션을 왜 요청하는지 설명하는 팝업을 이 때 ON 시켜주면 됨
            // 팝업에는 버튼 하나가 있고 누르면 OnGrantButtonPress()를 호출해야함
            canvas_popup.SetActive(true);
        }
        else
        {
            // 성공한 부분. 권한을 가지고 하고싶은 일을 하면 됨
            Debug.Log("퍼미션 확인 완료..");
            SceneManager.LoadScene("LoadingScene");
            PlayerPrefs.SetInt("Camera", 1);
        }
#endif
    }


    // 퍼미션을 체크한다.
    private bool CheckPermissions(string a_permission)
    {

        // 안드로이드가 아니면 ㅍㅊ true를 리턴시킨다.
        if (Application.platform != RuntimePlatform.Android)
        {
            return true;
        }

        return AndroidPermissionsManager.IsPermissionGranted(a_permission);
    }

    // 권한 승인 버튼에 할당합시다.
    public void OnGrantButtonPress()
    {
#if UNITY_ANDROID
        for (int i = 0; i < WantedPermissions.Length; i++)
        {
            AndroidPermissionsManager.RequestPermission(new[] { WantedPermissions[i] }, new AndroidPermission(
            grantedPermission =>
            {
                // 권한이 승인 되었다.
                CallPermission();
            },
            deniedPermission =>
            {
                canvas_denied.SetActive(true);
                // 권한이 거절되었다.
            },
            deniedPermissionAndDontAskAgain =>
            {
                // 권한이 거절된데다가 다시 묻지마시오를 눌러버렸다.
                // 안드로이드 설정창 권한에서 직접 변경 할 수 있다는 팝업을 띄우는 방식을 취해야함. 
                canvas_denied.SetActive(true);
            }));
        }
#endif
    }

    public void CloseDenied()
    {
        canvas_denied.SetActive(false);
    }

    
    public void OpenSettings()
    {
        try
        {
#if UNITY_ANDROID
            using (var unityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            using (AndroidJavaObject currentActivityObject = unityClass.GetStatic<AndroidJavaObject>("currentActivity"))
            {
                string packageName = currentActivityObject.Call<string>("getPackageName");

                using (var uriClass = new AndroidJavaClass("android.net.Uri"))
                using (AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("fromParts", "package", packageName, null))
                using (var intentObject = new AndroidJavaObject("android.content.Intent", "android.settings.APPLICATION_DETAILS_SETTINGS", uriObject))
                {
                    intentObject.Call<AndroidJavaObject>("addCategory", "android.intent.category.DEFAULT");
                    intentObject.Call<AndroidJavaObject>("setFlags", 0x10000000);
                    currentActivityObject.Call("startActivity", intentObject);
                }
            }
#endif
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
        }
    }

}
