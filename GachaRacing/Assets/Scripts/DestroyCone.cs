using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("장애물에 닿았습니다");
            Destroy(this.gameObject);
        }
    }
}
