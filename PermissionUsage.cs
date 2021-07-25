using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PermissionUsage : MonoBehaviour
{
    
    //iOS Permission Setting
    public void VerifyPermission()
    {
        iOSPermission.VerifyPermission(gameObject.name, "SampleCallback");
    }

    public void SampleCallback(string permissionWasGranted)
    {
        Debug.Log("Callback.permissionWasGranted = " + permissionWasGranted);

        if (permissionWasGranted == "true")
        {
            SceneManager.LoadScene("LoadingScene");
            PlayerPrefs.SetInt("Camera", 1); //true일때 로딩씬으로넘어가게 저장 - VidoController에서 GetInt로 저장값 불러옴 
        }
        else
        {
            GameObject.Find("Canvas").transform.Find("denied_Image").gameObject.SetActive(true);
            PlayerPrefs.SetInt("Camera", 0);
        }
    }

    public void GotoAppSetting()
    {
        iOSPermission.OpenSettings();
    }

    
}
