using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public Animator cameraAnimator;
    public GameObject countDownObject;
    public TextMeshProUGUI countDownText;
    
    private string currentAnimation;
    private float currentTime;
    private GameData gameDataScript;
    private bool hasActivated = false;
    private Coroutine countRoutine; // Coroutine을 저장할 변수
    
    private bool isCount_1 = false;
    private bool isCount_2 = false;
    private bool isCount_3 = false;
    private bool isCount_4 = false;
    
    void Start()
    {
        gameDataScript = GameObject.Find("GameData").GetComponent<GameData>();
    }
    
    void FixedUpdate()
    {
        //레이싱 기준 타임 가져오기
        currentTime = gameDataScript.RacingTime;
        currentAnimation = cameraAnimator.GetCurrentAnimatorClipInfo(0)[0].clip.name;
        if (currentAnimation == "Count1" && !isCount_3) 
        {
            countDownObject.SetActive(true);
            if (countRoutine != null) StopCoroutine(countRoutine); // 이전 Coroutine이 있다면 중단합니다.
            countRoutine = StartCoroutine(ScaleCountDown(1f, 0f, 1f)); // 크기를 1에서 0으로 줄이는 Coroutine을 실행합니다.
            isCount_3 = true;
        } 
        else if (currentAnimation == "Count2" && !isCount_2)
        {
            countDownText.text = "2";
            if (countRoutine != null) StopCoroutine(countRoutine);
            countRoutine = StartCoroutine(ScaleCountDown(1f, 0f, 1f));
            isCount_2 = true;
        }
        else if (currentAnimation == "Count3" && !isCount_1)
        {
            countDownText.text = "1";
            if (countRoutine != null) StopCoroutine(countRoutine);
            countRoutine = StartCoroutine(ScaleCountDown(1f, 0f, 1f));
            isCount_1 = true;
        }
        if (currentTime >= 19 && !hasActivated)
        {
            countDownText.text = "출발!";
            if (countRoutine != null) StopCoroutine(countRoutine);
            countRoutine = StartCoroutine(ScaleCountDown(1f, 1.5f, 0.7f));
            StartCoroutine(FadeOutCountDown(1f, 0f, 0.7f));//점차적으로 알파값 0으로 만들기
            hasActivated = true;
        }
        else if (currentTime >= 20 && hasActivated)
        {
            countDownObject.SetActive(false);
        }
    }
    IEnumerator ScaleCountDown(float startScale, float endScale, float duration)
    {
        float time = 0f;
        Vector3 start = new Vector3(startScale, startScale, startScale);
        Vector3 end = new Vector3(endScale, endScale, endScale);

        while (time <= duration)
        {
            float t = time / duration;
            countDownObject.transform.localScale = Vector3.Lerp(start, end, t);
            time += Time.deltaTime;
            yield return null;
        }
    }
    IEnumerator FadeOutCountDown(float startAlpha, float endAlpha, float duration)
    {
        float time = 0f;
        Color start = countDownText.color;
        Color end = countDownText.color;
        end.a = endAlpha;

        start.a = startAlpha;
        while (time <= duration)
        {
            float t = time / duration;
            countDownText.color = Color.Lerp(start, end, t);
            time += Time.deltaTime;
            yield return null;
        }
        countDownText.color = end;
    }
}
