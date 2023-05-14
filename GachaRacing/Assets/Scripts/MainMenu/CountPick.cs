using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountPick : MonoBehaviour
{
    public int count;
    public TextMeshProUGUI context;
    void Start()
    {
        count = 0;
    }

    void Update()
    {
        DontMinus();
        context.text = count.ToString();
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
