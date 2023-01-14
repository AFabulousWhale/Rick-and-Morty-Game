using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject Menumain;

    void Update()
    {
        if (gameObject.active)
        {
            StartCoroutine(BacktoMenu());
        }
    }

    IEnumerator BacktoMenu()
    {
        yield return new WaitForSeconds(40);
        Back();
    }
 public void Back()
    {
        gameObject.SetActive(false);
        Menumain.SetActive(true);
    }
}
