using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Result : MonoBehaviour
{
    public TextMeshProUGUI RankName;
    public string[] playerName;
    public PlayerStatus[] resultPlayers;//마지막 순위가 기록됨
    public RankingSystem rankingSystem;
    
    void Update()
    {
        if (rankingSystem.OpenResult)
        {
            resultPlayers = new PlayerStatus[rankingSystem.topPlayers.Length];
            for (int i = 0; i < rankingSystem.topPlayers.Length; i++)
            {
                resultPlayers[i] = rankingSystem.topPlayers[i];
            }
        }
        
        RankName.text = "";

        for (int i = 0; i < resultPlayers.Length; i++)
        {
            string playerName = resultPlayers[i].name.Replace("(Clone)", "").Trim();
            RankName.text += (i + 1).ToString() + "등 : " + playerName + (i == resultPlayers.Length - 1 ? "" : "\n");
        }
        /*if (resultPlayers.Length == 1)
        {
            RankName.text = "1등 : " + resultPlayers[0].name;
        }
        else if (resultPlayers.Length == 2)
        {
            RankName.text = "1등 : " + resultPlayers[0].name +"\n2등 : " + resultPlayers[1].name;
        }
        else if (resultPlayers.Length == 3)
        {
            RankName.text = "1등 : " + resultPlayers[0].name +"\n2등 : " + resultPlayers[1].name + "\n3등 : "+ resultPlayers[2].name;
        }
        else if (resultPlayers.Length == 4)
        {
            RankName.text = "1등 : " + resultPlayers[0].name +"\n2등 : " + resultPlayers[1].name + "\n3등 : "+ resultPlayers[2].name
                            + "\n4등 : "+ resultPlayers[3].name;
        }
        else if (resultPlayers.Length == 5)
        {
            RankName.text = "1등 : " + resultPlayers[0].name +"\n2등 : " + resultPlayers[1].name + "\n3등 : "+ resultPlayers[2].name
                            + "\n4등 : "+ resultPlayers[3].name+ "\n5등 : "+ resultPlayers[4].name;
        }
        else if (resultPlayers.Length == 6)
        {
            RankName.text = "1등 : " + resultPlayers[0].name +"\n2등 : " + resultPlayers[1].name + "\n3등 : "+ resultPlayers[2].name
                            + "\n4등 : "+ resultPlayers[3].name+ "\n5등 : "+ resultPlayers[4].name+ "\n6등 : "+ resultPlayers[5].name;
        }
        else if (resultPlayers.Length == 7)
        {
            RankName.text = "1등 : " + resultPlayers[0].name +"\n2등 : " + resultPlayers[1].name + "\n3등 : "+ resultPlayers[2].name
                            + "\n4등 : "+ resultPlayers[3].name+ "\n5등 : "+ resultPlayers[4].name+ "\n6등 : "+ resultPlayers[5].name
                            + "\n7등 : "+ resultPlayers[6].name;
        }
        else if (resultPlayers.Length == 8)
        {
            RankName.text = "1등 : " + resultPlayers[0].name +"\n2등 : " + resultPlayers[1].name + "\n3등 : "+ resultPlayers[2].name
                            + "\n4등 : "+ resultPlayers[3].name+ "\n5등 : "+ resultPlayers[4].name+ "\n6등 : "+ resultPlayers[5].name
                            + "\n7등 : "+ resultPlayers[6].name+ "\n8등 : "+ resultPlayers[7].name;
        }*/
    }
}
