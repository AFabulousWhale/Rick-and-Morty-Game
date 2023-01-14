using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    private Animator anim;
    public GameObject CrossFade, OptionsMenu, Music, Credit, ControlsMenu;
    public AudioSource Button;
    public OptionsMenu _OptionsMenu;

    public AudioMixer audioMixer;

    public TMPro.TextMeshProUGUI BackText;
    void Start()
    {
        Globals.isGameFinished = false;
        Globals.firstTime = PlayerPrefs.GetInt("firstTime");
        if (Globals.firstTime == 0)
        {
            ControlsMenu.SetActive(true);
            BackText.text = "Main Menu".ToString();

            PlayerPrefs.SetFloat("musicVolume", 1);
            PlayerPrefs.SetFloat("SFXVolume", 1);
            PlayerPrefs.SetFloat("mainVolume", 1);

            PlayerPrefs.SetString("Name1stRNM", "---");
            PlayerPrefs.SetString("Name2ndRNM", "---");
            PlayerPrefs.SetString("Name3rdRNM", "---");
            PlayerPrefs.SetString("Name4thRNM", "---");
            PlayerPrefs.SetString("Name5thRNM", "---");
            PlayerPrefs.SetString("Name6thRNM", "---");
            PlayerPrefs.SetString("Name7thRNM", "---");
            PlayerPrefs.SetString("Name8thRNM", "---");
            PlayerPrefs.SetString("Name9thRNM", "---");
            PlayerPrefs.SetString("Name10thRNM", "---");

            PlayerPrefs.SetString("Scores1stRNM", "0000000");
            PlayerPrefs.SetString("Scores2ndRNM", "0000000");
            PlayerPrefs.SetString("Scores3rdRNM", "0000000");
            PlayerPrefs.SetString("Scores4thRNM", "0000000");
            PlayerPrefs.SetString("Scores5thRNM", "0000000");
            PlayerPrefs.SetString("Scores6thRNM", "0000000");
            PlayerPrefs.SetString("Scores7thRNM", "0000000");
            PlayerPrefs.SetString("Scores8thRNM", "0000000");
            PlayerPrefs.SetString("Scores9thRNM", "0000000");
            PlayerPrefs.SetString("Scores10thRNM", "0000000");

            PlayerPrefs.SetString("Name1stJ", "---");
            PlayerPrefs.SetString("Name2ndJ", "---");
            PlayerPrefs.SetString("Name3rdJ", "---");
            PlayerPrefs.SetString("Name4thJ", "---");
            PlayerPrefs.SetString("Name5thJ", "---");
            PlayerPrefs.SetString("Name6thJ", "---");
            PlayerPrefs.SetString("Name7thJ", "---");
            PlayerPrefs.SetString("Name8thJ", "---");
            PlayerPrefs.SetString("Name9thJ", "---");
            PlayerPrefs.SetString("Name10thJ", "---");

            PlayerPrefs.SetString("Scores1stJ", "0000000");
            PlayerPrefs.SetString("Scores2ndJ", "0000000");
            PlayerPrefs.SetString("Scores3rdJ", "0000000");
            PlayerPrefs.SetString("Scores4thJ", "0000000");
            PlayerPrefs.SetString("Scores5thJ", "0000000");
            PlayerPrefs.SetString("Scores6thJ", "0000000");
            PlayerPrefs.SetString("Scores7thJ", "0000000");
            PlayerPrefs.SetString("Scores8thJ", "0000000");
            PlayerPrefs.SetString("Scores9thJ", "0000000");
            PlayerPrefs.SetString("Scores10thJ", "0000000");

            PlayerPrefs.SetString("Name1stS", "---");
            PlayerPrefs.SetString("Name2ndS", "---");
            PlayerPrefs.SetString("Name3rdS", "---");
            PlayerPrefs.SetString("Name4thS", "---");
            PlayerPrefs.SetString("Name5thS", "---");
            PlayerPrefs.SetString("Name6thS", "---");
            PlayerPrefs.SetString("Name7thS", "---");
            PlayerPrefs.SetString("Name8thS", "---");
            PlayerPrefs.SetString("Name9thS", "---");
            PlayerPrefs.SetString("Name10thS", "---");

            PlayerPrefs.SetString("Scores1stS", "0000000");
            PlayerPrefs.SetString("Scores2ndS", "0000000");
            PlayerPrefs.SetString("Scores3rdS", "0000000");
            PlayerPrefs.SetString("Scores4thS", "0000000");
            PlayerPrefs.SetString("Scores5thS", "0000000");
            PlayerPrefs.SetString("Scores6thS", "0000000");
            PlayerPrefs.SetString("Scores7thS", "0000000");
            PlayerPrefs.SetString("Scores8thS", "0000000");
            PlayerPrefs.SetString("Scores9thS", "0000000");
            PlayerPrefs.SetString("Scores10thS", "0000000");

            PlayerPrefs.SetString("Name1stB", "---");
            PlayerPrefs.SetString("Name2ndB", "---");
            PlayerPrefs.SetString("Name3rdB", "---");
            PlayerPrefs.SetString("Name4thB", "---");
            PlayerPrefs.SetString("Name5thB", "---");
            PlayerPrefs.SetString("Name6thB", "---");
            PlayerPrefs.SetString("Name7thB", "---");
            PlayerPrefs.SetString("Name8thB", "---");
            PlayerPrefs.SetString("Name9thB", "---");
            PlayerPrefs.SetString("Name10thB", "---");

            PlayerPrefs.SetString("Scores1stB", "0000000");
            PlayerPrefs.SetString("Scores2ndB", "0000000");
            PlayerPrefs.SetString("Scores3rdB", "0000000");
            PlayerPrefs.SetString("Scores4thB", "0000000");
            PlayerPrefs.SetString("Scores5thB", "0000000");
            PlayerPrefs.SetString("Scores6thB", "0000000");
            PlayerPrefs.SetString("Scores7thB", "0000000");
            PlayerPrefs.SetString("Scores8thB", "0000000");
            PlayerPrefs.SetString("Scores9thB", "0000000");
            PlayerPrefs.SetString("Scores10thB", "0000000");

            Globals.firstTime = 1;
            PlayerPrefs.SetInt("firstTime", Globals.firstTime);
            PlayerPrefs.Save();
        }
        else
        {
            BackText.text = "Back".ToString();
            ControlsMenu.SetActive(false);
        }

        Globals.MainVolume = PlayerPrefs.GetFloat("mainVolume");
        Globals.SFXVolume = PlayerPrefs.GetFloat("SFXVolume");
        Globals.MusicVolume = PlayerPrefs.GetFloat("musicVolume");

        audioMixer.SetFloat("MusicVolume", Globals.MusicVolume);
        audioMixer.SetFloat("SFXVolume", Globals.SFXVolume);
        audioMixer.SetFloat("MasterVolume", Globals.MainVolume);

        Music = GameObject.FindGameObjectWithTag("music");
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
  
    
    public void PlayGame ()
    {
        Globals.overallScore = 0;
        Destroy(Music);
        Button.Play();
        SceneManager.LoadScene("Chose Character");
    }

    public void QuitGame ()
    {
        Button.Play();
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Options()
    {
        Button.Play();
        gameObject.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void Leaderboard()
    {
        DontDestroyOnLoad(Music);
        Globals.isGameFinished = false;
        Button.Play();
        SceneManager.LoadScene("Leaderboard");
    }

    public void Credits()
    {
        gameObject.SetActive(false);
        Credit.SetActive(true);
        Button.Play();
    }

    public void Controls()
    {
        BackText.text = "Back".ToString();
        gameObject.SetActive(false);
        Button.Play();
        ControlsMenu.SetActive(true);
    }
}


