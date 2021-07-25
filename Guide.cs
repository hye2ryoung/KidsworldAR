using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guide : MonoBehaviour
{
    public void Start()
    {
        int OffGuide = PlayerPrefs.GetInt("OffGuide");
        if (OffGuide == 1)
        {
            GameObject.Find("Canvas").transform.Find("Mainguide").gameObject.SetActive(false);
        }
        else if (OffGuide == 0) //SetInt 0 값은 앱 실행 > 비디오 스크립트에 저장 (VedioController) 
        {
            GameObject.Find("Canvas").transform.Find("Mainguide").gameObject.SetActive(true);
        }
    }

    public void CloseMainGuide()
    {
        GameObject.Find("Canvas").transform.Find("Mainguide").gameObject.SetActive(false);
        EffectSound.instance.BtnSound();

        PlayerPrefs.SetInt("OffGuide", 1);
    }

    public void OnEnterGuide()
    {
        GameObject.Find("Panel").transform.Find("EnterBack").gameObject.SetActive(true);
        EffectSound.instance.BtnSound();
    }

    //AR 카메라 Scene으로 넘어가는 걸로 바꿔야함
    public void CloseEnterGuide() 
    {
        GameObject.Find("Panel").transform.Find("EnterBack").gameObject.SetActive(false);
        SceneManager.LoadScene("GuideUI");
    }

    public void OnUpdateGuide()
    {
        GameObject.Find("Canvas").transform.Find("UpdateGuide").gameObject.SetActive(true);
        EffectSound.instance.BtnSound();
    }

    public void CloseUpdateGuide()
    {
        GameObject.Find("Canvas").transform.Find("UpdateGuide").gameObject.SetActive(false);
        EffectSound.instance.BtnSound();
    }
}
