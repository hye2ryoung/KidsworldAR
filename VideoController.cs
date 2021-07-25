using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class VideoController : MonoBehaviour
{
    public RawImage mScreen = null;
    public VideoPlayer mVideoPlayer = null;
    private int levelToLoad;

    void Start()
    {
        
        PlayerPrefs.SetInt("OffGuide", 0); //앱 실행 시 메인화면 가이드 On 되도록 저장

        if (mScreen != null && mVideoPlayer != null)
        {
            // 비디오 준비 코루틴 호출
            StartCoroutine(PrepareVideo());
        }
    }

    protected IEnumerator PrepareVideo()
    {
        // 비디오 준비
        mVideoPlayer.Prepare();

        // 비디오가 준비되는 것을 기다림
        while (!mVideoPlayer.isPrepared)
        {
            yield return new WaitForSeconds(0.5f);
        }

        // VideoPlayer의 출력 texture를 RawImage의 texture로 설정
        mScreen.texture = mVideoPlayer.texture;
    }
    /*
    private void Update()
    {
        NextLevel(1);
    }

    public void NextLevel (int levelIndex)
    {
        levelToLoad = levelIndex;
    }*/

    public void VideoComplete()
    {
        int CameraPermissionCheck = PlayerPrefs.GetInt("Camera");
        if (CameraPermissionCheck == 1) SceneManager.LoadScene("LoadingScene");
        else SceneManager.LoadScene("PermissionCheck");
    }

}
