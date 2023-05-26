using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject Cone;
    private RankingSystem rankingSystem;
    public int randomNumber;
    
    void Start()
    {
        rankingSystem = GameObject.Find("rankingSystem").GetComponent<RankingSystem>();
        randomNumber = Random.Range(0, 3);//게임시작시 랜덤으로 0 or 1 or 2를 부여받음
    }

    void Update()
    {
        if ((randomNumber == 1 || randomNumber == 2 )&& rankingSystem.ObstacleCollision)//랜덤부여 번호가 1or 2이고, 플레이어가 장애물생성라인에 충돌하면
        {
            Debug.Log("장애물이 생성되었어요");
            Instantiate(Cone, transform.position, Quaternion.identity);
        }
    }
}
