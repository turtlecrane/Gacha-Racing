using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public int totalPeople;
    public int pickPeople;
    public bool rilla;
    public bool tung;
    public bool sakana;
    public bool boool;
    public bool hunter;
    public bool bbick;
    public bool horullus;
    public bool snicki;
    public List<string> selectedCharacters;
}

/*
 oid Start()
    {
        gameData = GameObject.Find("GameData");
        GameData gameDataScript = gameData.GetComponent<GameData>();
        totalPeople = gameDataScript.totalPeople;
        if (totalPeople == 1)
        {
            if (gameDataScript.rilla)
            {
                Instantiate(prefabs[0], transform.position, Quaternion.identity);
            }
            else if (gameDataScript.tung)
            {
                Instantiate(prefabs[1], transform.position, Quaternion.identity);
            }
            else if (gameDataScript.sakana)
            {
                Instantiate(prefabs[2], transform.position, Quaternion.identity);
            }
            else if (gameDataScript.boool)
            {
                Instantiate(prefabs[3], transform.position, Quaternion.identity);
            }
            else if (gameDataScript.hunter)
            {
                Instantiate(prefabs[4], transform.position, Quaternion.identity);
            }
            else if (gameDataScript.bbick)
            {
                Instantiate(prefabs[5], transform.position, Quaternion.identity);
            }
            else if (gameDataScript.horullus)
            {
                Instantiate(prefabs[6], transform.position, Quaternion.identity);
            }
            else if (gameDataScript.snicki)
            {
                Instantiate(prefabs[7], transform.position, Quaternion.identity);
            }

        }
        else if (totalPeople == 2)
        {
            if (gameDataScript.rilla && gameDataScript.tung)
            {
                Instantiate(prefabs[0], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[1], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.rilla && gameDataScript.sakana)
            {
                Instantiate(prefabs[0], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[2], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.rilla && gameDataScript.boool)
            {
                Instantiate(prefabs[0], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[3], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.rilla && gameDataScript.hunter)
            {
                Instantiate(prefabs[0], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[4], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.rilla && gameDataScript.bbick)
            {
                Instantiate(prefabs[0], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[5], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.rilla && gameDataScript.horullus)
            {
                Instantiate(prefabs[0], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[6], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.rilla && gameDataScript.snicki)
            {
                Instantiate(prefabs[0], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[7], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.tung && gameDataScript.sakana)
            {
                Instantiate(prefabs[1], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[2], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.tung && gameDataScript.boool)
            {
                Instantiate(prefabs[1], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[3], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.tung && gameDataScript.hunter)
            {
                Instantiate(prefabs[1], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[4], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.tung && gameDataScript.bbick)
            {
                Instantiate(prefabs[1], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[5], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.tung && gameDataScript.horullus)
            {
                Instantiate(prefabs[1], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[6], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.tung && gameDataScript.snicki)
            {
                Instantiate(prefabs[1], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[7], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.sakana && gameDataScript.boool)
            {
                Instantiate(prefabs[2], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[3], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.sakana && gameDataScript.hunter)
            {
                Instantiate(prefabs[2], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[4], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.sakana && gameDataScript.bbick)
            {
                Instantiate(prefabs[2], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[5], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.sakana && gameDataScript.horullus)
            {
                Instantiate(prefabs[2], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[6], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.sakana && gameDataScript.snicki)
            {
                Instantiate(prefabs[2], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[7], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.boool && gameDataScript.hunter)
            {
                Instantiate(prefabs[3], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[4], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.boool && gameDataScript.bbick)
            {
                Instantiate(prefabs[3], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[5], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.boool && gameDataScript.horullus)
            {
                Instantiate(prefabs[3], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[6], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.boool && gameDataScript.snicki)
            {
                Instantiate(prefabs[3], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[7], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.hunter && gameDataScript.bbick)
            {
                Instantiate(prefabs[4], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[5], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.hunter && gameDataScript.horullus)
            {
                Instantiate(prefabs[4], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[6], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.hunter && gameDataScript.snicki)
            {
                Instantiate(prefabs[4], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[7], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.bbick && gameDataScript.horullus)
            {
                Instantiate(prefabs[5], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[6], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.bbick && gameDataScript.snicki)
            {
                Instantiate(prefabs[5], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[7], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
            else if (gameDataScript.horullus && gameDataScript.snicki)
            {
                Instantiate(prefabs[6], transform.position - Vector3.right * 2f, Quaternion.identity);
                Instantiate(prefabs[7], transform.position + Vector3.right * 2f, Quaternion.identity);
            }
        }
        else if (totalPeople == 3)
        {
            Vector3 offset = Vector3.right * 2f;
            Vector3 position = transform.position;

            if (gameDataScript.rilla)//0 (gameDataScript.sakana)
            {
                Instantiate(prefabs[0], position - offset, Quaternion.identity);
                if (gameDataScript.tung)//1
                {
                    Instantiate(prefabs[1], position, Quaternion.identity);
                    if (gameDataScript.sakana) //2
                    {
                        Instantiate(prefabs[2], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.boool) //3
                    {
                        Instantiate(prefabs[3], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.hunter) //4
                    {
                        Instantiate(prefabs[4], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.bbick) //5
                    {
                        Instantiate(prefabs[5], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.sakana) //2
                {
                    Instantiate(prefabs[2], position, Quaternion.identity);
                    if (gameDataScript.boool) //3
                    {
                        Instantiate(prefabs[3], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.hunter) //4
                    {
                        Instantiate(prefabs[4], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.bbick) //5
                    {
                        Instantiate(prefabs[5], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.boool) //3
                {
                    Instantiate(prefabs[3], position, Quaternion.identity);
                    if (gameDataScript.hunter) //4
                    {
                        Instantiate(prefabs[4], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.bbick) //5
                    {
                        Instantiate(prefabs[5], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.hunter) //4
                {
                    Instantiate(prefabs[4], position, Quaternion.identity);
                    if (gameDataScript.bbick) //5
                    {
                        Instantiate(prefabs[5], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.bbick) //5
                {
                    Instantiate(prefabs[5], position, Quaternion.identity);
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.horullus) //6
                {
                    Instantiate(prefabs[6], position, Quaternion.identity);
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
            }
            else if (gameDataScript.tung) //1 
            {
                Instantiate(prefabs[1], position - offset, Quaternion.identity);
                if (gameDataScript.sakana) //2
                {
                    Instantiate(prefabs[2], position, Quaternion.identity);
                    if (gameDataScript.boool) //3
                    {
                        Instantiate(prefabs[3], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.hunter) //4
                    {
                        Instantiate(prefabs[4], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.bbick) //5
                    {
                        Instantiate(prefabs[5], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.boool) //3
                {
                    Instantiate(prefabs[3], position, Quaternion.identity);
                    if (gameDataScript.hunter) //4
                    {
                        Instantiate(prefabs[4], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.bbick) //5
                    {
                        Instantiate(prefabs[5], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.hunter) //4
                {
                    Instantiate(prefabs[4], position, Quaternion.identity);
                    if (gameDataScript.bbick) //5
                    {
                        Instantiate(prefabs[5], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.bbick) //5
                {
                    Instantiate(prefabs[5], position, Quaternion.identity);
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.horullus) //6
                {
                    Instantiate(prefabs[6], position, Quaternion.identity);
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
            }
            else if (gameDataScript.sakana) //2 
            {
                Instantiate(prefabs[2], position - offset, Quaternion.identity);
                if (gameDataScript.boool) //3
                {
                    Instantiate(prefabs[3], position, Quaternion.identity);
                    if (gameDataScript.hunter) //4
                    {
                        Instantiate(prefabs[4], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.bbick) //5
                    {
                        Instantiate(prefabs[5], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.hunter) //4
                {
                    Instantiate(prefabs[4], position, Quaternion.identity);
                    if (gameDataScript.bbick) //5
                    {
                        Instantiate(prefabs[5], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.bbick) //5
                {
                    Instantiate(prefabs[5], position, Quaternion.identity);
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.horullus) //6
                {
                    Instantiate(prefabs[6], position, Quaternion.identity);
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
            }
            else if (gameDataScript.boool) //3 
            {
                Instantiate(prefabs[3], position - offset, Quaternion.identity);
                if (gameDataScript.hunter) //4
                {
                    Instantiate(prefabs[4], position, Quaternion.identity);
                    if (gameDataScript.bbick) //5
                    {
                        Instantiate(prefabs[5], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.bbick) //5
                {
                    Instantiate(prefabs[5], position, Quaternion.identity);
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.horullus) //6
                {
                    Instantiate(prefabs[6], position, Quaternion.identity);
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
            }
            else if (gameDataScript.hunter) //4 
            {
                Instantiate(prefabs[4], position - offset, Quaternion.identity);
                if (gameDataScript.bbick) //5
                {
                    Instantiate(prefabs[5], position, Quaternion.identity);
                    if (gameDataScript.horullus) //6
                    {
                        Instantiate(prefabs[6], position + offset, Quaternion.identity);
                    }
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
                else if (gameDataScript.horullus) //6
                {
                    Instantiate(prefabs[6], position, Quaternion.identity);
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
            }
            else if (gameDataScript.bbick) //5 
            {
                Instantiate(prefabs[5], position - offset, Quaternion.identity);
                if (gameDataScript.horullus) //6
                {
                    Instantiate(prefabs[6], position, Quaternion.identity);
                    if (gameDataScript.snicki) //7
                    {
                        Instantiate(prefabs[7], position + offset, Quaternion.identity);
                    }
                }
            }
        }
    }
 
 
 
 */
