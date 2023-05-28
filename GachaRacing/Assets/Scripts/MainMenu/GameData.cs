using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameData : MonoBehaviour
{
    public int totalPeople;
    public int pickPeople;
    public bool rilla;
    public bool tung;
    public bool sakana;
    public bool boool;
    public bool hunter;
    public bool bbick;
    public bool horullus;
    public bool snicki;
    public List<string> selectedCharacters;
    
    public float RacingTime;
    public bool isStart;
    public bool isEnd;

    private void Update()
    {
        RacingTime += Time.deltaTime;
    }
    
    public float GetTime()
    {
        return RacingTime;
    }

    public void ResetTime()
    {
        RacingTime = 0f;
    }
}