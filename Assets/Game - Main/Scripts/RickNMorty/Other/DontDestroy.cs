using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        GameObject[] Music = GameObject.FindGameObjectsWithTag("music");
        if(Music.Length > 1)
        {
            Destroy(this.gameObject);
        }
    }
}
