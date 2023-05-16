using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class RankingSystem : MonoBehaviour
{
    public PlayerStatus[] players;
    public TextMeshProUGUI ranking;
    private string _1st;
    private string _2nd;
    private string _3rd;
    public bool racingStart;
    public bool isUlti = false;
    public bool UltimateTime;
    public float UltiTime;
    private GameData gameDataScript;
    
    private void Start()
    {
        gameDataScript = GameObject.Find("GameData").GetComponent<GameData>();
        UltiTime = 0f;
    }

    void Update()
    {
        // 경과 시간 업데이트
        float currentTime = gameDataScript.RacingTime;
        if (currentTime >= 20f)
        {
            racingStart = true;
        }
        
        players = FindObjectsOfType<PlayerStatus>();
        
        // players 배열을 오브젝트의 Z 위치에 따라 정렬
        System.Array.Sort(players, (p1, p2) => p2.transform.position.z.CompareTo(p1.transform.position.z));

        // 각각의 player에 대해 등수 설정
        for (int i = 0; i < players.Length; i++)
        {
            int rank = i + 1;
            string playerName = players[i].gameObject.name.Replace("(Clone)", "");
            
            if (rank == 1)
            {
                _1st = playerName;
            }
            else if (rank == 2)
            {
                _2nd = playerName;
            }
            else if (rank == 3)
            {
                _3rd = playerName;
            }

            if (players.Length == 1)
            {
                ranking.text = "1등 : " + _1st + " !";
            }
            else if (players.Length == 2)
            {
                ranking.text = "1등 : " + _1st + " !\n2등 : " + _2nd + " !";
            }
            else if (players.Length >= 3)
            {
                ranking.text = "1등 : " + _1st + " !\n2등 : " + _2nd + " !\n3등 : " + _3rd + " !";
            }
            
            if (players[i].isUltiTime)
            {
                UltiTime += Time.deltaTime;
                //궁극기 발동중인 스크립트 찾아짐
                UltimateTime = true;
                if (UltiTime >= 7.5f && UltimateTime)
                {
                    UltimateTime = false;
                    //UltiTime = 0f;
                }
            }
        }

        if (!isUlti)
        {
            // players 배열에서 하나의 플레이어를 무작위로 선택하여 haveUltimate을 true로 설정
            if (players.Length > 0)
            {
                int randomIndex = Random.Range(0, players.Length);
                for (int i = 0; i < players.Length; i++)
                {
                    players[i].haveUltimate = (i == randomIndex);
                }
            }
            isUlti = true;
        }
    }
    
    public Vector3 GetFirstPlayerPosition()
    {
        if (players.Length > 0)
        {
            return players[0].transform.position;
        }

        return Vector3.zero;
    }
    
    public Vector3 GetSecondPlayerPosition()
    {
        if (players.Length > 1)
        {
            return players[1].transform.position;
        }

        return Vector3.zero;
    }
    
    public Vector3 GetThirdPlayerPosition()
    {
        if (players.Length > 2)
        {
            return players[2].transform.position;
        }

        return Vector3.zero;
    }
    
    public Vector3 GetUltimatePosition()
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].isUltiTime)
            {
                //궁극기 발동중인 스크립트 찾아짐
                Debug.Log(players[i].gameObject.name + "궁극기 발동중");
                return players[i].transform.position;
            }
        }
        return Vector3.zero;
    }
}
