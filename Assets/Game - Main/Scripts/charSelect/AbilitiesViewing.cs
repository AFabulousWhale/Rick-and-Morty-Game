using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesViewing : MonoBehaviour
{
    public CharacterSelectButtons _CharacterSelectButtons;
    public GameObject RickNMorty, BackButton, Summer, Jerry, Beth;
    public bool Paused;

    void Start()
    {
        RickNMorty.SetActive(false);
        Summer.SetActive(false);
        Beth.SetActive(false);
        Jerry.SetActive(false);
        BackButton.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
         {
            if (Paused)
            {
                Back();
            }
        }
    }
    public void AbilitiesButtonPressed()
    {
        Paused = true;
        gameObject.GetComponent<CharacterSelectButtons>().enabled = false;
        gameObject.GetComponent<CharacterSelectMain>().enabled = false;
        BackButton.SetActive(true);
        Time.timeScale = 0;
        if (_CharacterSelectButtons.CharacterNumber == 1)
        {
            RickNMorty.SetActive(true);
        }else if (_CharacterSelectButtons.CharacterNumber == 2)
        {
           Summer.SetActive(true);
        }
        else if (_CharacterSelectButtons.CharacterNumber == 3)
        {
            Jerry.SetActive(true);
        }
        else if (_CharacterSelectButtons.CharacterNumber == 4)
        {
            Beth.SetActive(true);
        }
    }

    public void Back()
    {
        Paused = false;
        gameObject.GetComponent<CharacterSelectButtons>().enabled = true;
        gameObject.GetComponent<CharacterSelectMain>().enabled = true;
        Time.timeScale = 1;
        BackButton.SetActive(false);
        RickNMorty.SetActive(false);
        Summer.SetActive(false);
        Beth.SetActive(false);
        Jerry.SetActive(false);
    }
}
