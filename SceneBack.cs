using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBack : MonoBehaviour
{
    public static int order;

    public void Achievment()
    {
        SceneManager.LoadScene("AchievScene");
    }

    public void BackToTheme1()
    {
        /*SceneManager.LoadScene("MainScene");
        ordernum = 1;
        PlayerPrefs.SetInt("theme", ordernum);
        */
        order = 1;
        SceneManager.LoadScene("MainScene");
        EffectSound.instance.BtnSound();
    }

    public void BackToTheme2()
    {
        order = 2;
        SceneManager.LoadScene("MainScene");
        EffectSound.instance.BtnSound();
    }

    public void BackToTheme3()
    {
        order = 3;
        SceneManager.LoadScene("MainScene");
        EffectSound.instance.BtnSound();
    }

    public void BackToTheme4()
    {
        order = 4;
        SceneManager.LoadScene("MainScene");
        EffectSound.instance.BtnSound();
    }

    public void BackToTheme5()
    {
        order = 5;
        SceneManager.LoadScene("MainScene");
        EffectSound.instance.BtnSound();
    }

    public void BackToTheme6()
    {
        order = 6;
        SceneManager.LoadScene("MainScene");
        EffectSound.instance.BtnSound();
    }

    public void BackToTheme7()
    {
        order = 7;
        SceneManager.LoadScene("MainScene");
        EffectSound.instance.BtnSound();
    }
}
