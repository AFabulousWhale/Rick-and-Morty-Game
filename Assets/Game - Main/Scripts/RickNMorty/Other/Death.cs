using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public AudioSource button;
    // Update is called once per frame
    void Update()
    {
        
            if (Input.anyKeyDown)
            {
            button.Play();
            SceneManager.LoadScene("Menu");
            }
        
    }
}
