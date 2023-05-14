using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountPeople : MonoBehaviour
{
    public totalCount totalcount;
    public int count;
    public TextMeshProUGUI context;
    
    void Start()
    {
        count = 0;
    }
    
    void Update()
    {
        count = totalcount.count;
        DontMinus();
        context.text = "총 "+count.ToString()+"명이 달릴거에요!";
    }

    public void AddCount()
    {
        count++;
    }

    public void SubtractCount()
    {
        count--;
    }

    public void DontMinus()
    {
        if (count <= 0)
        {
            count = 0;
        }
    }
    
}
