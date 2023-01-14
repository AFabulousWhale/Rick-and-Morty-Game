using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelectMain : MonoBehaviour
{
    public TMPro.TextMeshProUGUI charName;
    static public string Name;

    public AudioSource Button;

    public CharacterSelectButtons _CharacterSelectButtons;

    public GameObject Rick, Morty, Jerry, Summer, Beth;

    public TMPro.TMP_Dropdown difficulty;

    void Start()
    {
        if (difficulty.value == 0)
        {
            Globals.Difficulty = "Easy";
        }
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }

    }

    public void charButtonRickNMorty(bool value)
    {
        Button.Play();
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        _CharacterSelectButtons.CharacterNumber = 1;
        Rick.SetActive(true);
        Morty.SetActive(true);
        Name = "Rick And Morty";
        charName.text = Name.ToString();
    }

    public void charButtonSummer(bool value)
    {
        Button.Play();
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        _CharacterSelectButtons.CharacterNumber = 2;
        Summer.SetActive(true);
        Name = "Summer";
        charName.text = Name.ToString();
    }
    public void charButtonBeth(bool value)
    {
        Button.Play();
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        _CharacterSelectButtons.CharacterNumber = 4;
        Beth.SetActive(true);
        Name = "Beth";
        charName.text = Name.ToString();
    }
    public void charButtonJerry(bool value)
    {
        Button.Play();
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        _CharacterSelectButtons.CharacterNumber = 3;
        Jerry.SetActive(true);
        Name = "Jerry";
        charName.text = Name.ToString();
    }

    public void Confirm(bool value)
    {
        Globals.Character = Name;
        if(Globals.Character == "Rick And Morty")
        {
            SceneManager.LoadScene("Game RNM");
        }
        
        else if (Globals.Character == "Jerry")
        {
            SceneManager.LoadScene("Game Jerry");
        }
        
        else if (Globals.Character == "Summer")
        {
            SceneManager.LoadScene("Game Summer");
        }
        
        else if (Globals.Character == "Beth")
        {
            SceneManager.LoadScene("Game Beth");
        }
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void changeDifficulty(int val)
    {
        if (val == 0)
        {
            Globals.Difficulty = "Easy";
            Debug.LogError("Easy");
        }
        else if (val == 1)
        {
            Globals.Difficulty = "Medium";
            Debug.LogError("Medium");
        }
        else if (val == 2)
        {
            Globals.Difficulty = "Hard";
            Debug.LogError("Hard");
        }
    }
}
