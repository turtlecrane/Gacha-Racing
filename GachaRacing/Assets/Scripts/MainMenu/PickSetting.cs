using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickSetting : MonoBehaviour
{
    public TextMeshProUGUI WarningMessage;
    public GameObject Warning;
    public totalCount totalcount;
    public CountPick countPick;
    public int people = 0;
    public int pick = 0;
   
    void Update()
    {
        people = totalcount.count;
        pick = countPick.count;
        
        if (pick > people)
        {
            countPick.count--;
            WarningMessage.text = "뽑을 인원이 총 인원보다\n많을 수 없습니다 !";
            Active();
            Invoke("Inactive", 2f);
        }
    }

    public void Active()
    {
        Warning.gameObject.SetActive(true);
    }

    void Inactive()
    {
        Warning.gameObject.SetActive(false);
    }
}
