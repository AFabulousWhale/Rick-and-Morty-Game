using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public GameObject PreviousMenu;

    public AudioMixer audioMixer;

    public Toggle fullscreen;

    public bool Options;

    public Slider Main, SFX, Music;

    public int OptionTimes;

    public bool isFullscreen;
    void Start()
    {
        Main.value = Globals.MainVolume;
        SFX.value = Globals.SFXVolume;
        Music.value = Globals.MusicVolume;
        fullscreen.isOn = Globals.FullScreen;


        Options = false;
        gameObject.SetActive(false);


    }

    void Update()
    {
        if (gameObject == true)
        {
            Options = true;
        }

            if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Options)
            {
                goBack();
            }
        }
    }
    public void goBack()
    {
        Options = false;
        gameObject.SetActive(false);
        PreviousMenu.SetActive(true);
    }

    public void setMasterVolume(float Volume)
    {
        audioMixer.SetFloat("MasterVolume", Mathf.Log10 (Volume) * 20);
        Globals.MainVolume = Main.value;
        PlayerPrefs.SetFloat("mainVolume", Globals.MainVolume);
    }

    public void setSFXVolume(float Volume)
    {
        audioMixer.SetFloat("SFXVolume", Mathf.Log10(Volume) * 20);
        Globals.SFXVolume = SFX.value;
        PlayerPrefs.SetFloat("SFXVolume", Globals.SFXVolume);
    }

    public void setMusicVolume(float Volume)
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(Volume) * 20);
        Globals.MusicVolume = Music.value;
        PlayerPrefs.SetFloat("musicVolume", Globals.MusicVolume);
    }

    public void setFullscreen()
    {
        Debug.Log(Globals.FullScreen);
        Globals.FullScreen = fullscreen.isOn;
        Screen.fullScreen = Globals.FullScreen;
    }
    }
