using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelect : MonoBehaviour
{
    public Button button;
    private Image buttonImg;
    public bool isSelect;
    public int count=0;

    void Start()
    {
        buttonImg = button.gameObject.GetComponent<Image>();
    }

    private void Update()
    {
        if (isSelect)
        {
            buttonImg.color = Color.yellow;
        }
        else
        {
            buttonImg.color = Color.white;
        }
    }

    public void Status()
    {
        if (!isSelect)
        {
            isSelect = true;
            count++;
        }
        else
        {
            isSelect = false;
            count--;
        }
    }
}
