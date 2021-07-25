using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PayTheme2 : MonoBehaviour
{
    [SerializeField] private Text QuizName;
    [SerializeField] private List<QuizSelectObject> QuizList = new List<QuizSelectObject>();

    [SerializeField] private Text AnswerText1;
    [SerializeField] private Text AnswerText2;

    [System.Serializable]
    public class QuizSelectObject
    {
        public string QuizText;
    }

    private void Start()
    {
        Reset();
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
        //변경사항 저장
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


    public void SetAnswer()
    {
        string num1 = AnswerText1.text;
        string num2 = AnswerText2.text;
        string CorrectNum = num1 + num2;

        if (QuizName.text == "2  X  5  =  ?")
        {
            if ((CorrectNum == "10") && (this.gameObject.name == "Theme2"))
            {
                //결제창으로이동
                Animator anim = GameObject.Find("SettingController").gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = GameObject.Find("SettingController").gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "2  X  6  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "12")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "2  X  7  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "14")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "2  X  8  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "16")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "2  X  9  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "18")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "3  X  4  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "12")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "3  X  5  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "15")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "3  X  6  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "18")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "3  X  7  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "21")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "3  X  8  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "24")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "3  X  9  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "27")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "4  X  3  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "12")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "4  X  4  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "16")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "4  X  5  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "20")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "4  X  6  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "24")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "4  X  7  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "28")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "4  X  8  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "32")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "4  X  9  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "36")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "5  X  2  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "10")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "5  X  3  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "15")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "5  X  4  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "20")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "5  X  5  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "25")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "5  X  6  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "30")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "5  X  7  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "35")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "5  X  8  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "40")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "5  X  9  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "45")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "6  X  2  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "12")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "6  X  3  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "18")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "6  X  4  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "24")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "6  X  5  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "30")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "6  X  6  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "36")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "6  X  7  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "42")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "6  X  8  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "48")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "6  X  9  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "54")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "7  X  2  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "14")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "7  X  3  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "21")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "7  X  4  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "28")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "7  X  5  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "35")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "7  X  6  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "42")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "7  X  7  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "49")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "7  X  8  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "56")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "7  X  9  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "63")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "8  X  2  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "16")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "8  X  3  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "24")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "8  X  4  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "32")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "8  X  5  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "40")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "8  X  6  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "48")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "8  X  7  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "56")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "8  X  8  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "64")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "8  X  9  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "72")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "9  X  2  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "18")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "9  X  3  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "27")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "9  X  4  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "36")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "9  X  5  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "45")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "9  X  6  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "54")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "9  X  7  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "63")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "9  X  8  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "72")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
            }
            else
            {
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("WrongAnswer", -1, 0);
                Reset();
            }
        }
        if ((QuizName.text == "9  X  9  =  ?") && (this.gameObject.name == "Theme2"))
        {
            if (CorrectNum == "81")
            {
                //결제창으로이동
                Animator anim = this.gameObject.GetComponent<Animator>();
                anim.Play("PayClose", -1, 0);
                Invoke("Reset", 1f);
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
        QuizName.text = QuizList[n].QuizText;
    }
}





