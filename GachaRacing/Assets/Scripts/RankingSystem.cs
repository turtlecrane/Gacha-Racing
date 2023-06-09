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

    public GameObject UltiEventComent;
    private bool UltiFlag;
    public bool isUlti = false;
    public bool UltimateTime;
    public float UltiTime;
    private GameData gameDataScript;
    
    public GameObject FastEventComent;
    private bool FastFlag = false;
    public bool FastEventTime;
    public float FastTime;

    public GameObject ObstacleEventComent;
    public bool ObstacleCollision;
    public float ObstacleTime;
    public bool ObstacleCameraTime;
    private bool ObstacleFlag = false;
    
    public bool EndLineCollision;

    public int FinishCount;
    public bool GameFinish;
    public bool OpenResult = false;
    public GameObject Result;
    public PlayerStatus[] topPlayers;//최종 우승자들이 저장될 예정

    private void Start()
    {
        gameDataScript = GameObject.Find("GameData").GetComponent<GameData>();
        UltiTime = 0f;
    }

    //Update()
    void FixedUpdate()
    {
        FinishCount = 0;
        // 경과 시간 업데이트
        float currentTime = gameDataScript.RacingTime;
        if (currentTime >= 19f)//19초 후에 출발!
        {
            racingStart = true;
            gameDataScript.isStart = true;
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
                if (!UltiFlag)
                {
                    GameObjSetActive(UltiEventComent);
                    StartCoroutine(DelayedFunction(2.5f, UltiEventComent));//2초뒤에 이벤트효과 꺼짐
                    UltiFlag = true;
                }
                if (UltiTime >= 6f && UltimateTime)//궁극기 시간이 끝나면
                {
                    UltimateTime = false;//궁극기가 끝났다고 알림
                    //UltiTime = 0f;
                }
            }
            if (players[i].isEndLine)
            {
                EndLineCollision = true;//결승전에 거의 다 왔으면 카메라 위치를 바꾸기 위한 플래그
            }
            if (players[i].isFinished)//결승점에 몇명이 들어왔는지 체킹
            {
                FinishCount++; 
            }
        }
        if (players[0].isFastTime)//1등이 순풍이벤트라인에 충돌하면 순풍이벤트 시작
        {
            FastTime += Time.deltaTime;
            FastEventTime = true;
            if (!FastFlag)
            {
                GameObjSetActive(FastEventComent);
                StartCoroutine(DelayedFunction(2.5f, FastEventComent));//2초뒤에 이벤트효과 꺼짐
                FastFlag = true;
            }
            if (FastTime >= 4.5f)//카메라 시점 지속시간
            {
                FastEventTime = false;
            }
        }
        if (players[0].isObstacleLine)//1등이 장애물 이벤트 라인에 충돌되면 장애물 이벤트 시작
        {
            ObstacleTime += Time.deltaTime;
            ObstacleCameraTime = true;
            ObstacleCollision = true;
            if (!ObstacleFlag)
            {
                GameObjSetActive(ObstacleEventComent);
                StartCoroutine(DelayedFunction(2.5f, ObstacleEventComent));//2초뒤에 이벤트효과 꺼짐
                ObstacleFlag = true;
            }
            else 
            {
                ObstacleCollision = false;
            }
            if (ObstacleTime >= 6f)//카메라 시점 지속시간
            {
                ObstacleCameraTime = false;
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

        if (FinishCount >= 1)
        {
            GameFinish = true;
        }
        if (FinishCount == gameDataScript.pickPeople)
        {
            OpenResult = true;
            gameDataScript.isEnd = true;
            Time.timeScale = 0f;//화면 정지
            Result.SetActive(true);
            topPlayers = new PlayerStatus[gameDataScript.pickPeople];
            for (int i = 0; i < gameDataScript.pickPeople; i++)
            {
                topPlayers[i] = players[i];
            }
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
                //Debug.Log(players[i].gameObject.name + "궁극기 발동중");
                return players[i].transform.position;
            }
        }
        return Vector3.zero;
    }
    
    public void GameObjSetActive(GameObject obj)
    {
        obj.SetActive(true);
    }
    IEnumerator DelayedFunction(float delay, GameObject obj)
    {
        yield return new WaitForSeconds(delay);
        GameObjFalseActive(obj);
    }
    public void GameObjFalseActive(GameObject obj)
    {
        obj.SetActive(false);
    }
    
}
