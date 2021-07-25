using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectSound : MonoBehaviour
{
    GameObject EffectSounds;

    public AudioSource effectmusic;

    public AudioClip moveClip;
    public AudioClip btnClip;
    public AudioClip achievClip;
    public AudioClip enterClip;



    public AudioClip TestClip;



    private int SoundIsOnCheck;
    public Toggle SoundToggle;


    public static EffectSound instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        EffectSounds = GameObject.Find("EffectSounds");
        effectmusic = EffectSounds.GetComponent<AudioSource>();

        SoundIsOnCheck = PlayerPrefs.GetInt("isOnSound");

        if (SoundIsOnCheck == 1) SoundToggle.isOn = true;
        else if (SoundIsOnCheck == 0) SoundToggle.isOn = false;
    }




    public void Test()
    {
        effectmusic.PlayOneShot(TestClip);
    }




    public void Move()
    {
        effectmusic.PlayOneShot(moveClip);
    }

    public void BtnSound()
    {
        effectmusic.PlayOneShot(btnClip);
    }

    public void ReceiveSound()
    {
        effectmusic.PlayOneShot(achievClip);
    }

    public void EnterSound()
    {
        effectmusic.PlayOneShot(enterClip);
    }

    public void SoundToggleMute()
    {

        if (SoundToggle.isOn == true)
        {
            EffectSounds = GameObject.Find("EffectSounds");
            effectmusic = EffectSounds.GetComponent<AudioSource>();
            effectmusic.mute = true;
            PlayerPrefs.SetInt("isOnSound", 1);
        }
        else if (SoundToggle.isOn == false)
        {
            EffectSounds = GameObject.Find("EffectSounds");
            effectmusic = EffectSounds.GetComponent<AudioSource>();
            effectmusic.mute = false;
            PlayerPrefs.SetInt("isOnSound", 0);
        }
    }
}

        
    
