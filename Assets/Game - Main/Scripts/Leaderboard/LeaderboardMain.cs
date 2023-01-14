using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using TMPro;

public class LeaderboardMain : MonoBehaviour
{
    public RNMLeaderboard _RNM;
    public JerryLeaderboard _Jerry;
    public SummerLeaderboard _Summer;
    public BethLeaderboard _Beth;


    public GameObject RNM, Jerry, Summer, Beth, RNMButt, JerryButt, SummerButt, BethButt, doneButt, Maininput, MusicMM, Music;
    public int RandomI, Randomscore;
    public TMPro.TextMeshProUGUI Back, scoreNext, nameNext, score, name, pos, urScore;
    public TMPro.TMP_InputField nameInput;

    public bool nameEntered;

    public GameObject Scores, Names, Pos;

    public int scoreComparison;

    public AudioSource buttonS;

    public int RandomSE;
    public AudioSource Finish1, Finish2, Finish3;
    void Start()
    {
        RandomSE = UnityEngine.Random.Range(1, 4);
        if(Globals.isGameFinished)
        {
            if (Globals.Character != "Rick And Morty")
            {
                if (RandomSE == 1)
                {
                    Finish1.Play();
                }
                else if (RandomSE == 2)
                {
                    Finish2.Play();
                }
                else if (RandomSE == 3)
                {
                    Finish3.Play();
                }
            }
        }
        MusicMM = GameObject.FindGameObjectWithTag("music");
        nameEntered = false;
        nameInput.characterLimit = 3;
        RNM.SetActive(false);
        Jerry.SetActive(false);
        Summer.SetActive(false);
        Beth.SetActive(false);
        RNMButt.SetActive(false);
        JerryButt.SetActive(false);
        SummerButt.SetActive(false);
        BethButt.SetActive(false);
        RandomI = UnityEngine.Random.Range(1, 5);
    }

    void Update()
    {

        if (Globals.isGameFinished)
        {
            Destroy(MusicMM);
            string text = nameInput.text;
            if (text != nameInput.text.ToUpper())
            {
                nameInput.text = nameInput.text.ToUpper();
            }

            Maininput.SetActive(true);
            if (nameInput.text == "")
            {
                doneButt.SetActive(false);
                Back.gameObject.SetActive(false);
            }
            else
            {
                doneButt.SetActive(true);
                Back.gameObject.SetActive(true);

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    BackToMenu();
                }
            }
            urScore.text = Globals.overallScore.ToString();
            Back.text = "Main Menu";

            if (nameEntered)
            {
                if (Globals.Character == "Rick And Morty")
                {
                    RNM.SetActive(true);
                    _RNM.RNMPlacement();
                    nameEntered = false;
                }
                else if (Globals.Character == "Jerry")
                {
                    Jerry.SetActive(true);
                    _Jerry.JerryPlacement();
                    nameEntered = false;
                }
                else if (Globals.Character == "Summer")
                {
                    Summer.SetActive(true);
                    _Summer.SummerPlacement();
                    nameEntered = false;
                }
                else if (Globals.Character == "Beth")
                {
                    Beth.SetActive(true);
                    _Beth.BethPlacement();
                    nameEntered = false;
                }
            }
        }
        else if (!Globals.isGameFinished)
        {
            Destroy(Music);
            Maininput.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                BackToMenu();
            }

            RNMButt.SetActive(true);
            JerryButt.SetActive(true);
            SummerButt.SetActive(true);
            BethButt.SetActive(true);
            if (RandomI == 1)
            {
                RNM.SetActive(true);
                _RNM.RNMViewing();
                Jerry.SetActive(false);
                Summer.SetActive(false);
                Beth.SetActive(false);
            }
            else if (RandomI == 2)
            {
                Jerry.SetActive(true);
                _Jerry.JerryViewing();
                RNM.SetActive(false);
                Summer.SetActive(false);
                Beth.SetActive(false);
            }
            else if (RandomI == 3)
            {
                Summer.SetActive(true);
                _Summer.SummerViewing();
                RNM.SetActive(false);
                Jerry.SetActive(false);
                Beth.SetActive(false);
            }
            else if (RandomI == 4)
            {
                Beth.SetActive(true);
                _Beth.BethViewing();
                RNM.SetActive(false);
                Jerry.SetActive(false);
                Summer.SetActive(false);
            }
            Back.text = "Back";
        }
    }

    public void RNMB()
    {
        RandomI = 1;
        buttonS.Play();
        RNM.SetActive(true);
        _RNM.RNMViewing();

        Jerry.SetActive(false);
        Summer.SetActive(false);
        Beth.SetActive(false);
    }
    public void JerryB()
    {
        RandomI = 2;
        buttonS.Play();
        Jerry.SetActive(true);
        _Jerry.JerryViewing();

        RNM.SetActive(false);
        Summer.SetActive(false);
        Beth.SetActive(false);
    }
    public void SummerB()
    {
        RandomI = 3;
        buttonS.Play();
        Summer.SetActive(true);
        _Summer.SummerViewing();

        RNM.SetActive(false);
        Jerry.SetActive(false);
        Beth.SetActive(false);
    }

    public void BethB()
    {
        RandomI = 4;
        buttonS.Play();
        Beth.SetActive(true);
        _Beth.BethViewing();

        RNM.SetActive(false);
        Jerry.SetActive(false);
        Summer.SetActive(false);
    }

    public void doneName()
    {
            buttonS.Play();
            nameEntered = true;
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
        PlayerPrefs.Save();
    }
}
