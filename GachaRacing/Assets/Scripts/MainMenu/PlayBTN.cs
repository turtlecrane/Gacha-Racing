using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBTN : MonoBehaviour
{
    public PickSetting pickSetting;
    public totalCount totalcount;
    public GameData gameData;
    public bool[] boolVariables;
    public bool isError = false;
    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (isError)
        {
            Invoke("Inactive",2f);
            isError = false;
        }
        // GameData 스크립트의 bool 변수들을 배열로 저장합니다.
        boolVariables = new bool[]
        {
            gameData.rilla,
            gameData.tung,
            gameData.sakana,
            gameData.boool,
            gameData.hunter,
            gameData.bbick,
            gameData.horullus,
            gameData.snicki
        };
    }

    public void CheckforPlay()
    {
        // boolVariables 배열에서 true인 요소의 개수를 계산합니다.
        int numTrue = 0;
        for (int i = 0; i < boolVariables.Length; i++)
        {
            if (boolVariables[i])
            {
                numTrue++;
            }
        }
        
        if (pickSetting.pick == 0)
        {
            pickSetting.WarningMessage.text = "반드시 1명 이상을 뽑아야해요.";
            pickSetting.Active();
            isError = true;
        }
        else if (numTrue == 1 && pickSetting.pick == 1)
        {
            pickSetting.WarningMessage.text = "1명만 달리는건 무의미해요..";
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
