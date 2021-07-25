using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingControl : MonoBehaviour
{

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0;

        SliderSetting();

        OnTrophyBackImage1();
        OnTrophyBackImage2();
        OnTrophyBackImage3();
        OnTrophyBackImage4();
        OnTrophyBackImage5();
        OnTrophyBackImage6();
        OnTrophyBackImage7();

        UpdateAchiev1();
        UpdateTrophy1();
        UpdateAchiev2();
        UpdateTrophy2();
        UpdateAchiev3();
        UpdateTrophy3();
        UpdateAchiev4();
        UpdateTrophy4();
        UpdateAchiev5();
        UpdateTrophy5();
        UpdateAchiev6();
        UpdateTrophy6();
        UpdateAchiev7();
        UpdateTrophy7();

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

   

    // ---------------------------------------- Achiev Settings -------------------------------------- //

    // 업적받기화면 Close
    public void AchiveClose()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton1").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton2").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton3").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton4").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton5").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton6").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton7").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("Trophy").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("AchievText1").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("AchievText2").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("AchievText3").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("AchievText4").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("AchievText5").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("AchievText6").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("AchievText7").gameObject.SetActive(false);
        EffectSound.instance.BtnSound();
    }

    // 업적받기버튼 활성화
    // if 업적달성한다면 slider 값 1, 퍼센트text 100%로 변경, 받기버튼 활성화

    public Slider SliderTheme1;
    public Slider SliderTheme2;
    public Slider SliderTheme3;
    public Slider SliderTheme4;
    public Slider SliderTheme5;
    public Slider SliderTheme6;
    public Slider SliderTheme7;

    private int SliderValue1;
    private int SliderValue2;
    private int SliderValue3;
    private int SliderValue4;
    private int SliderValue5;
    private int SliderValue6;
    private int SliderValue7;

    public void SliderSetting()
    {
        SliderValue1 = PlayerPrefs.GetInt("AchievSlider1");
        SliderValue2 = PlayerPrefs.GetInt("AchievSlider2");
        SliderValue3 = PlayerPrefs.GetInt("AchievSlider3");
        SliderValue4 = PlayerPrefs.GetInt("AchievSlider4");
        SliderValue5 = PlayerPrefs.GetInt("AchievSlider5");
        SliderValue6 = PlayerPrefs.GetInt("AchievSlider6");
        SliderValue7 = PlayerPrefs.GetInt("AchievSlider7");

        if (SliderValue1 == 0) SliderTheme1.value = 0;
        else if (SliderValue1 == 1) SliderTheme1.value = 1;

        if (SliderValue2 == 0) SliderTheme2.value = 0;
        else if (SliderValue2 == 1) SliderTheme2.value = 1;

        if (SliderValue3 == 0) SliderTheme3.value = 0;
        else if (SliderValue3 == 1) SliderTheme3.value = 1;

        if (SliderValue4 == 0) SliderTheme4.value = 0;
        else if (SliderValue4 == 1) SliderTheme4.value = 1;

        if (SliderValue5 == 0) SliderTheme5.value = 0;
        else if (SliderValue5 == 1) SliderTheme5.value = 1;

        if (SliderValue6 == 0) SliderTheme6.value = 0;
        else if (SliderValue6 == 1) SliderTheme6.value = 1;

        if (SliderValue7 == 0) SliderTheme7.value = 0;
        else if (SliderValue7 == 1) SliderTheme7.value = 1;
    }


    public void OnReceiveBtn1()
    {
        //if 업적달성 필요 

        if (SliderTheme1.value == 1)
        {
            SliderTheme1.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme1.fillRect.anchorMax = new Vector2(1, 1);
            GameObject.Find("Achiev1").transform.Find("Text_Percent0").gameObject.SetActive(false);
            GameObject.Find("Achiev1").transform.Find("Text_Percent100").gameObject.SetActive(true);
            GameObject.Find("Achiev1").transform.Find("Button_Receive").gameObject.SetActive(true);
            PlayerPrefs.SetInt("AchievSlider1", 1);
        } else if (SliderTheme1.value == 0)
        {
            SliderTheme1.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme1.fillRect.anchorMax = new Vector2(0, 1);
            GameObject.Find("Achiev1").transform.Find("Text_Percent0").gameObject.SetActive(true);
            GameObject.Find("Achiev1").transform.Find("Text_Percent100").gameObject.SetActive(false);
            GameObject.Find("Achiev1").transform.Find("Button_Receive").gameObject.SetActive(false);
            PlayerPrefs.SetInt("AchievSlider1", 0);
        }
    }

    public void OnReceiveBtn2()
    {
        if (SliderTheme2.value == 1)
        {
            SliderTheme2.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme2.fillRect.anchorMax = new Vector2(1, 1);
            GameObject.Find("Achiev2").transform.Find("Text_Percent0").gameObject.SetActive(false);
            GameObject.Find("Achiev2").transform.Find("Text_Percent100").gameObject.SetActive(true);
            GameObject.Find("Achiev2").transform.Find("Button_Receive").gameObject.SetActive(true);
            PlayerPrefs.SetInt("AchievSlider2", 1);
        } else if (SliderTheme2.value == 0)
        {
            SliderTheme2.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme2.fillRect.anchorMax = new Vector2(0, 1);
            GameObject.Find("Achiev2").transform.Find("Text_Percent0").gameObject.SetActive(true);
            GameObject.Find("Achiev2").transform.Find("Text_Percent100").gameObject.SetActive(false);
            GameObject.Find("Achiev2").transform.Find("Button_Receive").gameObject.SetActive(false);
            PlayerPrefs.SetInt("AchievSlider2", 0);
        }
    }

    public void OnReceiveBtn3()
    {
        if (SliderTheme3.value == 1)
        {
            SliderTheme3.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme3.fillRect.anchorMax = new Vector2(1, 1);
            GameObject.Find("Achiev3").transform.Find("Text_Percent0").gameObject.SetActive(false);
            GameObject.Find("Achiev3").transform.Find("Text_Percent100").gameObject.SetActive(true);
            GameObject.Find("Achiev3").transform.Find("Button_Receive").gameObject.SetActive(true);
            PlayerPrefs.SetInt("AchievSlider3", 1);
        }
        else if (SliderTheme3.value == 0)
        {
            SliderTheme3.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme3.fillRect.anchorMax = new Vector2(0, 1);
            GameObject.Find("Achiev3").transform.Find("Text_Percent0").gameObject.SetActive(true);
            GameObject.Find("Achiev3").transform.Find("Text_Percent100").gameObject.SetActive(false);
            GameObject.Find("Achiev3").transform.Find("Button_Receive").gameObject.SetActive(false);
            PlayerPrefs.SetInt("AchievSlider3", 0);
        }
    }

    public void OnReceiveBtn4()
    {
        if (SliderTheme4.value == 1)
        {
            SliderTheme4.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme4.fillRect.anchorMax = new Vector2(1, 1);
            GameObject.Find("Achiev4").transform.Find("Text_Percent0").gameObject.SetActive(false);
            GameObject.Find("Achiev4").transform.Find("Text_Percent100").gameObject.SetActive(true);
            GameObject.Find("Achiev4").transform.Find("Button_Receive").gameObject.SetActive(true);
            PlayerPrefs.SetInt("AchievSlider4", 1);
        }
        else if (SliderTheme4.value == 0)
        {
            SliderTheme4.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme4.fillRect.anchorMax = new Vector2(0, 1);
            GameObject.Find("Achiev4").transform.Find("Text_Percent0").gameObject.SetActive(true);
            GameObject.Find("Achiev4").transform.Find("Text_Percent100").gameObject.SetActive(false);
            GameObject.Find("Achiev4").transform.Find("Button_Receive").gameObject.SetActive(false);
            PlayerPrefs.SetInt("AchievSlider4", 0);
        }
    }

    public void OnReceiveBtn5()
    {
         if (SliderTheme5.value == 1)
         {
             SliderTheme5.fillRect.anchorMin = new Vector2(0, 0);
             SliderTheme5.fillRect.anchorMax = new Vector2(1, 1);
             GameObject.Find("Achiev5").transform.Find("Text_Percent0").gameObject.SetActive(false);
             GameObject.Find("Achiev5").transform.Find("Text_Percent100").gameObject.SetActive(true);
             GameObject.Find("Achiev5").transform.Find("Button_Receive").gameObject.SetActive(true);
             PlayerPrefs.SetInt("AchievSlider5", 1);
         }
         else if (SliderTheme5.value == 0)
         {
             SliderTheme5.fillRect.anchorMin = new Vector2(0, 0);
             SliderTheme5.fillRect.anchorMax = new Vector2(0, 1);
             GameObject.Find("Achiev5").transform.Find("Text_Percent0").gameObject.SetActive(true);
             GameObject.Find("Achiev5").transform.Find("Text_Percent100").gameObject.SetActive(false);
             GameObject.Find("Achiev5").transform.Find("Button_Receive").gameObject.SetActive(false);
             PlayerPrefs.SetInt("AchievSlider5", 0);
         }
    }

    public void OnReceiveBtn6()
    {
        if (SliderTheme6.value == 1)
        {
            SliderTheme6.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme6.fillRect.anchorMax = new Vector2(1, 1);
            GameObject.Find("Achiev6").transform.Find("Text_Percent0").gameObject.SetActive(false);
            GameObject.Find("Achiev6").transform.Find("Text_Percent100").gameObject.SetActive(true);
            GameObject.Find("Achiev6").transform.Find("Button_Receive").gameObject.SetActive(true);
            PlayerPrefs.SetInt("AchievSlider6", 1);
        }
        else if (SliderTheme6.value == 0)
        {
            SliderTheme6.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme6.fillRect.anchorMax = new Vector2(0, 1);
            GameObject.Find("Achiev6").transform.Find("Text_Percent0").gameObject.SetActive(true);
            GameObject.Find("Achiev6").transform.Find("Text_Percent100").gameObject.SetActive(false);
            GameObject.Find("Achiev6").transform.Find("Button_Receive").gameObject.SetActive(false);
            PlayerPrefs.SetInt("AchievSlider6", 0);
        }
    }

    public void OnReceiveBtn7()
    {
        if (SliderTheme7.value == 1)
        {
            SliderTheme7.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme7.fillRect.anchorMax = new Vector2(1, 1);
            GameObject.Find("Achiev7").transform.Find("Text_Percent0").gameObject.SetActive(false);
            GameObject.Find("Achiev7").transform.Find("Text_Percent100").gameObject.SetActive(true);
            GameObject.Find("Achiev7").transform.Find("Button_Receive").gameObject.SetActive(true);
            PlayerPrefs.SetInt("AchievSlider7", 1);
        }
        else if (SliderTheme7.value == 0)
        {
            SliderTheme7.fillRect.anchorMin = new Vector2(0, 0);
            SliderTheme7.fillRect.anchorMax = new Vector2(0, 1);
            GameObject.Find("Achiev7").transform.Find("Text_Percent0").gameObject.SetActive(true);
            GameObject.Find("Achiev7").transform.Find("Text_Percent100").gameObject.SetActive(false);
            GameObject.Find("Achiev7").transform.Find("Button_Receive").gameObject.SetActive(false);
            PlayerPrefs.SetInt("AchievSlider7", 0);
        }
    }

    // -------------------------------- 업적 Text 설정 ------------------------------

    private int AchievIndex1;
    private int AchievLevel1;
    private int TrophyIndex1;
    private int TrophyLevel1;

    private int AchievIndex2;
    private int AchievLevel2;
    private int TrophyIndex2;
    private int TrophyLevel2;

    private int AchievIndex3;
    private int AchievLevel3;
    private int TrophyIndex3;
    private int TrophyLevel3;

    private int AchievIndex4;
    private int AchievLevel4;
    private int TrophyIndex4;
    private int TrophyLevel4;

    private int AchievIndex5;
    private int AchievLevel5;
    private int TrophyIndex5;
    private int TrophyLevel5;

    private int AchievIndex6;
    private int AchievLevel6;
    private int TrophyIndex6;
    private int TrophyLevel6;

    private int AchievIndex7;
    private int AchievLevel7;
    private int TrophyIndex7;
    private int TrophyLevel7;

    [SerializeField] private Text AchievName1;
    [SerializeField] private Text TrophyName1;
    [SerializeField] private List<AchievTheme1> AchievList1 = new List<AchievTheme1>();
    [SerializeField] private List<TrophyTheme1> TrophyList1 = new List<TrophyTheme1>();

    [SerializeField] private Text AchievName2;
    [SerializeField] private Text TrophyName2;
    [SerializeField] private List<AchievTheme2> AchievList2 = new List<AchievTheme2>();
    [SerializeField] private List<TrophyTheme2> TrophyList2 = new List<TrophyTheme2>();

    [SerializeField] private Text AchievName3;
    [SerializeField] private Text TrophyName3;
    [SerializeField] private List<AchievTheme3> AchievList3 = new List<AchievTheme3>();
    [SerializeField] private List<TrophyTheme3> TrophyList3 = new List<TrophyTheme3>();

    [SerializeField] private Text AchievName4;
    [SerializeField] private Text TrophyName4;
    [SerializeField] private List<AchievTheme4> AchievList4 = new List<AchievTheme4>();
    [SerializeField] private List<TrophyTheme4> TrophyList4 = new List<TrophyTheme4>();

    [SerializeField] private Text AchievName5;
    [SerializeField] private Text TrophyName5;
    [SerializeField] private List<AchievTheme5> AchievList5 = new List<AchievTheme5>();
    [SerializeField] private List<TrophyTheme5> TrophyList5 = new List<TrophyTheme5>();

    [SerializeField] private Text AchievName6;
    [SerializeField] private Text TrophyName6;
    [SerializeField] private List<AchievTheme6> AchievList6 = new List<AchievTheme6>();
    [SerializeField] private List<TrophyTheme6> TrophyList6 = new List<TrophyTheme6>();

    [SerializeField] private Text AchievName7;
    [SerializeField] private Text TrophyName7;
    [SerializeField] private List<AchievTheme7> AchievList7 = new List<AchievTheme7>();
    [SerializeField] private List<TrophyTheme7> TrophyList7 = new List<TrophyTheme7>();


    public void UpdateAchiev1()
    {
        AchievLevel1 = PlayerPrefs.GetInt("Achiev1");
        AchievName1.text = AchievList1[AchievLevel1].AchievName1;
    }
    public void UpdateAchiev2()
    {
        AchievLevel2 = PlayerPrefs.GetInt("Achiev2");
        AchievName2.text = AchievList2[AchievLevel2].AchievName2;
    }
    public void UpdateAchiev3()
    {
        AchievLevel3 = PlayerPrefs.GetInt("Achiev3");
        AchievName3.text = AchievList3[AchievLevel3].AchievName3;
    }
    public void UpdateAchiev4()
    {
        AchievLevel4 = PlayerPrefs.GetInt("Achiev4");
        AchievName4.text = AchievList4[AchievLevel4].AchievName4;
    }
    public void UpdateAchiev5()
    {
        AchievLevel5 = PlayerPrefs.GetInt("Achiev5");
        AchievName5.text = AchievList5[AchievLevel5].AchievName5;
    }
    public void UpdateAchiev6()
    {
        AchievLevel6 = PlayerPrefs.GetInt("Achiev6");
        AchievName6.text = AchievList6[AchievLevel6].AchievName6;
    }
    public void UpdateAchiev7()
    {
        AchievLevel7 = PlayerPrefs.GetInt("Achiev7");
        AchievName7.text = AchievList7[AchievLevel7].AchievName7;
    }



    public void UpdateTrophy1()
    {
        TrophyLevel1 = PlayerPrefs.GetInt("Trophy1");
        TrophyName1.text = TrophyList1[TrophyLevel1].TrophyName1;
    }
    public void UpdateTrophy2()
    {
        TrophyLevel2 = PlayerPrefs.GetInt("Trophy2");
        TrophyName2.text = TrophyList2[TrophyLevel2].TrophyName2;
    }
    public void UpdateTrophy3()
    {
        TrophyLevel3 = PlayerPrefs.GetInt("Trophy3");
        TrophyName3.text = TrophyList3[TrophyLevel3].TrophyName3;
    }
    public void UpdateTrophy4()
    {
        TrophyLevel4 = PlayerPrefs.GetInt("Trophy4");
        TrophyName4.text = TrophyList4[TrophyLevel4].TrophyName4;
    }
    public void UpdateTrophy5()
    {
        TrophyLevel5 = PlayerPrefs.GetInt("Trophy5");
        TrophyName5.text = TrophyList5[TrophyLevel5].TrophyName5;
    }
    public void UpdateTrophy6()
    {
        TrophyLevel6 = PlayerPrefs.GetInt("Trophy6");
        TrophyName6.text = TrophyList6[TrophyLevel6].TrophyName6;
    }
    public void UpdateTrophy7()
    {
        TrophyLevel7 = PlayerPrefs.GetInt("Trophy7");
        TrophyName7.text = TrophyList7[TrophyLevel7].TrophyName7;
    }
    


    public void SaveAchiev1()//업적을 받는다면
    {
        AchievIndex1 = AchievLevel1;
        AchievIndex1++; //다음업적으로 업데이트
        if (AchievIndex1 == AchievList1.Count) AchievIndex1 = AchievList1.Count - 1;
        PlayerPrefs.SetInt("Achiev1", AchievIndex1);
        UpdateAchiev1();
    }
    public void SaveAchiev2()
    {
        AchievIndex2 = AchievLevel2;
        AchievIndex2++; 
        if (AchievIndex2 == AchievList2.Count) AchievIndex2 = AchievList2.Count - 1;
        PlayerPrefs.SetInt("Achiev2", AchievIndex2);
        UpdateAchiev2();
    }
    public void SaveAchiev3()
    {
        AchievIndex3 = AchievLevel3;
        AchievIndex3++;
        if (AchievIndex3 == AchievList3.Count) AchievIndex3 = AchievList3.Count - 1;
        PlayerPrefs.SetInt("Achiev3", AchievIndex3);
        UpdateAchiev3();
    }
    public void SaveAchiev4()
    {
        AchievIndex4 = AchievLevel4;
        AchievIndex4++;
        if (AchievIndex4 == AchievList4.Count) AchievIndex4 = AchievList4.Count - 1;
        PlayerPrefs.SetInt("Achiev4", AchievIndex4);
        UpdateAchiev4();
    }
    public void SaveAchiev5()
    {
        AchievIndex5 = AchievLevel5;
        AchievIndex5++;
        if (AchievIndex5 == AchievList5.Count) AchievIndex5 = AchievList5.Count - 1;
        PlayerPrefs.SetInt("Achiev5", AchievIndex5);
        UpdateAchiev5();
    }
    public void SaveAchiev6()
    {
        AchievIndex6 = AchievLevel6;
        AchievIndex6++;
        if (AchievIndex6 == AchievList6.Count) AchievIndex6 = AchievList6.Count - 1;
        PlayerPrefs.SetInt("Achiev6", AchievIndex6);
        UpdateAchiev6();
    }
    public void SaveAchiev7()
    {
        AchievIndex7 = AchievLevel7;
        AchievIndex7++;
        if (AchievIndex7 == AchievList7.Count) AchievIndex7 = AchievList7.Count - 1;
        PlayerPrefs.SetInt("Achiev7", AchievIndex7);
        UpdateAchiev7();
    }



    public void SaveTrophy1()//TrophyBack 텍스트변경
    {
        TrophyIndex1 = TrophyLevel1;
        TrophyIndex1++; //다음업적 텍스트로 변경
        if (TrophyIndex1 == TrophyList1.Count) TrophyIndex1 = TrophyList1.Count - 1;
        PlayerPrefs.SetInt("Trophy1", TrophyIndex1);
        UpdateTrophy1();
    }
    public void SaveTrophy2()
    {
        TrophyIndex2 = TrophyLevel2;
        TrophyIndex2++; 
        if (TrophyIndex2 == TrophyList2.Count) TrophyIndex2 = TrophyList2.Count - 1;
        PlayerPrefs.SetInt("Trophy2", TrophyIndex2);
        UpdateTrophy2();
    }
    public void SaveTrophy3()
    {
        TrophyIndex3 = TrophyLevel3;
        TrophyIndex3++;
        if (TrophyIndex3 == TrophyList3.Count) TrophyIndex3 = TrophyList3.Count - 1;
        PlayerPrefs.SetInt("Trophy3", TrophyIndex3);
        UpdateTrophy3();
    }
    public void SaveTrophy4()
    {
        TrophyIndex4 = TrophyLevel4;
        TrophyIndex4++;
        if (TrophyIndex4 == TrophyList4.Count) TrophyIndex4 = TrophyList4.Count - 1;
        PlayerPrefs.SetInt("Trophy4", TrophyIndex4);
        UpdateTrophy4();
    }
    public void SaveTrophy5()
    {
        TrophyIndex5 = TrophyLevel5;
        TrophyIndex5++;
        if (TrophyIndex5 == TrophyList5.Count) TrophyIndex5 = TrophyList5.Count - 1;
        PlayerPrefs.SetInt("Trophy5", TrophyIndex5);
        UpdateTrophy5();
    }
    public void SaveTrophy6()
    {
        TrophyIndex6 = TrophyLevel6;
        TrophyIndex6++;
        if (TrophyIndex6 == TrophyList6.Count) TrophyIndex6 = TrophyList6.Count - 1;
        PlayerPrefs.SetInt("Trophy6", TrophyIndex6);
        UpdateTrophy6();
    }
    public void SaveTrophy7()
    {
        TrophyIndex7 = TrophyLevel7;
        TrophyIndex7++;
        if (TrophyIndex7 == TrophyList7.Count) TrophyIndex7 = TrophyList7.Count - 1;
        PlayerPrefs.SetInt("Trophy7", TrophyIndex7);
        UpdateTrophy7();
    }


    [System.Serializable]
    public class AchievTheme1
    {
        public string AchievName1;
    }
    [System.Serializable]
    public class AchievTheme2
    {
        public string AchievName2;
    }
    [System.Serializable]
    public class AchievTheme3
    {
        public string AchievName3;
    }
    [System.Serializable]
    public class AchievTheme4
    {
        public string AchievName4;
    }
    [System.Serializable]
    public class AchievTheme5
    {
        public string AchievName5;
    }
    [System.Serializable]
    public class AchievTheme6
    {
        public string AchievName6;
    }
    [System.Serializable]
    public class AchievTheme7
    {
        public string AchievName7;
    }


    [System.Serializable]
    public class TrophyTheme1
    {
        public string TrophyName1;
    }
    [System.Serializable]
    public class TrophyTheme2
    {
        public string TrophyName2;
    }
    [System.Serializable]
    public class TrophyTheme3
    {
        public string TrophyName3;
    }
    [System.Serializable]
    public class TrophyTheme4
    {
        public string TrophyName4;
    }
    [System.Serializable]
    public class TrophyTheme5
    {
        public string TrophyName5;
    }
    [System.Serializable]
    public class TrophyTheme6
    {
        public string TrophyName6;
    }
    [System.Serializable]
    public class TrophyTheme7
    {
        public string TrophyName7;
    }


    // ------------------------------- 테마별 업적트로피, 트로피배경 설정 ----------------------------

    private int TrophyBackImageCheck1;
    private int TrophyBackImageCheck2;
    private int TrophyBackImageCheck3;
    private int TrophyBackImageCheck4;
    private int TrophyBackImageCheck5;
    private int TrophyBackImageCheck6;
    private int TrophyBackImageCheck7;
    private int TrophyImageCheck1;
    private int TrophyImageCheck2;
    private int TrophyImageCheck3;
    private int TrophyImageCheck4;
    private int TrophyImageCheck5;
    private int TrophyImageCheck6;
    private int TrophyImageCheck7;

    //1번째 업적 수락하면 트로피배경색 활성화
    public void OnTrophyBackImage1()
    {
        TrophyBackImageCheck1 = PlayerPrefs.GetInt("TrophyBackImage1");
        if (TrophyBackImageCheck1 == 1)//값 1이면 트로피배경색, 트로피 활성화 
        {
            GameObject.Find("Achiev1").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
            GameObject.Find("Achiev1").transform.Find("Image_Trophy").gameObject.SetActive(true);
        }
    }
    public void OnTrophyBackImage2()
    {
        TrophyBackImageCheck2 = PlayerPrefs.GetInt("TrophyBackImage2");
        if (TrophyBackImageCheck2 == 1)//값 1이면 트로피배경색, 트로피 활성화 
        {
            GameObject.Find("Achiev2").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
            GameObject.Find("Achiev2").transform.Find("Image_Trophy").gameObject.SetActive(true);
        }
    }
    public void OnTrophyBackImage3()
    {
        TrophyBackImageCheck3 = PlayerPrefs.GetInt("TrophyBackImage3");
        if (TrophyBackImageCheck3 == 1)//값 1이면 트로피배경색, 트로피 활성화 
        {
            GameObject.Find("Achiev3").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
            GameObject.Find("Achiev3").transform.Find("Image_Trophy").gameObject.SetActive(true);
        }
    }
    public void OnTrophyBackImage4()
    {
        TrophyBackImageCheck4 = PlayerPrefs.GetInt("TrophyBackImage4");
        if (TrophyBackImageCheck4 == 1)//값 1이면 트로피배경색, 트로피 활성화 
        {
            GameObject.Find("Achiev4").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
            GameObject.Find("Achiev4").transform.Find("Image_Trophy").gameObject.SetActive(true);
        }
    }
    public void OnTrophyBackImage5()
    {
        TrophyBackImageCheck5 = PlayerPrefs.GetInt("TrophyBackImage5");
        if (TrophyBackImageCheck5 == 1)//값 1이면 트로피배경색, 트로피 활성화 
        {
            GameObject.Find("Achiev5").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
            GameObject.Find("Achiev5").transform.Find("Image_Trophy").gameObject.SetActive(true);
        }
    }
    public void OnTrophyBackImage6()
    {
        TrophyBackImageCheck6 = PlayerPrefs.GetInt("TrophyBackImage6");
        if (TrophyBackImageCheck6 == 1)//값 1이면 트로피배경색, 트로피 활성화 
        {
            GameObject.Find("Achiev6").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
            GameObject.Find("Achiev6").transform.Find("Image_Trophy").gameObject.SetActive(true);
        }
    }
    public void OnTrophyBackImage7()
    {
        TrophyBackImageCheck7 = PlayerPrefs.GetInt("TrophyBackImage7");
        if (TrophyBackImageCheck7 == 1)//값 1이면 트로피배경색, 트로피 활성화 
        {
            GameObject.Find("Achiev7").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
            GameObject.Find("Achiev7").transform.Find("Image_Trophy").gameObject.SetActive(true);
        }
    }


    //트로피 애니메이션 시작 event : 트로피이미지 비활성화
    public void OffTrophyImage1()
    {
        PlayerPrefs.SetInt("TrophyImage1", 0);
        TrophyImageCheck1 = PlayerPrefs.GetInt("TrophyImage1");

        if (TrophyImageCheck1 == 0)
            GameObject.Find("Achiev1").transform.Find("Image_Trophy").gameObject.SetActive(false);
    }
    public void OffTrophyImage2()
    {
        PlayerPrefs.SetInt("TrophyImage2", 0);
        TrophyImageCheck2 = PlayerPrefs.GetInt("TrophyImage2");

        if (TrophyImageCheck2 == 0)
            GameObject.Find("Achiev2").transform.Find("Image_Trophy").gameObject.SetActive(false);
    }
    public void OffTrophyImage3()
    {
        PlayerPrefs.SetInt("TrophyImage3", 0);
        TrophyImageCheck3 = PlayerPrefs.GetInt("TrophyImage3");

        if (TrophyImageCheck3 == 0)
            GameObject.Find("Achiev3").transform.Find("Image_Trophy").gameObject.SetActive(false);
    }
    public void OffTrophyImage4()
    {
        PlayerPrefs.SetInt("TrophyImage4", 0);
        TrophyImageCheck4 = PlayerPrefs.GetInt("TrophyImage4");

        if (TrophyImageCheck4 == 0)
            GameObject.Find("Achiev4").transform.Find("Image_Trophy").gameObject.SetActive(false);
    }
    public void OffTrophyImage5()
    {
        PlayerPrefs.SetInt("TrophyImage5", 0);
        TrophyImageCheck5 = PlayerPrefs.GetInt("TrophyImage5");

        if (TrophyImageCheck5 == 0)
            GameObject.Find("Achiev5").transform.Find("Image_Trophy").gameObject.SetActive(false);
    }
    public void OffTrophyImage6()
    {
        PlayerPrefs.SetInt("TrophyImage6", 0);
        TrophyImageCheck6 = PlayerPrefs.GetInt("TrophyImage6");

        if (TrophyImageCheck6 == 0)
            GameObject.Find("Achiev6").transform.Find("Image_Trophy").gameObject.SetActive(false);
    }
    public void OffTrophyImage7()
    {
        PlayerPrefs.SetInt("TrophyImage7", 0);
        TrophyImageCheck7 = PlayerPrefs.GetInt("TrophyImage7");

        if (TrophyImageCheck7 == 0)
            GameObject.Find("Achiev7").transform.Find("Image_Trophy").gameObject.SetActive(false);
    }


    //트로피애니메이션 끝난후 Event : 트로피이미지 활성화
    public void OnTrophyImage1()
    {
        PlayerPrefs.SetInt("TrophyImage1", 1);
        TrophyImageCheck1 = PlayerPrefs.GetInt("TrophyImage1");

        if (TrophyImageCheck1 == 1)
            GameObject.Find("Achiev1").transform.Find("Image_Trophy").gameObject.SetActive(true);
    }
    public void OnTrophyImage2()
    {
        PlayerPrefs.SetInt("TrophyImage2", 1);
        TrophyImageCheck2 = PlayerPrefs.GetInt("TrophyImage2");

        if (TrophyImageCheck2 == 1)
            GameObject.Find("Achiev2").transform.Find("Image_Trophy").gameObject.SetActive(true);
    }
    public void OnTrophyImage3()
    {
        PlayerPrefs.SetInt("TrophyImage3", 1);
        TrophyImageCheck3 = PlayerPrefs.GetInt("TrophyImage3");

        if (TrophyImageCheck3 == 1)
            GameObject.Find("Achiev3").transform.Find("Image_Trophy").gameObject.SetActive(true);
    }
    public void OnTrophyImage4()
    {
        PlayerPrefs.SetInt("TrophyImage4", 1);
        TrophyImageCheck4 = PlayerPrefs.GetInt("TrophyImage4");

        if (TrophyImageCheck4 == 1)
            GameObject.Find("Achiev4").transform.Find("Image_Trophy").gameObject.SetActive(true);
    }
    public void OnTrophyImage5()
    {
        PlayerPrefs.SetInt("TrophyImage5", 1);
        TrophyImageCheck5 = PlayerPrefs.GetInt("TrophyImage5");

        if (TrophyImageCheck5 == 1)
            GameObject.Find("Achiev5").transform.Find("Image_Trophy").gameObject.SetActive(true);
    }
    public void OnTrophyImage6()
    {
        PlayerPrefs.SetInt("TrophyImage6", 1);
        TrophyImageCheck6 = PlayerPrefs.GetInt("TrophyImage6");

        if (TrophyImageCheck6 == 1)
            GameObject.Find("Achiev6").transform.Find("Image_Trophy").gameObject.SetActive(true);
    }
    public void OnTrophyImage7()
    {
        PlayerPrefs.SetInt("TrophyImage7", 1);
        TrophyImageCheck7 = PlayerPrefs.GetInt("TrophyImage7");

        if (TrophyImageCheck7 == 1)
            GameObject.Find("Achiev7").transform.Find("Image_Trophy").gameObject.SetActive(true);
    }


    // ------------------------------- 테마별 업적 받기 설정 ----------------------------

    // 업적받기화면 활성화
    public void TrophyBack1()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("ReceiveButton1").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Trophy").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText1").gameObject.SetActive(true);

        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.05f;
        anim.Play("TrophyBack", -1, 0);
        EffectSound.instance.BtnSound();
    }
    public void TrophyBack2()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("ReceiveButton2").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Trophy").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText2").gameObject.SetActive(true);
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.05f;
        anim.Play("TrophyBack", -1, 0);
        EffectSound.instance.BtnSound();
    }
    public void TrophyBack3()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("ReceiveButton3").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Trophy").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText3").gameObject.SetActive(true);
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.05f;
        anim.Play("TrophyBack", -1, 0);
        EffectSound.instance.BtnSound();
    }
    public void TrophyBack4()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("ReceiveButton4").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Trophy").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText4").gameObject.SetActive(true);
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.05f;
        anim.Play("TrophyBack", -1, 0);
        EffectSound.instance.BtnSound();
    }
    public void TrophyBack5()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("ReceiveButton5").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Trophy").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText5").gameObject.SetActive(true);
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.05f;
        anim.Play("TrophyBack", -1, 0);
        EffectSound.instance.BtnSound();
    }
    public void TrophyBack6()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("ReceiveButton6").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Trophy").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText6").gameObject.SetActive(true);
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.05f;
        anim.Play("TrophyBack", -1, 0);
        EffectSound.instance.BtnSound();
    }
    public void TrophyBack7()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("ReceiveButton7").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Trophy").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText7").gameObject.SetActive(true);
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.05f;
        anim.Play("TrophyBack", -1, 0);
        EffectSound.instance.BtnSound();
    }

    // 업적받기
    public void Receive1()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton1").gameObject.SetActive(false);
        GameObject.Find("Achiev1").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText1").gameObject.SetActive(false);

        PlayerPrefs.SetInt("TrophyBackImage1", 1);//1번째 업적 수락하면 트로피배경색 활성화 값 1 저장
        
        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.7f;
        anim.Play("Trophy1", -1, 0);

        EffectSound.instance.ReceiveSound();

        SliderTheme1.fillRect.anchorMin = new Vector2(0, 0);
        SliderTheme1.fillRect.anchorMax = new Vector2(0, 1);
        GameObject.Find("Achiev1").transform.Find("Text_Percent0").gameObject.SetActive(true);
        GameObject.Find("Achiev1").transform.Find("Text_Percent100").gameObject.SetActive(false);
        GameObject.Find("Achiev1").transform.Find("Button_Receive").gameObject.SetActive(false);
        PlayerPrefs.SetInt("AchievSlider1", 0);
    }
    public void Receive2()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton2").gameObject.SetActive(false);
        GameObject.Find("Achiev2").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText2").gameObject.SetActive(false);

        PlayerPrefs.SetInt("TrophyBackImage2", 1);//1번째 업적 수락하면 트로피배경색 활성화 값 1 저장

        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.7f;
        anim.Play("Trophy2", -1, 0);

        EffectSound.instance.ReceiveSound();

        SliderTheme2.fillRect.anchorMin = new Vector2(0, 0);
        SliderTheme2.fillRect.anchorMax = new Vector2(0, 1);
        GameObject.Find("Achiev2").transform.Find("Text_Percent0").gameObject.SetActive(true);
        GameObject.Find("Achiev2").transform.Find("Text_Percent100").gameObject.SetActive(false);
        GameObject.Find("Achiev2").transform.Find("Button_Receive").gameObject.SetActive(false);
        PlayerPrefs.SetInt("AchievSlider2", 0);
    }
    public void Receive3()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton3").gameObject.SetActive(false);
        GameObject.Find("Achiev3").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText3").gameObject.SetActive(false);

        PlayerPrefs.SetInt("TrophyBackImage3", 1);//1번째 업적 수락하면 트로피배경색 활성화 값 1 저장

        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.7f;
        anim.Play("Trophy3", -1, 0);

        EffectSound.instance.ReceiveSound();

        SliderTheme3.fillRect.anchorMin = new Vector2(0, 0);
        SliderTheme3.fillRect.anchorMax = new Vector2(0, 1);
        GameObject.Find("Achiev3").transform.Find("Text_Percent0").gameObject.SetActive(true);
        GameObject.Find("Achiev3").transform.Find("Text_Percent100").gameObject.SetActive(false);
        GameObject.Find("Achiev3").transform.Find("Button_Receive").gameObject.SetActive(false);
        PlayerPrefs.SetInt("AchievSlider3", 0);
    }
    public void Receive4()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton4").gameObject.SetActive(false);
        GameObject.Find("Achiev4").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText4").gameObject.SetActive(false);

        PlayerPrefs.SetInt("TrophyBackImage4", 1);//1번째 업적 수락하면 트로피배경색 활성화 값 1 저장

        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.7f;
        anim.Play("Trophy4", -1, 0);

        EffectSound.instance.ReceiveSound();

        SliderTheme4.fillRect.anchorMin = new Vector2(0, 0);
        SliderTheme4.fillRect.anchorMax = new Vector2(0, 1);
        GameObject.Find("Achiev4").transform.Find("Text_Percent0").gameObject.SetActive(true);
        GameObject.Find("Achiev4").transform.Find("Text_Percent100").gameObject.SetActive(false);
        GameObject.Find("Achiev4").transform.Find("Button_Receive").gameObject.SetActive(false);
        PlayerPrefs.SetInt("AchievSlider4", 0);
    }
    public void Receive5()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton5").gameObject.SetActive(false);
        GameObject.Find("Achiev5").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText5").gameObject.SetActive(false);

        PlayerPrefs.SetInt("TrophyBackImage5", 1);//1번째 업적 수락하면 트로피배경색 활성화 값 1 저장

        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.7f;
        anim.Play("Trophy5", -1, 0);

        EffectSound.instance.ReceiveSound();

        SliderTheme5.fillRect.anchorMin = new Vector2(0, 0);
        SliderTheme5.fillRect.anchorMax = new Vector2(0, 1);
        GameObject.Find("Achiev5").transform.Find("Text_Percent0").gameObject.SetActive(true);
        GameObject.Find("Achiev5").transform.Find("Text_Percent100").gameObject.SetActive(false);
        GameObject.Find("Achiev5").transform.Find("Button_Receive").gameObject.SetActive(false);
        PlayerPrefs.SetInt("AchievSlider5", 0);
    }
    public void Receive6()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton6").gameObject.SetActive(false);
        GameObject.Find("Achiev6").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText6").gameObject.SetActive(false);

        PlayerPrefs.SetInt("TrophyBackImage6", 1);//1번째 업적 수락하면 트로피배경색 활성화 값 1 저장

        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.7f;
        anim.Play("Trophy6", -1, 0);

        EffectSound.instance.ReceiveSound();

        SliderTheme6.fillRect.anchorMin = new Vector2(0, 0);
        SliderTheme6.fillRect.anchorMax = new Vector2(0, 1);
        GameObject.Find("Achiev6").transform.Find("Text_Percent0").gameObject.SetActive(true);
        GameObject.Find("Achiev6").transform.Find("Text_Percent100").gameObject.SetActive(false);
        GameObject.Find("Achiev6").transform.Find("Button_Receive").gameObject.SetActive(false);
        PlayerPrefs.SetInt("AchievSlider6", 0);
    }
    public void Receive7()
    {
        GameObject.Find("Panel").transform.Find("AchievBack").gameObject.SetActive(false);
        GameObject.Find("Panel").transform.Find("ReceiveButton7").gameObject.SetActive(false);
        GameObject.Find("Achiev7").transform.Find("Image_TrophyBack").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("AchievText7").gameObject.SetActive(false);

        PlayerPrefs.SetInt("TrophyBackImage7", 1);//1번째 업적 수락하면 트로피배경색 활성화 값 1 저장

        Animator anim = this.gameObject.GetComponent<Animator>();
        anim.speed = 0.7f;
        anim.Play("Trophy7", -1, 0);

        EffectSound.instance.ReceiveSound();

        SliderTheme7.fillRect.anchorMin = new Vector2(0, 0);
        SliderTheme7.fillRect.anchorMax = new Vector2(0, 1);
        GameObject.Find("Achiev7").transform.Find("Text_Percent0").gameObject.SetActive(true);
        GameObject.Find("Achiev7").transform.Find("Text_Percent100").gameObject.SetActive(false);
        GameObject.Find("Achiev7").transform.Find("Button_Receive").gameObject.SetActive(false);
        PlayerPrefs.SetInt("AchievSlider7", 0);
    }



}
