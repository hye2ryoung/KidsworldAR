using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingAnim : MonoBehaviour
{
    void Start()
    {
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0;
    }

    // 설정 열고 닫기 애니메이션 
    public void SettingButton()
    {
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 1;
        anim.Play("SettingBox", -1, 0);
        EffectSound.instance.BtnSound();
    }
    public void CloseButton()
    {
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.Play("SettingClose", -1, 0);
        EffectSound.instance.BtnSound();
    }

}
