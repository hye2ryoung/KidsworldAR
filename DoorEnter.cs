using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnter : MonoBehaviour
{
    private void Start()
    {
        //Theme1 DoorBack 애니메이션 시작
        Animator anim = GameObject.Find("Theme1").transform.Find("DoorBack1").gameObject.GetComponent<Animator>();
        anim.speed = 0.05f;
        anim.Play("doorback1", -1, 0);

    }

    

    public static void OnDoorBack2() //theme2 결제완료하면 활성화
    {
        GameObject.Find("Theme2").transform.Find("Door2").gameObject.SetActive(true);
        GameObject.Find("Theme2").transform.Find("DoorBack2").gameObject.SetActive(true);

        Animator anim = GameObject.Find("Theme2").transform.Find("DoorBack2").gameObject.GetComponent<Animator>();
        anim.speed = 0.05f;
        anim.Play("doorback2", -1, 0);
    }

    public static void OnDoorBack5() //theme5 결제완료하면 활성화
    {
        GameObject.Find("Theme5").transform.Find("Door5").gameObject.SetActive(true);
        GameObject.Find("Theme5").transform.Find("DoorBack5").gameObject.SetActive(true);

        Animator anim = GameObject.Find("Theme5").transform.Find("DoorBack5").gameObject.GetComponent<Animator>();
        anim.speed = 0.05f;
        anim.Play("doorback5", -1, 0);
    }

    public static void EnterDoor1()
    {
        Animator anim = GameObject.Find("Theme1").transform.Find("DoorBack1").gameObject.GetComponent<Animator>();
        anim.speed = 1;
        anim.Play("enterdoor1", -1, 0);

        Animator anim2 = GameObject.Find("SettingController").gameObject.GetComponent<Animator>();
        anim2.speed = 1;
        anim2.Play("enterImage1", -1, 0);
    }

    public static void EnterDoor2()
    {
        
        Animator anim = GameObject.Find("Theme2").transform.Find("DoorBack2").gameObject.GetComponent<Animator>();
        anim.speed = 1;
        anim.Play("enterdoor2");

        Animator anim2 = GameObject.Find("SettingController").gameObject.GetComponent<Animator>();
        anim2.speed = 1;
        anim2.Play("enterImage2", -1, 0);
    }

    public static void EnterDoor5()
    {

        Animator anim = GameObject.Find("Theme5").transform.Find("DoorBack5").gameObject.GetComponent<Animator>();
        anim.speed = 1;
        anim.Play("enterdoor5");

        Animator anim2 = GameObject.Find("SettingController").gameObject.GetComponent<Animator>();
        anim2.speed = 1;
        anim2.Play("enterImage5", -1, 0);
    }
}
