using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSound : MonoBehaviour
{
    public AudioSource audioSource; 
    public AudioClip BangClips;
    public GameData gameData;
    private bool isBangPlayed = false;
    
    void Start()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
    }
    
    void Update()
    {
        if (gameData.isStart && !isBangPlayed)
        {
            audioSource.clip = BangClips;
            audioSource.Play();
            isBangPlayed = true;
        }
    }
}
