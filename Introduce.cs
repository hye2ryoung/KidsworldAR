using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introduce : MonoBehaviour
{
    public void OnFadeComplete1()
    {
        DoorEnter.EnterDoor1();
        EffectSound.instance.EnterSound();
    }

    public void OnFadeComplete2()
    {
        DoorEnter.EnterDoor2();
        EffectSound.instance.EnterSound();
    }

    public void OnFadeComplete3()
    {
        EffectSound.instance.EnterSound();
    }

    public void OnFadeComplete4()
    {
        EffectSound.instance.EnterSound();
    }

    public void OnFadeComplete5()
    {
        DoorEnter.EnterDoor5();
        EffectSound.instance.EnterSound();
    }

    public void OnFadeComplete6()
    {
        EffectSound.instance.EnterSound();
    }

    public void OnFadeComplete7()
    {
        EffectSound.instance.EnterSound();
    }




    public void Load1()
    {
        SceneManager.LoadScene("Introduce1");
    }
    public void Load2()
    {
        SceneManager.LoadScene("Introduce2");
    }
    public void Load3()
    {
        SceneManager.LoadScene("Introduce3");
    }
    public void Load4()
    {
        SceneManager.LoadScene("Introduce4");
    }
    public void Load5()
    {
        SceneManager.LoadScene("Introduce5");
    }
    public void Load6()
    {
        SceneManager.LoadScene("Introduce6");
    }
    public void Load7()
    {
        SceneManager.LoadScene("Introduce7");
    }
}
