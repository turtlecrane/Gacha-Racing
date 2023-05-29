using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatus : MonoBehaviour
{
    public float currentTime;
    public float moveSpeed;
    public float UltiTime;
    public GameObject UltiEffect;
    public bool haveUltimate;
    private Rigidbody rb; 
    private float changeSpeedInterval = 4f;  // 속도 변경 간격
    private float nextSpeedChangeTime;  // 다음 속도 변경 시간
    public bool isUltiTime;
    private GameData gameDataScript;
    
    private float FastSpeedCorrection; //순풍속도 증가값
    private bool FastTimeFlag = false;//속도 증가 중복 방지
    public bool isFastTime; //순풍이벤트중인가?
    private float FastTime;
    
    public float ObstacleSpeedCorrection; //장애물속도 감속값
    private bool ObstacleFlag = false;
    public bool isObstacleLine;
    public bool isObstacle;
    private float ObstacleTime;

    public bool isEndLine;
    public bool isFinished;
    
    
    private void Start()
    {
        ObstacleSpeedCorrection = Random.Range(5f, 6f);//장애물속도 감속값
        FastSpeedCorrection = Random.Range(2f, 4f);//순풍 이벤트 보정값
        gameDataScript = GameObject.Find("GameData").GetComponent<GameData>();
        isUltiTime = false;
        UltiTime = 0f;
        Debug.Log("현재 속도 변경 간격 : " + changeSpeedInterval + " 초");
        rb = GetComponent<Rigidbody>();  // Rigidbody 컴포넌트 가져오기
        moveSpeed = Random.Range(7f, 9f);
        nextSpeedChangeTime = Time.time + changeSpeedInterval;  // 다음 속도 변경 시간 초기화
    }

    void Update()
    {
        // 경과 시간 업데이트
        currentTime = gameDataScript.RacingTime;
    
        if (!isUltiTime && !isFastTime && !isObstacle && !isFinished)
        {
            // 일정 간격으로 속도 변경
            if (currentTime >= nextSpeedChangeTime)
            {
                moveSpeed = Random.Range(8f, 10f);
                nextSpeedChangeTime = currentTime + changeSpeedInterval;
            }
        }
        else if (isUltiTime)//필살기 발동시
        {
            //Debug.Log(gameObject.name+" !! 궁극기 발동중~~");
            UltiEffect.SetActive(true);//필살기 이펙트
            moveSpeed = 14f;//필살기 속도 고정
            if (UltiTime >= 6.1f)//필살기는 6초동안 지속됨
            {
                isUltiTime = false;
                UltiTime = 0f;
                UltiEffect.SetActive(false);
            }
            else
            {
                UltiTime += Time.deltaTime;
            }
        }
        else if (isFastTime)
        {
            if (!FastTimeFlag)
            {
                moveSpeed += FastSpeedCorrection;//기본속도에 순풍속도보정값을 더한다.
                FastTimeFlag = true;
            }
            if (FastTime > 5f)//순풍 이벤트는 5초동안 지속됨
            {
                isFastTime = false;
                FastTime = 0f;
            }
            else
            {
                FastTime += Time.deltaTime;
            }
        }
        else if (isObstacle)//장애물에 부딛히면
        {
            if (!ObstacleFlag)
            {
                Debug.Log("장애물");
                moveSpeed -= ObstacleSpeedCorrection;//기본속도에 장애물 속도 감소값을 뺀다.
                ObstacleFlag = true;
            }
            if (ObstacleTime > 1.5f)//장애물로 인한 속도 감속은 3초동안 지속됨
            {
                isObstacle = false;
                ObstacleTime = 0f;
            }
            else
            {
                ObstacleTime += Time.deltaTime;
            }
        }
        // 19초가 경과한 경우 출발!
        if (currentTime >= 19f)//19f
        {
            // 오브젝트를 앞으로 이동시키기
            Vector3 movement = transform.forward * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
        }

        if (isFinished)//결승전에 들어갔으면 브레이크
        {
            moveSpeed = 1;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("UltimateLine"))
        {
            if (haveUltimate)
            {
                isUltiTime = true;
            }
        }
        if (other.CompareTag("FastLine"))
        {
            isFastTime = true;
        }
        if (other.CompareTag("EndLine"))
        {
            isEndLine = true;
        }
        if (other.CompareTag("ObstacleLine"))
        {
            isObstacleLine = true;
        }
        if (other.CompareTag("Obstacle"))
        {
            isObstacle = true;
        }
        if (other.CompareTag("FinishLine"))
        {
            isFinished = true;
        }
    }

    
}
