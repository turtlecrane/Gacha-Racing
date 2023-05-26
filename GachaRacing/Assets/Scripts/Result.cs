using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject SpawnPoint;
    public GameObject[] Profile;
    
    public PlayerStatus[] resultPlayers;
    public RankingSystem rankingSystem;
    void Start()
    {
        GameObject profileObject = Instantiate(Profile[0], Vector3.zero, Quaternion.identity);
        profileObject.transform.SetParent(Canvas.transform, false);
    }

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
        
    }
}
