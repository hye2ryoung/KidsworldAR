using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    public void AbilityTheme1()
    {
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 1;
        anim.Play("IntroBack1", -1, 0);

    }
    public void CloseAbility()
    {
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 1;
        anim.Play("CloseIntroBox", -1, 0);
        EffectSound.instance.BtnSound();

    }
}
