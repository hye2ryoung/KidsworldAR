using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void CreditOn()
    {
        
        GameObject.Find("Canvas").transform.Find("CreditPanel").gameObject.SetActive(true);
        
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 1f;
        anim.Play("CreditScroll", -1, 0);
        
    }
    public void CloseCredit()
    {
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 1f;
        anim.Play("BackToSetting", -1, 0);

        GameObject.Find("Canvas").transform.Find("CreditPanel").gameObject.SetActive(false);

    }
}
