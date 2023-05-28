using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    private float currentTime;
    private GameData gameDataScript;
    public TextMeshProUGUI countDown;
    // Start is called before the first frame update
    void Start()
    {
        //countDown.text = "3";
        gameDataScript = GameObject.Find("GameData").GetComponent<GameData>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = gameDataScript.RacingTime;
        if (currentTime > 15f)
        {
            countDown.text = "2";
            if (currentTime > 16.2f)
            {
                countDown.text = "1";
                if (currentTime > 17.5f)
                {
                    countDown.text = "출발 !";
                }
            }
        }
    }
}
