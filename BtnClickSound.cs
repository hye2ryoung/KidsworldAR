using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnClickSound : MonoBehaviour
{
    public void ClickBtn()
    {
        //AudioSound.BtnSound();
        EffectSound.instance.BtnSound();
    }

    public void ReceiveBtn()
    {
        //AudioSound.ReceiveSound();
        EffectSound.instance.ReceiveSound();
    }
}
