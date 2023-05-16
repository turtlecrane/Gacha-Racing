using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWalking : MonoBehaviour
{
    public RankingSystem rankingSystem;
    public Animator cameraAnimator;
    
    private float timer = 0f;
    private float interval = 5f;

    public int randomNumber;
    
    void Update()
    {
        timer += Time.deltaTime;
        
        if (rankingSystem.racingStart)//레이싱 시작 하면
        {
            cameraAnimator.enabled = false; // 애니메이션 중지
            //Debug.Log("1등의 위치는? : " + rankingSystem.GetFirstPlayerPosition());
            Vector3 firstPlayerPosition = rankingSystem.GetFirstPlayerPosition();
            Vector3 secondPlayerPosition = rankingSystem.GetSecondPlayerPosition();
            Vector3 thirdPlayerPosition = rankingSystem.GetThirdPlayerPosition();
            Vector3 UltiPlayerPosition = rankingSystem.GetUltimatePosition();
            transform.rotation = Quaternion.Euler(25f, 180f, 0f); // 카메라를 180도 회전시킴

            if (rankingSystem.players.Length == 1)
            {
                randomNumber = 1;
            }
            else if (rankingSystem.players.Length == 2)
            {
                if (timer >= interval)
                {
                    randomNumber = Random.Range(1, 3);
                    timer = 0f;
                }
            }
            else if (rankingSystem.players.Length >= 3)
            {
                if (timer >= interval)
                {
                    randomNumber = Random.Range(1, 4);
                    timer = 0f;
                }
            }
            

            if (randomNumber == 1)
            {
                transform.position = new Vector3(firstPlayerPosition.x, firstPlayerPosition.y + 1.5f, firstPlayerPosition.z + 3f);
            }
            else if (randomNumber == 2)
            {
                transform.position = new Vector3(secondPlayerPosition.x, secondPlayerPosition.y + 1.5f, secondPlayerPosition.z + 3f);
            }
            else if (randomNumber == 3)
            {
                transform.position = new Vector3(thirdPlayerPosition.x, thirdPlayerPosition.y + 1.5f, thirdPlayerPosition.z + 3f);
            }
            if ((randomNumber == 1 || randomNumber == 2 || randomNumber == 3) && rankingSystem.UltimateTime)
            {
                transform.position = new Vector3(UltiPlayerPosition.x, UltiPlayerPosition.y + 1.5f, UltiPlayerPosition.z + 3f);
            }

            
        }
    }
}
