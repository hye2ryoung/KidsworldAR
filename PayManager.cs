using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PayManager : MonoBehaviour
{
    

    [SerializeField] private Text QuizText;
    [SerializeField] private List<QuizSelectObject> QuizList = new List<QuizSelectObject>();

    [SerializeField] private Text AnswerText1;
    [SerializeField] private Text AnswerText2;

  
    private void Start()
    {
        Reset();
    }

    // 결제방지창 열고 닫기 애니메이션
    public void PayButton() //테마 lockback - PayButton 
    {
        Animator anim = GameObject.Find("SettingController").gameObject.GetComponent<Animator>();
        anim.speed = 1;
        anim.Play("PayBox", -1, 0);
        Reset();
        EffectSound.instance.BtnSound();
    }

    public void ClosePayButton()
    {
        Animator anim = GameObject.Find("SettingController").gameObject.GetComponent<Animator>();
        anim.Play("PayClose", -1, 0);
        
        EffectSound.instance.BtnSound();
    }


    public void SetNum0()
    {
        EffectSound.instance.BtnSound();

        if ((AnswerText1.text == "") && (AnswerText2.text == ""))
        {
            AnswerText1.text = "0";
        }
            
        else if ((AnswerText1.text != "") && (AnswerText2.text == ""))
        {
            AnswerText2.text = "0";
            Invoke("SetAnswer", 0.3f);
        }
    }
    public void SetNum1()
    {
        EffectSound.instance.BtnSound();

        if ((AnswerText1.text == "") && (AnswerText2.text == ""))
        {
            AnswerText1.text = "1";
        }

        else if ((AnswerText1.text != "") && (AnswerText2.text == ""))
        {
            AnswerText2.text = "1";
            Invoke("SetAnswer", 0.3f);
        }
    }
    public void SetNum2()
    {
        EffectSound.instance.BtnSound();

        if ((AnswerText1.text == "") && (AnswerText2.text == ""))
        {
            AnswerText1.text = "2";
        }

        else if ((AnswerText1.text != "") && (AnswerText2.text == ""))
        {
            AnswerText2.text = "2";
            Invoke("SetAnswer", 0.3f);
        }
    }
    public void SetNum3()
    {
        EffectSound.instance.BtnSound();

        if ((AnswerText1.text == "") && (AnswerText2.text == ""))
        {
            AnswerText1.text = "3";
        }

        else if ((AnswerText1.text != "") && (AnswerText2.text == ""))
        {
            AnswerText2.text = "3";
            Invoke("SetAnswer", 0.3f);
        }
    }
    public void SetNum4()
    {
        EffectSound.instance.BtnSound();

        if ((AnswerText1.text == "") && (AnswerText2.text == ""))
        {
            AnswerText1.text = "4";
        }

        else if ((AnswerText1.text != "") && (AnswerText2.text == ""))
        {
            AnswerText2.text = "4";
            Invoke("SetAnswer", 0.3f);
        }
    }
    public void SetNum5()
    {
        EffectSound.instance.BtnSound();

        if ((AnswerText1.text == "") && (AnswerText2.text == ""))
        {
            AnswerText1.text = "5";
        }

        else if ((AnswerText1.text != "") && (AnswerText2.text == ""))
        {
            AnswerText2.text = "5";
            Invoke("SetAnswer", 0.3f);
        }
    }
    public void SetNum6()
    {
        EffectSound.instance.BtnSound();

        if ((AnswerText1.text == "") && (AnswerText2.text == ""))
        {
            AnswerText1.text = "6";
        }

        else if ((AnswerText1.text != "") && (AnswerText2.text == ""))
        {
            AnswerText2.text = "6";
            Invoke("SetAnswer", 0.3f);
        }
    }
    public void SetNum7()
    {
        EffectSound.instance.BtnSound();

        if ((AnswerText1.text == "") && (AnswerText2.text == ""))
        {
            AnswerText1.text = "7";
        }

        else if ((AnswerText1.text != "") && (AnswerText2.text == ""))
        {
            AnswerText2.text = "7";
            Invoke("SetAnswer", 0.3f);
        }
    }
    public void SetNum8()
    {
        EffectSound.instance.BtnSound();

        if ((AnswerText1.text == "") && (AnswerText2.text == ""))
        {
            AnswerText1.text = "8";
        }

        else if ((AnswerText1.text != "") && (AnswerText2.text == ""))
        {
            AnswerText2.text = "8";
            Invoke("SetAnswer", 0.3f);
        }
    }
    public void SetNum9()
    {
        EffectSound.instance.BtnSound();

        if ((AnswerText1.text == "") && (AnswerText2.text == ""))
        {
            AnswerText1.text = "9";
        }

        else if ((AnswerText1.text != "") && (AnswerText2.text == ""))
        {
            AnswerText2.text = "9";
            Invoke("SetAnswer", 0.3f);
        }
    }

    public void Reset()
    {
        AnswerText1.text = "";
        AnswerText2.text = "";
    }

    public void Delete()
    {
        EffectSound.instance.BtnSound();

        if ((AnswerText1.text == "") && (AnswerText2.text == ""))
        {
            return;
        }

        else if ((AnswerText1.text != "") && (AnswerText2.text != ""))
        {
            AnswerText2.text = "";
        }
        else if ((AnswerText1.text != "") && (AnswerText2.text == ""))
        {
            AnswerText1.text = "";
        }
    }

    public void PaymentTheme2()//테마2결제완료 
    {
        //if 결제완료

        //해당테마 자물쇠 해제,색깔 변경(제목,테마) 
        Button namebtn2 = GameObject.Find("Theme2").transform.Find("Name2").gameObject.GetComponent<Button>();
        ColorBlock namecb2 = namebtn2.colors;
        namecb2.normalColor = Color.white;
        namebtn2.colors = namecb2;

        Button btn2 = GameObject.Find("ScrollPanel").transform.Find("Theme2").gameObject.GetComponent<Button>();
        ColorBlock cb2 = btn2.colors;
        cb2.normalColor = Color.white;
        cb2.highlightedColor = Color.white;
        btn2.colors = cb2;

        GameObject.Find("Theme2").transform.Find("lockback").gameObject.SetActive(false);
        GameObject.Find("Theme2").transform.Find("charged").gameObject.SetActive(false);

        DoorEnter.OnDoorBack2();//문 빛나는 애니메이션 활성화
        //변경사항 저장 필요
    }
    /*
    public void PaymentTheme3()//테마3결제완료 
    {
        //if 결제완료

        //해당테마 자물쇠 해제,색깔 변경(제목,테마) 
        Button namebtn3 = GameObject.Find("Theme3").transform.Find("Name3").gameObject.GetComponent<Button>();
        ColorBlock namecb3 = namebtn3.colors;
        namecb3.normalColor = Color.white;
        namebtn3.colors = namecb3;

        Button btn3 = GameObject.Find("ScrollPanel").transform.Find("Theme3").gameObject.GetComponent<Button>();
        ColorBlock cb3 = btn3.colors;
        cb3.normalColor = Color.white;
        cb3.highlightedColor = Color.white;
        btn3.colors = cb3;

        GameObject.Find("Theme3").transform.Find("lockback").gameObject.SetActive(false);
        GameObject.Find("Theme3").transform.Find("charged").gameObject.SetActive(false);

        DoorEnter.OnDoorBack3();//문 빛나는 애니메이션 활성화
        //변경사항 저장 필요
    }
    public void PaymentTheme4()//테마4결제완료 
    {
        //if 결제완료

        //해당테마 자물쇠 해제,색깔 변경(제목,테마) 
        Button namebtn4 = GameObject.Find("Theme4").transform.Find("Name4").gameObject.GetComponent<Button>();
        ColorBlock namecb4 = namebtn4.colors;
        namecb4.normalColor = Color.white;
        namebtn4.colors = namecb4;

        Button btn4 = GameObject.Find("ScrollPanel").transform.Find("Theme4").gameObject.GetComponent<Button>();
        ColorBlock cb4 = btn4.colors;
        cb4.normalColor = Color.white;
        cb4.highlightedColor = Color.white;
        btn4.colors = cb4;

        GameObject.Find("Theme4").transform.Find("lockback").gameObject.SetActive(false);
        GameObject.Find("Theme4").transform.Find("charged").gameObject.SetActive(false);

        DoorEnter.OnDoorBack4();//문 빛나는 애니메이션 활성화
        //변경사항 저장 필요 
    }*/
    public void PaymentTheme5()//테마5결제완료 
    {
        //if 결제완료

        //해당테마 자물쇠 해제,색깔 변경(제목,테마) 
        Button namebtn5 = GameObject.Find("Theme5").transform.Find("Name5").gameObject.GetComponent<Button>();
        ColorBlock namecb5 = namebtn5.colors;
        namecb5.normalColor = Color.white;
        namebtn5.colors = namecb5;

        Button btn5 = GameObject.Find("ScrollPanel").transform.Find("Theme5").gameObject.GetComponent<Button>();
        ColorBlock cb5 = btn5.colors;
        cb5.normalColor = Color.white;
        cb5.highlightedColor = Color.white;
        btn5.colors = cb5;

        GameObject.Find("Theme5").transform.Find("lockback").gameObject.SetActive(false);
        GameObject.Find("Theme5").transform.Find("charged").gameObject.SetActive(false);

        DoorEnter.OnDoorBack5();//문 빛나는 애니메이션 활성화
        //변경사항 저장 필요 
    }
    /*
    public void PaymentTheme6()//테마6결제완료 
    {
        //if 결제완료

        //해당테마 자물쇠 해제,색깔 변경(제목,테마) 
        Button namebtn6 = GameObject.Find("Theme6").transform.Find("Name6").gameObject.GetComponent<Button>();
        ColorBlock namecb6 = namebtn6.colors;
        namecb6.normalColor = Color.white;
        namebtn6.colors = namecb6;

        Button btn6 = GameObject.Find("ScrollPanel").transform.Find("Theme6").gameObject.GetComponent<Button>();
        ColorBlock cb6 = btn6.colors;
        cb6.normalColor = Color.white;
        cb6.highlightedColor = Color.white;
        btn6.colors = cb6;

        GameObject.Find("Theme6").transform.Find("lockback").gameObject.SetActive(false);
        GameObject.Find("Theme6").transform.Find("charged").gameObject.SetActive(false);
        
        DoorEnter.OnDoorBack6();//문 빛나는 애니메이션 활성화
        //변경사항 저장 필요 
    }
    public void PaymentTheme7()//테마7결제완료 
    {
        //if 결제완료

        //해당테마 자물쇠 해제,색깔 변경(제목,테마) 
        Button namebtn7 = GameObject.Find("Theme7").transform.Find("Name7").gameObject.GetComponent<Button>();
        ColorBlock namecb7 = namebtn7.colors;
        namecb7.normalColor = Color.white;
        namebtn7.colors = namecb7;

        Button btn7 = GameObject.Find("ScrollPanel").transform.Find("Theme7").gameObject.GetComponent<Button>();
        ColorBlock cb7 = btn7.colors;
        cb7.normalColor = Color.white;
        cb7.highlightedColor = Color.white;
        btn7.colors = cb7;

        GameObject.Find("Theme7").transform.Find("lockback").gameObject.SetActive(false);
        GameObject.Find("Theme7").transform.Find("charged").gameObject.SetActive(false);
        
        DoorEnter.OnDoorBack7();//문 빛나는 애니메이션 활성화
        //변경사항 저장 필요 
    }*/


    public void SetAnswer()
    {
        string num1 = AnswerText1.text;
        string num2 = AnswerText2.text;
        string CorrectNum = num1 + num2;

        if (QuizText.text == "2  X  5  =  ?")
        {
            if (CorrectNum == "10")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
             }
        }
        if (QuizText.text == "2  X  6  =  ?")
        {
            if (CorrectNum == "12")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "2  X  7  =  ?")
        {
            if (CorrectNum == "14")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "2  X  8  =  ?")
        {
            if (CorrectNum == "16")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "2  X  9  =  ?")
        {
            if (CorrectNum == "18")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "3  X  4  =  ?")
        {
            if (CorrectNum == "12")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "3  X  5  =  ?")
        {
            if (CorrectNum == "15")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "3  X  6  =  ?")
        {
            if (CorrectNum == "18")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "3  X  7  =  ?")
        {
            if (CorrectNum == "21")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "3  X  8  =  ?")
        {
            if (CorrectNum == "24")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "3  X  9  =  ?")
        {
            if (CorrectNum == "27")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "4  X  3  =  ?")
        {
            if (CorrectNum == "12")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "4  X  4  =  ?")
        {
            if (CorrectNum == "16")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "4  X  5  =  ?")
        {
            if (CorrectNum == "20")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "4  X  6  =  ?")
        {
            if (CorrectNum == "24")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "4  X  7  =  ?")
        {
            if (CorrectNum == "28")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "4  X  8  =  ?")
        {
            if (CorrectNum == "32")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "4  X  9  =  ?")
        {
            if (CorrectNum == "36")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "5  X  2  =  ?")
        {
            if (CorrectNum == "10")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "5  X  3  =  ?")
        {
            if (CorrectNum == "15")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "5  X  4  =  ?")
        {
            if (CorrectNum == "20")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "5  X  5  =  ?")
        {
            if (CorrectNum == "25")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "5  X  6  =  ?")
        {
            if (CorrectNum == "30")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "5  X  7  =  ?")
        {
            if (CorrectNum == "35")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "5  X  8  =  ?")
        {
            if (CorrectNum == "40")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "5  X  9  =  ?")
        {
            if (CorrectNum == "45")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "6  X  2  =  ?")
        {
            if (CorrectNum == "12")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "6  X  3  =  ?")
        {
            if (CorrectNum == "18")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "6  X  4  =  ?")
        {
            if (CorrectNum == "24")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "6  X  5  =  ?")
        {
            if (CorrectNum == "30")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "6  X  6  =  ?")
        {
            if (CorrectNum == "36")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "6  X  7  =  ?")
        {
            if (CorrectNum == "42")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "6  X  8  =  ?")
        {
            if (CorrectNum == "48")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "6  X  9  =  ?")
        {
            if (CorrectNum == "54")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "7  X  2  =  ?")
        {
            if (CorrectNum == "14")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "7  X  3  =  ?")
        {
            if (CorrectNum == "21")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "7  X  4  =  ?")
        {
            if (CorrectNum == "28")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "7  X  5  =  ?")
        {
            if (CorrectNum == "35")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "7  X  6  =  ?")
        {
            if (CorrectNum == "42")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "7  X  7  =  ?")
        {
            if (CorrectNum == "49")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "7  X  8  =  ?")
        {
            if (CorrectNum == "56")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "7  X  9  =  ?")
        {
            if (CorrectNum == "63")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "8  X  2  =  ?")
        {
            if (CorrectNum == "16")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "8  X  3  =  ?")
        {
            if (CorrectNum == "24")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "8  X  4  =  ?")
        {
            if (CorrectNum == "32")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "8  X  5  =  ?")
        {
            if (CorrectNum == "40")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "8  X  6  =  ?")
        {
            if (CorrectNum == "48")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "8  X  7  =  ?")
        {
            if (CorrectNum == "56")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "8  X  8  =  ?")
        {
            if (CorrectNum == "64")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "8  X  9  =  ?")
        {
            if (CorrectNum == "72")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "9  X  2  =  ?")
        {
            if (CorrectNum == "18")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "9  X  3  =  ?")
        {
            if (CorrectNum == "27")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "9  X  4  =  ?")
        {
            if (CorrectNum == "36")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "9  X  5  =  ?")
        {
            if (CorrectNum == "45")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "9  X  6  =  ?")
        {
            if (CorrectNum == "54")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "9  X  7  =  ?")
        {
            if (CorrectNum == "63")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "9  X  8  =  ?")
        {
            if (CorrectNum == "72")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if (QuizText.text == "9  X  9  =  ?")
        {
            if (CorrectNum == "81")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
                EffectSound.instance.ReceiveSound();
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }

    }
    

    public void UpdateQuiz()
    {
        int n;
        n = Random.Range(0, QuizList.Count);
        QuizText.text = QuizList[n].QuizName;
    }
}




[System.Serializable]
public class QuizSelectObject
{
    public string QuizName;
}
