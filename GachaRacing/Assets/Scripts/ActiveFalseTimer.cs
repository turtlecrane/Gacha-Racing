using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveFalseTimer : MonoBehaviour
{
    public float Time;
    void Start()
    {
        Invoke("ActiveFalse",Time);
    }

    public void ActiveFalse()
    {
        gameObject.SetActive(false);
    }
}
