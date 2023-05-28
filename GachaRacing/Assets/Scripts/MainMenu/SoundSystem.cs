using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundSystem : MonoBehaviour
{
    public AudioClip[] audioClips; // 오디오 클립 배열
    public AudioSource audioSource; // 오디오 소스
    public GameData gameData; // GameData 오브젝트의 GameData 스크립트
    private bool isClipNull = false; // isStart가 true일 때 오디오 소스의 클립을 null로 바꿀지 여부
    private bool isClip2Played = false; // isStart와 isEnd가 모두 true일 때, 2번째 클립을 재생했는지 여부
    private bool isMain = true;
    private bool isPlay = false;
    private bool isEnd = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); // 현재 오브젝트의 오디오 소스를 가져옵니다.
    }

    private void Update()
    {
        ManageAudio();
    }

    private void ManageAudio()
    {
        if (!isClipNull && SceneManager.GetActiveScene().name == "MainMenu" && isMain)
        {
            audioSource.clip = audioClips[0];
            audioSource.Play();
            isMain = false;
            isClipNull = false;
            isClip2Played = false;
        }
        else if (!isClipNull && SceneManager.GetActiveScene().name == "PlayRacing" && !isPlay)
        {
            audioSource.clip = audioClips[1];
            audioSource.Play();
            isPlay = true;
            isClipNull = false;
            isClip2Played = false;
        }

        if (isClipNull && gameData != null && gameData.isStart && isPlay)
        {
            audioSource.clip = null;
            isPlay = false;
            isClipNull = true;
        }

        if (!isClip2Played && gameData != null && gameData.isStart && gameData.isEnd && !isEnd)
        {
            audioSource.clip = audioClips[2];
            audioSource.Play();
            isEnd = true;
            isClipNull = false;
            isClip2Played = true;
        }
    }
}