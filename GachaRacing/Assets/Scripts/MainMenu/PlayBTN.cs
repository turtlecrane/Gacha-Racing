using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBTN : MonoBehaviour
{
    public PickSetting pickSetting;
    public totalCount totalcount;
    public GameData gameData;
    public bool isError = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (isError)
        {
            Invoke("Inactive",2f);
            isError = false;
        }
    }

    public void CheckforPlay()
    {
        if (pickSetting.pick == 0)
        {
            pickSetting.WarningMessage.text = "반드시 1명 이상을 뽑아야해요.";
            pickSetting.Active();
            isError = true;
        }
        else
        {
            gameData.ResetTime();
            gameData.totalPeople = totalcount.count;
            gameData.pickPeople = pickSetting.pick;
            SceneManager.LoadScene("PlayRacing");
        }
    }
    
    void Inactive()
    {
        pickSetting.Warning.gameObject.SetActive(false);
    }
}
