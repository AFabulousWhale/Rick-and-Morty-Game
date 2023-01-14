using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject paueGameUI, player, Optionsmenu;

    public WinLose _WinLose;
    public ChangingCharacter _ChangingCharacter;
    public AbilitiesMain _AbilitiesMain;
    public RandomSounds _RandomSounds;
    public RandomMusic _RandomMusic;
    public OptionsMenu _OptionsMenu;
    void Start()
    {
        paueGameUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameIsPaused)
        {
            _RandomMusic._AS.volume = Globals.MusicVolume / 2;
        }else
        {
            _RandomMusic._AS.volume = Globals.MusicVolume;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!_OptionsMenu.Options)
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    }

    public void Resume()
    {
        _RandomMusic._AS.pitch = 1f;
        _RandomSounds.GetComponent<AudioSource>().UnPause();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        paueGameUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
        if (Globals.Character == "Rick And Morty")
        {
            player.gameObject.GetComponentInChildren<AbilitiesMain>().enabled = true;
            player.gameObject.GetComponentInChildren<gunscriptM>().enabled = true;
            player.gameObject.GetComponentInChildren<gunscriptR>().enabled = true;
        }else if (Globals.Character == "Summer")
        {
            player.gameObject.GetComponentInChildren<AbilitiesMainS>().enabled = true;
            player.gameObject.GetComponentInChildren<gunscriptS>().enabled = true;
        }
        else if (Globals.Character == "Jerry")
        {
            player.gameObject.GetComponentInChildren<AbilitiesMainJ>().enabled = true;
            player.gameObject.GetComponentInChildren<gunscriptJ>().enabled = true;
        }
        else if (Globals.Character == "Beth")
        {
            player.gameObject.GetComponentInChildren<AbilitiesMainB>().enabled = true;
            player.gameObject.GetComponentInChildren<gunscriptB>().enabled = true;
        }

    }

    void Pause()
    {
        if (!_WinLose.endGame)
        {
            _RandomSounds.GetComponent<AudioSource>().Pause();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            paueGameUI.SetActive(true);
            Time.timeScale = 0;
            GameIsPaused = true;
            if (Globals.Character == "Rick And Morty")
            {
                player.gameObject.GetComponentInChildren<AbilitiesMain>().enabled = false;
                player.gameObject.GetComponentInChildren<gunscriptM>().enabled = false;
                player.gameObject.GetComponentInChildren<gunscriptR>().enabled = false;
            }
            else if (Globals.Character == "Summer")
            {
                player.gameObject.GetComponentInChildren<AbilitiesMainS>().enabled = false;
                player.gameObject.GetComponentInChildren<gunscriptS>().enabled = false;
            }
            else if (Globals.Character == "Jerry")
            {
                player.gameObject.GetComponentInChildren<AbilitiesMainJ>().enabled = false;
                player.gameObject.GetComponentInChildren<gunscriptJ>().enabled = false;
            }
            else if (Globals.Character == "Beth")
            {
                player.gameObject.GetComponentInChildren<AbilitiesMainB>().enabled = false;
                player.gameObject.GetComponentInChildren<gunscriptB>().enabled = false;
            }
        }
    }

    public void QuitGame()
    {
        _RandomSounds.Other = 3;
        Debug.Log("Quit");
        Application.Quit();
    }

    public void OptionsMenu()
    {
        gameObject.SetActive(false);
        Optionsmenu.SetActive(true);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        GameIsPaused = false;
        _RandomSounds.Other = 3;
        SceneManager.LoadScene("Menu");
    }
}
