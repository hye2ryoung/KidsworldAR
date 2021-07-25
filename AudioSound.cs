using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSound : MonoBehaviour
{
    GameObject BackGroundSound;
    public AudioSource backmusic;
    public AudioClip audioClip;

    
    private int BgmIsOnCheck;
    
    
    public Toggle BgmToggle;


    private void Awake()
    {
        
        BackGroundSound = GameObject.Find("BackGroundSound");
        backmusic = BackGroundSound.GetComponent<AudioSource>(); //배경음악 저장해둠
        backmusic.clip = audioClip;

        if (!backmusic.isPlaying)
        {
            backmusic.Play();
            DontDestroyOnLoad(BackGroundSound);
        }else if (backmusic.isPlaying)
        {
            DontDestroyOnLoad(BackGroundSound);
        }

        BgmIsOnCheck = PlayerPrefs.GetInt("isOnBgm");
        

        if (BgmIsOnCheck == 1) BgmToggle.isOn = true;
        else if (BgmIsOnCheck == 0) BgmToggle.isOn = false;



    }


    public void BgmToggleMute()
    {

        if (BgmToggle.isOn == true)
        {
            BackGroundSound = GameObject.Find("BackGroundSound");
            backmusic = BackGroundSound.GetComponent<AudioSource>(); //배경음악 저장해둠
            backmusic.clip = audioClip;
            backmusic.Pause();
            
            PlayerPrefs.SetInt("isOnBgm", 1);

        }
        else if (BgmToggle.isOn == false)
        {
            BackGroundSound = GameObject.Find("BackGroundSound");
            backmusic = BackGroundSound.GetComponent<AudioSource>(); //배경음악 저장해둠
            backmusic.clip = audioClip;

            backmusic.Play();
            
            PlayerPrefs.SetInt("isOnBgm", 0);

            
        }
    }



    
}
