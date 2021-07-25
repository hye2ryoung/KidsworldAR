using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Privacy : MonoBehaviour
{
    public Toggle ServiceToggle;
    public Toggle PrivacyToggle;

    public void Start()
    {
        PlayerPrefs.SetInt("isOnService", 0);
        PlayerPrefs.SetInt("isOnPrivacy", 0);
    }


    public void Update()
    {
        int IsOnCheckService = PlayerPrefs.GetInt("isOnService");
        int IsOnCheckPrivacy = PlayerPrefs.GetInt("isOnPrivacy");

        if (IsOnCheckService == 1) ServiceToggle.isOn = true;
        else if (IsOnCheckService == 0) ServiceToggle.isOn = false;

        if (IsOnCheckPrivacy == 1) PrivacyToggle.isOn = true;
        else if (IsOnCheckPrivacy == 0) PrivacyToggle.isOn = false;

        if ((IsOnCheckService == 1) && (IsOnCheckPrivacy == 1))
        {
            GameObject.Find("PrivacyBox").transform.Find("OKButton").gameObject.SetActive(true);
        }
        else if ((IsOnCheckService == 0) || (IsOnCheckPrivacy == 0))
        {
            GameObject.Find("PrivacyBox").transform.Find("OKButton").gameObject.SetActive(false);
        }
    }

    public void ToggleCheck()
    {
        if (ServiceToggle.isOn == true) PlayerPrefs.SetInt("isOnService", 1);
        else if (ServiceToggle.isOn == false) PlayerPrefs.SetInt("isOnService", 0);

        if (PrivacyToggle.isOn == true) PlayerPrefs.SetInt("isOnPrivacy", 1);
        else if (PrivacyToggle.isOn == false) PlayerPrefs.SetInt("isOnPrivacy", 0);
    }

    public void OKButtonClick()
    {
        GameObject.Find("PermissionBlack").transform.Find("PrivacyBox").gameObject.SetActive(false);
    }

    public void OpenService()
    {
        //Application.OpenURL("");
    }

    public void OpenPrivacy()
    {
        Application.OpenURL("https://offworldbusiness.github.io");
    }
}
