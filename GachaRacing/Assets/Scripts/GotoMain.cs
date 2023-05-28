using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoMain : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("MainMenu");

        // 하이어라키에서 DontDestroy 태그를 가진 오브젝트를 찾아서 삭제합니다.
        GameObject[] objs = GameObject.FindGameObjectsWithTag("DontDestroy");
        foreach (GameObject obj in objs)
        {
            for (int i = obj.transform.childCount - 1; i >= 0; i--)
            {
                Destroy(obj.transform.GetChild(i).gameObject);
            }
            Destroy(obj);
        }
    }
}