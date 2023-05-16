using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatus : MonoBehaviour
{
    public float currentTime;
    public float moveSpeed;
    public bool haveUltimate;
    private Rigidbody rb; 
    private float changeSpeedInterval = 4f;  // 속도 변경 간격
    private float nextSpeedChangeTime;  // 다음 속도 변경 시간
    
    public bool isUltiTime;
    public float UltiTime;
    public GameObject UltiEffect;
    
    private GameData gameDataScript;
    
    private void Start()
    {
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
    
        if (!isUltiTime)
        {
            // 일정 간격으로 속도 변경
            if (currentTime >= nextSpeedChangeTime)
            {
                moveSpeed = Random.Range(8f, 10f);
                nextSpeedChangeTime = currentTime + changeSpeedInterval;
            }
        }
        else//필살기 발동시
        {
            Debug.Log(gameObject.name+" !! 궁극기 발동중~~");
            UltiEffect.SetActive(true);
            moveSpeed = 14f;
            if (UltiTime > 6f)
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
        // 19초가 경과한 경우 출발!
        if (currentTime >= 19f)
        {
            // 오브젝트를 앞으로 이동시키기
            Vector3 movement = transform.forward * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.position + movement);
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
    }
}
