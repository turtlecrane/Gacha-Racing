using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunSound : MonoBehaviour
{
    public AudioSource audioSource; 
    public AudioClip RunClips;
    public GameData gameData;
    private bool isRunPlayed = false;
    void Start()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
    }

    void Update()
    {
        if (gameData.isStart && !isRunPlayed)
        {
            audioSource.clip = RunClips;
            audioSource.Play();
            isRunPlayed = true;
        }

        if (gameData.isStart && gameData.isEnd)
        {
            audioSource.clip = null;
        }
        
    }
}
