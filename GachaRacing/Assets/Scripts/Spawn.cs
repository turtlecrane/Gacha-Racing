using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject gameData;
    public int totalPeople;
    private GameData gameDataScript;
    public bool[] boolVariables;

    private bool C1;
    private bool C2;
    private bool C3;
    private bool C4;
    private bool C5;
    private bool C6;
    private bool C7;
    private bool C8;

    void Start()
    {
        gameData = GameObject.Find("GameData");
        gameDataScript = gameData.GetComponent<GameData>();
        totalPeople = gameDataScript.totalPeople;

        // GameData 스크립트의 bool 변수들을 배열로 저장합니다.
        boolVariables = new bool[]
        {
            gameDataScript.rilla,
            gameDataScript.tung,
            gameDataScript.sakana,
            gameDataScript.boool,
            gameDataScript.hunter,
            gameDataScript.bbick,
            gameDataScript.horullus,
            gameDataScript.snicki
        };

        // true가 된 변수를 selectedCharacters 리스트에 추가합니다.
        for (int i = 0; i < boolVariables.Length; i++)
        {
            if (boolVariables[i])
            {
                gameDataScript.selectedCharacters.Add(boolVariables[i].ToString());
                //Debug.Log("Index of true element: " + i);
                //최대 4.8 이상으로 넘어가면 안댐~~
                if (totalPeople == 1)
                {
                    Instantiate(prefabs[i], transform.position, Quaternion.identity);
                }
                if (totalPeople == 2)
                {
                    if (!C1 && !C2)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 2f, Quaternion.identity);
                        C1 = true;
                    }
                    else if (C1 && !C2)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 2f, Quaternion.identity);
                        C2 = true;
                    }
                }
                if (totalPeople == 3)
                {
                    if (!C1 && !C2 && !C3)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 2f, Quaternion.identity);
                        C1 = true;
                    }
                    else if (C1 && !C2 && !C3)
                    {
                        Instantiate(prefabs[i], transform.position, Quaternion.identity);
                        C2 = true;
                    }
                    else if (C1 && C2 && !C3)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 2f, Quaternion.identity);
                        C3 = true;
                    }
                }
                if (totalPeople == 4)
                {
                    if (!C1 && !C2 && !C3 && !C4)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 3f, Quaternion.identity);
                        C1 = true;
                    }
                    else if (C1 && !C2 && !C3 && !C4)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 1f, Quaternion.identity);
                        C2 = true;
                    }
                    else if (C1 && C2 && !C3 && !C4)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 1f, Quaternion.identity);
                        C3 = true;
                    }
                    else if (C1 && C2 && C3 && !C4)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 3f, Quaternion.identity);
                        C4 = true;
                    }
                }
                if (totalPeople == 5)
                {
                    if (!C1 && !C2 && !C3 && !C4 && !C5)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 4f, Quaternion.identity);
                        C1 = true;
                    }
                    else if (C1 && !C2 && !C3 && !C4 && !C5)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 2f, Quaternion.identity);
                        C2 = true;
                    }
                    else if (C1 && C2 && !C3 && !C4 && !C5)
                    {
                        Instantiate(prefabs[i], transform.position, Quaternion.identity);
                        C3 = true;
                    }
                    else if (C1 && C2 && C3 && !C4 && !C5)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 2f, Quaternion.identity);
                        C4 = true;
                    }
                    else if (C1 && C2 && C3 && C4 && !C5)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 4f, Quaternion.identity);
                        C5 = true;
                    }
                }
                if (totalPeople == 6)
                {
                    if (!C1 && !C2 && !C3 && !C4 && !C5 && !C6)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 4.3f, Quaternion.identity);
                        C1 = true;
                    }
                    else if (C1 && !C2 && !C3 && !C4 && !C5 && !C6)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 2.4f, Quaternion.identity);
                        C2 = true;
                    }
                    else if (C1 && C2 && !C3 && !C4 && !C5 && !C6)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 1f, Quaternion.identity);
                        C3 = true;
                    }
                    else if (C1 && C2 && C3 && !C4 && !C5 && !C6)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 1f, Quaternion.identity);
                        C4 = true;
                    }
                    else if (C1 && C2 && C3 && C4 && !C5 && !C6)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 2.4f, Quaternion.identity);
                        C5 = true;
                    }
                    else if (C1 && C2 && C3 && C4 && C5 && !C6)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 4.3f, Quaternion.identity);
                        C6 = true;
                    }
                }
                if (totalPeople == 7)
                {
                    if (!C1 && !C2 && !C3 && !C4 && !C5 && !C6 && !C7)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 4.45f, Quaternion.identity);
                        C1 = true;
                    }
                    else if (C1 && !C2 && !C3 && !C4 && !C5 && !C6 && !C7)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 2.6f, Quaternion.identity);
                        C2 = true;
                    }
                    else if (C1 && C2 && !C3 && !C4 && !C5 && !C6 && !C7)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 1.2f, Quaternion.identity);
                        C3 = true;
                    }
                    else if (C1 && C2 && C3 && !C4 && !C5 && !C6 && !C7)
                    {
                        Instantiate(prefabs[i], transform.position, Quaternion.identity);
                        C4 = true;
                    }
                    else if (C1 && C2 && C3 && C4 && !C5 && !C6 && !C7)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 1.2f, Quaternion.identity);
                        C5 = true;
                    }
                    else if (C1 && C2 && C3 && C4 && C5 && !C6 && !C7)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 2.6f, Quaternion.identity);
                        C6 = true;
                    }
                    else if (C1 && C2 && C3 && C4 && C5 && C6 && !C7)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 4.45f, Quaternion.identity);
                        C7 = true;
                    }
                }
                if (totalPeople == 8)
                {
                    if (!C1 && !C2 && !C3 && !C4 && !C5 && !C6 && !C7 && !C8)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 4.5f, Quaternion.identity);
                        C1 = true;
                    }
                    else if (C1 && !C2 && !C3 && !C4 && !C5 && !C6 && !C7 && !C8)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 3f, Quaternion.identity);
                        C2 = true;
                    }
                    else if (C1 && C2 && !C3 && !C4 && !C5 && !C6 && !C7 && !C8)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 1.8f, Quaternion.identity);
                        C3 = true;
                    }
                    else if (C1 && C2 && C3 && !C4 && !C5 && !C6 && !C7 && !C8)
                    {
                        Instantiate(prefabs[i], transform.position - Vector3.right * 0.6f, Quaternion.identity);
                        C4 = true;
                    }
                    else if (C1 && C2 && C3 && C4 && !C5 && !C6 && !C7 && !C8)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 0.6f, Quaternion.identity);
                        C5 = true;
                    }
                    else if (C1 && C2 && C3 && C4 && C5 && !C6 && !C7 && !C8)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 1.8f, Quaternion.identity);
                        C6 = true;
                    }
                    else if (C1 && C2 && C3 && C4 && C5 && C6 && !C7 && !C8)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 3f, Quaternion.identity);
                        C7 = true;
                    }
                    else if (C1 && C2 && C3 && C4 && C5 && C6 && C7 && !C8)
                    {
                        Instantiate(prefabs[i], transform.position + Vector3.right * 4.5f, Quaternion.identity);
                        C8 = true;
                    }
                }
            }
        }
    }
}
