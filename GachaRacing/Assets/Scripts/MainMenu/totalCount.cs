using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class totalCount : MonoBehaviour
{
    public CharSelect _1;
    public CharSelect _2;
    public CharSelect _3;
    public CharSelect _4;
    public CharSelect _5;
    public CharSelect _6;
    public CharSelect _7;
    public CharSelect _8;

    public int count;

    public GameData gameData;

    void Update()
    {
        count = _1.count + _2.count + _3.count + _4.count + _5.count + _6.count + _7.count + _8.count;

        if (_1.isSelect)
        {
            gameData.rilla = true;
        }
        else
        {
            gameData.rilla = false;
        }
        if (_2.isSelect)
        {
            gameData.tung = true;
        }
        else
        {
            gameData.tung = false;
        }
        if (_3.isSelect)
        {
            gameData.sakana = true;
        }
        else
        {
            gameData.sakana = false;
        }
        if (_4.isSelect)
        {
            gameData.boool = true;
        }
        else
        {
            gameData.boool = false;
        }
        if (_5.isSelect)
        {
            gameData.hunter = true;
        }
        else
        {
            gameData.hunter = false;
        }
        if (_6.isSelect)
        {
            gameData.bbick = true;
        }
        else
        {
            gameData.bbick = false;
        }
        if (_7.isSelect)
        {
            gameData.horullus = true;
        }
        else
        {
            gameData.horullus = false;
        }
        if (_8.isSelect)
        {
            gameData.snicki = true;
        }
        else
        {
            gameData.snicki = false;
        }
    }
}
