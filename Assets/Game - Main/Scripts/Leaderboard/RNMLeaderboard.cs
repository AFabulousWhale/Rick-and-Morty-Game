using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using TMPro;

public class RNMLeaderboard : MonoBehaviour
{
    public int RandomI, RandomSE;
    public TMPro.TextMeshProUGUI scoreNext, nameNext, score, name, pos;
    public TMPro.TMP_InputField nameInput;
    public string scoreText;

    public GameObject Scores, Names, Pos;

    public int scoreComparison;

    public AudioSource buttonS;

    public LeaderboardMain _LeaderboardMain;

    public AudioSource Morty1, Morty2;
    void Start()
    {
        RandomI = UnityEngine.Random.Range(0, 5);
        RandomSE = UnityEngine.Random.Range(0, 3);
        if (Globals.Character == "Rick And Morty")
        {
            if (Globals.RickorMorty == 1)
            {
                if (RandomSE == 0)
                {
                    Morty1.Play();
                }
                else if (RandomSE == 1)
                {
                    Morty2.Play();
                }
            }
        }
    }

    public void RNMPlacement()
    {
        Scores = GameObject.Find("scoreTextRNM1");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores1stRNM");
        scoreText = score.text;
        scoreComparison = Convert.ToInt32(scoreText);
        Names = GameObject.Find("nameTextRNM1");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name1stRNM");

        //checking if #1
        if (Globals.overallScore > scoreComparison)
        {
            Debug.Log("is #1");
            //pushing scores lower
            Scores = GameObject.Find("scoreTextRNM11");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores10thRNM");
            Names = GameObject.Find("nameTextRNM11");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name10thRNM");
            PlayerPrefs.SetString("Scores11thRNM", scoreNext.text);
            PlayerPrefs.SetString("Name11thRNM", nameNext.text);

            Scores = GameObject.Find("scoreTextRNM10");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores9thRNM");
            Names = GameObject.Find("nameTextRNM10");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name9thRNM");
            PlayerPrefs.SetString("Scores10thRNM", scoreNext.text);
            PlayerPrefs.SetString("Name10thRNM", nameNext.text);

            Scores = GameObject.Find("scoreTextRNM9");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores8thRNM");
            Names = GameObject.Find("nameTextRNM9");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name8thRNM");
            PlayerPrefs.SetString("Scores9thRNM", scoreNext.text);
            PlayerPrefs.SetString("Name9thRNM", nameNext.text);

            Scores = GameObject.Find("scoreTextRNM8");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores7thRNM");
            Names = GameObject.Find("nameTextRNM8");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name7thRNM");
            PlayerPrefs.SetString("Scores8thRNM", scoreNext.text);
            PlayerPrefs.SetString("Name8thRNM", nameNext.text);

            Scores = GameObject.Find("scoreTextRNM7");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores6thRNM");
            Names = GameObject.Find("nameTextRNM7");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name6thRNM");
            PlayerPrefs.SetString("Scores7thRNM", scoreNext.text);
            PlayerPrefs.SetString("Name7thRNM", nameNext.text);

            Scores = GameObject.Find("scoreTextRNM6");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores5thRNM");
            Names = GameObject.Find("nameTextRNM6");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name5thRNM");
            PlayerPrefs.SetString("Scores6thRNM", scoreNext.text);
            PlayerPrefs.SetString("Name6thRNM", nameNext.text);

            Scores = GameObject.Find("scoreTextRNM5");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores4thRNM");
            Names = GameObject.Find("nameTextRNM5");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name4thRNM");
            PlayerPrefs.SetString("Scores5thRNM", scoreNext.text);
            PlayerPrefs.SetString("Name5thRNM", nameNext.text);

            Scores = GameObject.Find("scoreTextRNM4");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores3rdRNM");
            Names = GameObject.Find("nameTextRNM4");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name3rdRNM");
            PlayerPrefs.SetString("Scores4thRNM", scoreNext.text);
            PlayerPrefs.SetString("Name4thRNM", nameNext.text);

            Scores = GameObject.Find("scoreTextRNM3");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores2ndRNM");
            Names = GameObject.Find("nameTextRNM3");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name2ndRNM");
            PlayerPrefs.SetString("Scores3rdRNM", scoreNext.text);
            PlayerPrefs.SetString("Name3rdRNM", nameNext.text);

            Scores = GameObject.Find("scoreTextRNM2");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores1stRNM");
            Names = GameObject.Find("nameTextRNM2");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name1stRNM");
            PlayerPrefs.SetString("Scores2ndRNM", scoreNext.text);
            PlayerPrefs.SetString("Name2ndRNM", nameNext.text);

            Pos = GameObject.Find("posTextRNM1");
            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
            pos.fontStyle = FontStyles.Bold;
            pos.color = new Color32(246, 255, 0, 255);
            Scores = GameObject.Find("scoreTextRNM1");
            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            score.fontStyle = FontStyles.Bold;
            score.color = new Color32(246, 255, 0, 255);
            Names = GameObject.Find("nameTextRNM1");
            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
            name.fontStyle = FontStyles.Bold;
            name.color = new Color32(246, 255, 0, 255);
            score.text = _LeaderboardMain.urScore.text;
            name.text = nameInput.text;
            PlayerPrefs.SetString("Scores1stRNM", score.text);
            PlayerPrefs.SetString("Name1stRNM", name.text);
        }
        else if (Globals.overallScore < scoreComparison)
        {
            Debug.Log("not #1");
            Scores = GameObject.Find("scoreTextRNM2");
            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            score.text = PlayerPrefs.GetString("Scores2ndRNM");
            scoreText = score.text;
            scoreComparison = Convert.ToInt32(scoreText);
            Names = GameObject.Find("nameTextRNM2");
            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
            name.text = PlayerPrefs.GetString("Name2ndRNM");

            //checking if #2
            if (Globals.overallScore > scoreComparison)
            {
                //pushing scores lower
                Scores = GameObject.Find("scoreTextRNM11");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores10thRNM");
                Names = GameObject.Find("nameTextRNM11");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name10thRNM");
                PlayerPrefs.SetString("Scores11thRNM", scoreNext.text);
                PlayerPrefs.SetString("Name11thRNM", nameNext.text);

                Scores = GameObject.Find("scoreTextRNM10");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores9thRNM");
                Names = GameObject.Find("nameTextRNM10");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name9thRNM");
                PlayerPrefs.SetString("Scores10thRNM", scoreNext.text);
                PlayerPrefs.SetString("Name10thRNM", nameNext.text);

                Scores = GameObject.Find("scoreTextRNM9");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores8thRNM");
                Names = GameObject.Find("nameTextRNM9");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name8thRNM");
                PlayerPrefs.SetString("Scores9thRNM", scoreNext.text);
                PlayerPrefs.SetString("Name9thRNM", nameNext.text);

                Scores = GameObject.Find("scoreTextRNM8");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores7thRNM");
                Names = GameObject.Find("nameTextRNM8");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name7thRNM");
                PlayerPrefs.SetString("Scores8thRNM", scoreNext.text);
                PlayerPrefs.SetString("Name8thRNM", nameNext.text);

                Scores = GameObject.Find("scoreTextRNM7");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores6thRNM");
                Names = GameObject.Find("nameTextRNM7");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name6thRNM");
                PlayerPrefs.SetString("Scores7thRNM", scoreNext.text);
                PlayerPrefs.SetString("Name7thRNM", nameNext.text);

                Scores = GameObject.Find("scoreTextRNM6");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores5thRNM");
                Names = GameObject.Find("nameTextRNM6");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name5thRNM");
                PlayerPrefs.SetString("Scores6thRNM", scoreNext.text);
                PlayerPrefs.SetString("Name6thRNM", nameNext.text);

                Scores = GameObject.Find("scoreTextRNM5");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores4thRNM");
                Names = GameObject.Find("nameTextRNM5");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name4thRNM");
                PlayerPrefs.SetString("Scores5thRNM", scoreNext.text);
                PlayerPrefs.SetString("Name5thRNM", nameNext.text);

                Scores = GameObject.Find("scoreTextRNM4");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores3rdRNM");
                Names = GameObject.Find("nameTextRNM4");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name3rdRNM");
                PlayerPrefs.SetString("Scores4thRNM", scoreNext.text);
                PlayerPrefs.SetString("Name4thRNM", nameNext.text);

                Scores = GameObject.Find("scoreTextRNM3");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores2ndRNM");
                Names = GameObject.Find("nameTextRNM3");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name2ndRNM");
                PlayerPrefs.SetString("Scores3rdRNM", scoreNext.text);
                PlayerPrefs.SetString("Name3rdRNM", nameNext.text);

                Pos = GameObject.Find("posTextRNM2");
                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                pos.fontStyle = FontStyles.Bold;
                pos.color = new Color32(246, 255, 0, 255);
                Scores = GameObject.Find("scoreTextRNM2");
                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                score.fontStyle = FontStyles.Bold;
                score.color = new Color32(246, 255, 0, 255);
                Names = GameObject.Find("nameTextRNM2");
                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                name.fontStyle = FontStyles.Bold;
                name.color = new Color32(246, 255, 0, 255);
                score.text = _LeaderboardMain.urScore.text;
                name.text = nameInput.text;
                PlayerPrefs.SetString("Scores2ndRNM", score.text);
                PlayerPrefs.SetString("Name2ndRNM", name.text);

                Scores = GameObject.Find("scoreTextRNM1");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores1stRNM");
                Names = GameObject.Find("nameTextRNM1");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name1stRNM");
                PlayerPrefs.SetString("Scores1stRNM", scoreNext.text);
                PlayerPrefs.SetString("Name1stRNM", nameNext.text);
            }
            else if (Globals.overallScore < scoreComparison)
            {
                Scores = GameObject.Find("scoreTextRNM3");
                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                score.text = PlayerPrefs.GetString("Scores3rdRNM");
                scoreText = score.text;
                scoreComparison = Convert.ToInt32(scoreText);
                Names = GameObject.Find("nameTextRNM3");
                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                name.text = PlayerPrefs.GetString("Name3rdRNM");

                //checking if #3
                if (Globals.overallScore > scoreComparison)
                {
                    //pushing scores lower
                    Scores = GameObject.Find("scoreTextRNM11");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores10thRNM");
                    Names = GameObject.Find("nameTextRNM11");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name10thRNM");
                    PlayerPrefs.SetString("Scores11thRNM", scoreNext.text);
                    PlayerPrefs.SetString("Name11thRNM", nameNext.text);

                    Scores = GameObject.Find("scoreTextRNM10");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores9thRNM");
                    Names = GameObject.Find("nameTextRNM10");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name9thRNM");
                    PlayerPrefs.SetString("Scores10thRNM", scoreNext.text);
                    PlayerPrefs.SetString("Name10thRNM", nameNext.text);

                    Scores = GameObject.Find("scoreTextRNM9");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores8thRNM");
                    Names = GameObject.Find("nameTextRNM8");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name8thRNM");
                    PlayerPrefs.SetString("Scores9thRNM", scoreNext.text);
                    PlayerPrefs.SetString("Name9thRNM", nameNext.text);

                    Scores = GameObject.Find("scoreTextRNM8");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores7thRNM");
                    Names = GameObject.Find("nameTextRNM8");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name7thRNM");
                    PlayerPrefs.SetString("Scores8thRNM", scoreNext.text);
                    PlayerPrefs.SetString("Name8thRNM", nameNext.text);

                    Scores = GameObject.Find("scoreTextRNM7");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores6thRNM");
                    Names = GameObject.Find("nameTextRNM7");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name6thRNM");
                    PlayerPrefs.SetString("Scores7thRNM", scoreNext.text);
                    PlayerPrefs.SetString("Name7thRNM", nameNext.text);

                    Scores = GameObject.Find("scoreTextRNM6");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores5thRNM");
                    Names = GameObject.Find("nameTextRNM6");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name5thRNM");
                    PlayerPrefs.SetString("Scores6thRNM", scoreNext.text);
                    PlayerPrefs.SetString("Name6thRNM", nameNext.text);

                    Scores = GameObject.Find("scoreTextRNM5");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores4thRNM");
                    Names = GameObject.Find("nameTextRNM5");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name4thRNM");
                    PlayerPrefs.SetString("Scores5thRNM", scoreNext.text);
                    PlayerPrefs.SetString("Name5thRNM", nameNext.text);

                    Scores = GameObject.Find("scoreTextRNM4");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores3rdRNM");
                    Names = GameObject.Find("nameTextRNM4");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name3rdRNM");
                    PlayerPrefs.SetString("Scores4thRNM", scoreNext.text);
                    PlayerPrefs.SetString("Name4thRNM", nameNext.text);

                    Pos = GameObject.Find("posTextRNM3");
                    pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                    pos.fontStyle = FontStyles.Bold;
                    pos.color = new Color32(246, 255, 0, 255);
                    Scores = GameObject.Find("scoreTextRNM3");
                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    score.fontStyle = FontStyles.Bold;
                    score.color = new Color32(246, 255, 0, 255);
                    Names = GameObject.Find("nameTextRNM3");
                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    name.fontStyle = FontStyles.Bold;
                    name.color = new Color32(246, 255, 0, 255);
                    score.text = _LeaderboardMain.urScore.text;
                    name.text = nameInput.text;
                    PlayerPrefs.SetString("Scores3rdRNM", score.text);
                    PlayerPrefs.SetString("Name3rdRNM", name.text);

                    Scores = GameObject.Find("scoreTextRNM2");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores2ndRNM");
                    Names = GameObject.Find("nameTextRNM2");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name2ndRNM");
                    PlayerPrefs.SetString("Scores2ndRNM", scoreNext.text);
                    PlayerPrefs.SetString("Name2ndRNM", nameNext.text);

                    Scores = GameObject.Find("scoreTextRNM1");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores1stRNM");
                    Names = GameObject.Find("nameTextRNM1");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name1stRNM");
                    PlayerPrefs.SetString("Scores1stRNM", scoreNext.text);
                    PlayerPrefs.SetString("Name1stRNM", nameNext.text);
                }
                else if (Globals.overallScore < scoreComparison)
                {
                    Scores = GameObject.Find("scoreTextRNM4");
                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    score.text = PlayerPrefs.GetString("Scores4thRNM");
                    scoreText = score.text;
                    scoreComparison = Convert.ToInt32(scoreText);
                    Names = GameObject.Find("nameTextRNM4");
                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    name.text = PlayerPrefs.GetString("Name4thRNM");

                    //checking if #4
                    if (Globals.overallScore > scoreComparison)
                    {
                        //pushing scores lower
                        Scores = GameObject.Find("scoreTextRNM11");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores10thRNM");
                        Names = GameObject.Find("nameTextRNM11");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name10thRNM");
                        PlayerPrefs.SetString("Scores11thRNM", scoreNext.text);
                        PlayerPrefs.SetString("Name11thRNM", nameNext.text);

                        Scores = GameObject.Find("scoreTextRNM10");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores9thRNM");
                        Names = GameObject.Find("nameTextRNM10");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name9thRNM");
                        PlayerPrefs.SetString("Scores10thRNM", scoreNext.text);
                        PlayerPrefs.SetString("Name10thRNM", nameNext.text);

                        Scores = GameObject.Find("scoreTextRNM9");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores8thRNM");
                        Names = GameObject.Find("nameTextRNM9");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name8thRNM");
                        PlayerPrefs.SetString("Scores9thRNM", scoreNext.text);
                        PlayerPrefs.SetString("Name9thRNM", nameNext.text);

                        Scores = GameObject.Find("scoreTextRNM8");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores7thRNM");
                        Names = GameObject.Find("nameTextRNM8");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name7thRNM");
                        PlayerPrefs.SetString("Scores8thRNM", scoreNext.text);
                        PlayerPrefs.SetString("Name8thRNM", nameNext.text);

                        Scores = GameObject.Find("scoreTextRNM7");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores6thRNM");
                        Names = GameObject.Find("nameTextRNM7");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name6thRNM");
                        PlayerPrefs.SetString("Scores7thRNM", scoreNext.text);
                        PlayerPrefs.SetString("Name7thRNM", nameNext.text);

                        Scores = GameObject.Find("scoreTextRNM6");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores5thRNM");
                        Names = GameObject.Find("nameTextRNM6");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name5thRNM");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        PlayerPrefs.SetString("Scores6thRNM", scoreNext.text);
                        PlayerPrefs.SetString("Name6thRNM", nameNext.text);

                        Scores = GameObject.Find("scoreTextRNM5");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores4thRNM");
                        Names = GameObject.Find("nameTextRNM5");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name4thRNM");
                        PlayerPrefs.SetString("Scores5thRNM", scoreNext.text);
                        PlayerPrefs.SetString("Name5thRNM", nameNext.text);

                        Pos = GameObject.Find("posTextRNM4");
                        pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                        pos.fontStyle = FontStyles.Bold;
                        pos.color = new Color32(246, 255, 0, 255);
                        Scores = GameObject.Find("scoreTextRNM4");
                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        score.fontStyle = FontStyles.Bold;
                        score.color = new Color32(246, 255, 0, 255);
                        Names = GameObject.Find("nameTextRNM4");
                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        name.fontStyle = FontStyles.Bold;
                        name.color = new Color32(246, 255, 0, 255);
                        score.text = _LeaderboardMain.urScore.text;
                        name.text = nameInput.text;
                        PlayerPrefs.SetString("Scores4thRNM", score.text);
                        PlayerPrefs.SetString("Name4thRNM", name.text);

                        Scores = GameObject.Find("scoreTextRNM3");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores3rdRNM");
                        Names = GameObject.Find("nameTextRNM3");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name3rdRNM");
                        PlayerPrefs.SetString("Scores3rdRNM", scoreNext.text);
                        PlayerPrefs.SetString("Name3rdRNM", nameNext.text);

                        Scores = GameObject.Find("scoreTextRNM2");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores2ndRNM");
                        Names = GameObject.Find("nameTextRNM2");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name2ndRNM");
                        PlayerPrefs.SetString("Scores2ndRNM", scoreNext.text);
                        PlayerPrefs.SetString("Name2ndRNM", nameNext.text);

                        Scores = GameObject.Find("scoreTextRNM1");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores1stRNM");
                        Names = GameObject.Find("nameTextRNM1");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name1stRNM");
                        PlayerPrefs.SetString("Scores1stRNM", scoreNext.text);
                        PlayerPrefs.SetString("Name1stRNM", nameNext.text);
                    }
                    else if (Globals.overallScore < scoreComparison)
                    {
                        Scores = GameObject.Find("scoreTextRNM5");
                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        score.text = PlayerPrefs.GetString("Scores5thRNM");
                        scoreText = score.text;
                        scoreComparison = Convert.ToInt32(scoreText);
                        Names = GameObject.Find("nameTextRNM5");
                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        name.text = PlayerPrefs.GetString("Name4thRNM");

                        //checking if #5
                        if (Globals.overallScore > scoreComparison)
                        {
                            //pushing scores lower
                            Scores = GameObject.Find("scoreTextRNM11");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores10thRNM");
                            Names = GameObject.Find("nameTextRNM11");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name10thRNM");
                            PlayerPrefs.SetString("Scores11thRNM", scoreNext.text);
                            PlayerPrefs.SetString("Name11thRNM", nameNext.text);

                            Scores = GameObject.Find("scoreTextRNM10");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores9thRNM");
                            Names = GameObject.Find("nameTextRNM10");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name9thRNM");
                            PlayerPrefs.SetString("Scores10thRNM", scoreNext.text);
                            PlayerPrefs.SetString("Name10thRNM", nameNext.text);

                            Scores = GameObject.Find("scoreTextRNM9");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores8thRNM");
                            Names = GameObject.Find("nameTextRNM9");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name8thRNM");
                            PlayerPrefs.SetString("Scores9thRNM", scoreNext.text);
                            PlayerPrefs.SetString("Name9thRNM", nameNext.text);

                            Scores = GameObject.Find("scoreTextRNM8");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores7thRNM");
                            Names = GameObject.Find("nameTextRNM8");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name7thRNM");
                            PlayerPrefs.SetString("Scores8thRNM", scoreNext.text);
                            PlayerPrefs.SetString("Name8thRNM", nameNext.text);

                            Scores = GameObject.Find("scoreTextRNM7");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores6thRNM");
                            Names = GameObject.Find("nameTextRNM7");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name6thRNM");
                            PlayerPrefs.SetString("Scores7thRNM", scoreNext.text);
                            PlayerPrefs.SetString("Name7thRNM", nameNext.text);

                            Scores = GameObject.Find("scoreTextRNM6");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores5thRNM");
                            Names = GameObject.Find("nameTextRNM6");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name5thRNM");
                            PlayerPrefs.SetString("Scores6thRNM", scoreNext.text);
                            PlayerPrefs.SetString("Name6thRNM", nameNext.text);

                            Pos = GameObject.Find("posTextRNM5");
                            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                            pos.fontStyle = FontStyles.Bold;
                            pos.color = new Color32(246, 255, 0, 255);
                            Scores = GameObject.Find("scoreTextRNM5");
                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            score.fontStyle = FontStyles.Bold;
                            score.color = new Color32(246, 255, 0, 255);
                            Names = GameObject.Find("nameTextRNM5");
                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            name.fontStyle = FontStyles.Bold;
                            name.color = new Color32(246, 255, 0, 255);
                            score.text = _LeaderboardMain.urScore.text;
                            name.text = nameInput.text;
                            PlayerPrefs.SetString("Scores5thRNM", score.text);
                            PlayerPrefs.SetString("Name5thRNM", name.text);

                            Scores = GameObject.Find("scoreTextRNM4");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores4thRNM");
                            Names = GameObject.Find("nameTextRNM4");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name4thRNM");
                            PlayerPrefs.SetString("Scores4thRNM", scoreNext.text);
                            PlayerPrefs.SetString("Name4thRNM", nameNext.text);

                            Scores = GameObject.Find("scoreTextRNM3");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores3rdRNM");
                            Names = GameObject.Find("nameTextRNM3");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name3rdRNM");
                            PlayerPrefs.SetString("Scores3rdRNM", scoreNext.text);
                            PlayerPrefs.SetString("Name3rdRNM", nameNext.text);

                            Scores = GameObject.Find("scoreTextRNM2");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores2ndRNM");
                            Names = GameObject.Find("nameTextRNM2");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name2ndRNM");
                            PlayerPrefs.SetString("Scores2ndRNM", scoreNext.text);
                            PlayerPrefs.SetString("Name2ndRNM", nameNext.text);

                            Scores = GameObject.Find("scoreTextRNM1");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores1stRNM");
                            Names = GameObject.Find("nameTextRNM1");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name1stRNM");
                            PlayerPrefs.SetString("Scores1stRNM", scoreNext.text);
                            PlayerPrefs.SetString("Name1stRNM", nameNext.text);
                        }
                        else if (Globals.overallScore < scoreComparison)
                        {
                            Scores = GameObject.Find("scoreTextRNM6");
                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            score.text = PlayerPrefs.GetString("Scores6thRNM");
                            scoreText = score.text;
                            scoreComparison = Convert.ToInt32(scoreText);
                            Names = GameObject.Find("nameTextRNM6");
                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            name.text = PlayerPrefs.GetString("Name6thRNM");

                            //checking if #6
                            if (Globals.overallScore > scoreComparison)
                            {
                                //pushing scores lower
                                Scores = GameObject.Find("scoreTextRNM11");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores10thRNM");
                                Names = GameObject.Find("nameTextRNM11");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name10thRNM");
                                PlayerPrefs.SetString("Scores11thRNM", scoreNext.text);
                                PlayerPrefs.SetString("Name11thRNM", nameNext.text);

                                Scores = GameObject.Find("scoreTextRNM10");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores9thRNM");
                                Names = GameObject.Find("nameTextRNM10");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name9thRNM");
                                PlayerPrefs.SetString("Scores10thRNM", scoreNext.text);
                                PlayerPrefs.SetString("Name10thRNM", nameNext.text);

                                Scores = GameObject.Find("scoreTextRNM9");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores8thRNM");
                                Names = GameObject.Find("nameTextRNM9");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name8thRNM");
                                PlayerPrefs.SetString("Scores9thRNM", scoreNext.text);
                                PlayerPrefs.SetString("Name9thRNM", nameNext.text);

                                Scores = GameObject.Find("scoreTextRNM8");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores7thRNM");
                                Names = GameObject.Find("nameTextRNM8");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name7thRNM");
                                PlayerPrefs.SetString("Scores8thRNM", scoreNext.text);
                                PlayerPrefs.SetString("Name8thRNM", nameNext.text);

                                Scores = GameObject.Find("scoreTextRNM7");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores6thRNM");
                                Names = GameObject.Find("nameTextRNM7");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name6thRNM");
                                PlayerPrefs.SetString("Scores7thRNM", scoreNext.text);
                                PlayerPrefs.SetString("Name7thRNM", nameNext.text);

                                Pos = GameObject.Find("posTextRNM6");
                                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                pos.fontStyle = FontStyles.Bold;
                                pos.color = new Color32(246, 255, 0, 255);
                                Scores = GameObject.Find("scoreTextRNM6");
                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                score.fontStyle = FontStyles.Bold;
                                score.color = new Color32(246, 255, 0, 255);
                                Names = GameObject.Find("nameTextRNM6");
                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                name.fontStyle = FontStyles.Bold;
                                name.color = new Color32(246, 255, 0, 255);
                                score.text = _LeaderboardMain.urScore.text;
                                name.text = nameInput.text;
                                PlayerPrefs.SetString("Scores6thRNM", score.text);
                                PlayerPrefs.SetString("Name6thRNM", name.text);

                                Scores = GameObject.Find("scoreTextRNM5");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores5thRNM");
                                Names = GameObject.Find("nameTextRNM5");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name5thRNM");
                                PlayerPrefs.SetString("Scores5thRNM", scoreNext.text);
                                PlayerPrefs.SetString("Name5thRNM", nameNext.text);

                                Scores = GameObject.Find("scoreTextRNM4");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores4thRNM");
                                Names = GameObject.Find("nameTextRNM4");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name4thRNM");
                                PlayerPrefs.SetString("Scores4thRNM", scoreNext.text);
                                PlayerPrefs.SetString("Name4thRNM", nameNext.text);

                                Scores = GameObject.Find("scoreTextRNM3");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores3rdRNM");
                                Names = GameObject.Find("nameTextRNM3");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name3rdRNM");
                                PlayerPrefs.SetString("Scores3rdRNM", scoreNext.text);
                                PlayerPrefs.SetString("Name3rdRNM", nameNext.text);

                                Scores = GameObject.Find("scoreTextRNM2");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores2ndRNM");
                                Names = GameObject.Find("nameTextRNM2");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name2ndRNM");
                                PlayerPrefs.SetString("Scores2ndRNM", scoreNext.text);
                                PlayerPrefs.SetString("Name2ndRNM", nameNext.text);

                                Scores = GameObject.Find("scoreTextRNM1");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores1stRNM");
                                Names = GameObject.Find("nameTextRNM1");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name1stRNM");
                                PlayerPrefs.SetString("Scores1stRNM", scoreNext.text);
                                PlayerPrefs.SetString("Name1stRNM", nameNext.text);
                            }
                            else if (Globals.overallScore < scoreComparison)
                            {
                                Scores = GameObject.Find("scoreTextRNM7");
                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                score.text = PlayerPrefs.GetString("Scores7thRNM");
                                scoreText = score.text;
                                scoreComparison = Convert.ToInt32(scoreText);
                                Names = GameObject.Find("nameTextRNM7");
                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                name.text = PlayerPrefs.GetString("Name7thRNM");

                                //checking if #7
                                if (Globals.overallScore > scoreComparison)
                                {
                                    //pushing scores lower
                                    Scores = GameObject.Find("scoreTextRNM11");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores10thRNM");
                                    Names = GameObject.Find("nameTextRNM11");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name10thRNM");
                                    PlayerPrefs.SetString("Scores11thRNM", scoreNext.text);
                                    PlayerPrefs.SetString("Name11thRNM", nameNext.text);

                                    Scores = GameObject.Find("scoreTextRNM10");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores9thRNM");
                                    Names = GameObject.Find("nameTextRNM10");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name9thRNM");
                                    PlayerPrefs.SetString("Scores10thRNM", scoreNext.text);
                                    PlayerPrefs.SetString("Name10thRNM", nameNext.text);

                                    Scores = GameObject.Find("scoreTextRNM9");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores8thRNM");
                                    Names = GameObject.Find("nameTextRNM9");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name8thRNM");
                                    PlayerPrefs.SetString("Scores9thRNM", scoreNext.text);
                                    PlayerPrefs.SetString("Name9thRNM", nameNext.text);

                                    Scores = GameObject.Find("scoreTextRNM8");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores7thRNM");
                                    Names = GameObject.Find("nameTextRNM8");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name7thRNM");
                                    PlayerPrefs.SetString("Scores8thRNM", scoreNext.text);
                                    PlayerPrefs.SetString("Name8thRNM", nameNext.text);

                                    Pos = GameObject.Find("posTextRNM7");
                                    pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                    pos.fontStyle = FontStyles.Bold;
                                    pos.color = new Color32(246, 255, 0, 255);
                                    Scores = GameObject.Find("scoreTextRNM7");
                                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    score.fontStyle = FontStyles.Bold;
                                    score.color = new Color32(246, 255, 0, 255);
                                    Names = GameObject.Find("nameTextRNM7");
                                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    name.fontStyle = FontStyles.Bold;
                                    name.color = new Color32(246, 255, 0, 255);
                                    score.text = _LeaderboardMain.urScore.text;
                                    name.text = nameInput.text;
                                    PlayerPrefs.SetString("Scores7thRNM", score.text);
                                    PlayerPrefs.SetString("Name7thRNM", name.text);

                                    Scores = GameObject.Find("scoreTextRNM6");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores6thRNM");
                                    Names = GameObject.Find("nameTextRNM6");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name6thRNM");
                                    PlayerPrefs.SetString("Scores6thRNM", scoreNext.text);
                                    PlayerPrefs.SetString("Name6thRNM", nameNext.text);

                                    Scores = GameObject.Find("scoreTextRNM5");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores5thRNM");
                                    Names = GameObject.Find("nameTextRNM5");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name5thRNM");
                                    PlayerPrefs.SetString("Scores5thRNM", scoreNext.text);
                                    PlayerPrefs.SetString("Name5thRNM", nameNext.text);

                                    Scores = GameObject.Find("scoreTextRNM4");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores4thRNM");
                                    Names = GameObject.Find("nameTextRNM4");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name4thRNM");
                                    PlayerPrefs.SetString("Scores4thRNM", scoreNext.text);
                                    PlayerPrefs.SetString("Name4thRNM", nameNext.text);

                                    Scores = GameObject.Find("scoreTextRNM3");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores3rdRNM");
                                    Names = GameObject.Find("nameTextRNM3");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name3rdRNM");
                                    PlayerPrefs.SetString("Scores3rdRNM", scoreNext.text);
                                    PlayerPrefs.SetString("Name3rdRNM", nameNext.text);

                                    Scores = GameObject.Find("scoreTextRNM2");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores2ndRNM");
                                    Names = GameObject.Find("nameTextRNM2");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name2ndRNM");
                                    PlayerPrefs.SetString("Scores2ndRNM", scoreNext.text);
                                    PlayerPrefs.SetString("Name2ndRNM", nameNext.text);

                                    Scores = GameObject.Find("scoreTextRNM1");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores1stRNM");
                                    Names = GameObject.Find("nameTextRNM1");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name1stRNM");
                                    PlayerPrefs.SetString("Scores1stRNM", scoreNext.text);
                                    PlayerPrefs.SetString("Name1stRNM", nameNext.text);
                                }
                                else if (Globals.overallScore < scoreComparison)
                                {
                                    Scores = GameObject.Find("scoreTextRNM8");
                                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    score.text = PlayerPrefs.GetString("Scores8thRNM");
                                    scoreText = score.text;
                                    scoreComparison = Convert.ToInt32(scoreText);
                                    Names = GameObject.Find("nameTextRNM8");
                                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    name.text = PlayerPrefs.GetString("Name8thRNM");

                                    //checking if #8
                                    if (Globals.overallScore > scoreComparison)
                                    {
                                        //pushing scores lower
                                        Scores = GameObject.Find("scoreTextRNM11");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores10thRNM");
                                        Names = GameObject.Find("nameTextRNM11");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name10thRNM");
                                        PlayerPrefs.SetString("Scores11thRNM", scoreNext.text);
                                        PlayerPrefs.SetString("Name11thRNM", nameNext.text);

                                        Scores = GameObject.Find("scoreTextRNM10");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores9thRNM");
                                        Names = GameObject.Find("nameTextRNM10");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name9thRNM");
                                        PlayerPrefs.SetString("Scores10thRNM", scoreNext.text);
                                        PlayerPrefs.SetString("Name10thRNM", nameNext.text);

                                        Scores = GameObject.Find("scoreTextRNM9");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores8thRNM");
                                        Names = GameObject.Find("nameTextRNM9");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name8thRNM");
                                        PlayerPrefs.SetString("Scores9thRNM", scoreNext.text);
                                        PlayerPrefs.SetString("Name9thRNM", nameNext.text);

                                        Pos = GameObject.Find("posTextRNM8");
                                        pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                        pos.fontStyle = FontStyles.Bold;
                                        pos.color = new Color32(246, 255, 0, 255);
                                        Scores = GameObject.Find("scoreTextRNM8");
                                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        score.fontStyle = FontStyles.Bold;
                                        score.color = new Color32(246, 255, 0, 255);
                                        Names = GameObject.Find("nameTextRNM8");
                                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        name.fontStyle = FontStyles.Bold;
                                        name.color = new Color32(246, 255, 0, 255);
                                        score.text = _LeaderboardMain.urScore.text;
                                        name.text = nameInput.text;
                                        PlayerPrefs.SetString("Scores8thRNM", score.text);
                                        PlayerPrefs.SetString("Name8thRNM", name.text);

                                        Scores = GameObject.Find("scoreTextRNM7");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores7thRNM");
                                        Names = GameObject.Find("nameTextRNM7");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name7thRNM");
                                        PlayerPrefs.SetString("Scores7thRNM", scoreNext.text);
                                        PlayerPrefs.SetString("Name7thRNM", nameNext.text);

                                        Scores = GameObject.Find("scoreTextRNM6");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores6thRNM");
                                        Names = GameObject.Find("nameTextRNM6");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name6thRNM");
                                        PlayerPrefs.SetString("Scores6thRNM", scoreNext.text);
                                        PlayerPrefs.SetString("Name6thRNM", nameNext.text);

                                        Scores = GameObject.Find("scoreTextRNM5");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores5thRNM");
                                        Names = GameObject.Find("nameTextRNM5");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name5thRNM");
                                        PlayerPrefs.SetString("Scores5thRNM", scoreNext.text);
                                        PlayerPrefs.SetString("Name5thRNM", nameNext.text);

                                        Scores = GameObject.Find("scoreTextRNM4");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores4thRNM");
                                        Names = GameObject.Find("nameTextRNM4");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name4thRNM");
                                        PlayerPrefs.SetString("Scores4thRNM", scoreNext.text);
                                        PlayerPrefs.SetString("Name4thRNM", nameNext.text);

                                        Scores = GameObject.Find("scoreTextRNM3");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores3rdRNM");
                                        Names = GameObject.Find("nameTextRNM3");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name3rdRNM");
                                        PlayerPrefs.SetString("Scores3rdRNM", scoreNext.text);
                                        PlayerPrefs.SetString("Name3rdRNM", nameNext.text);

                                        Scores = GameObject.Find("scoreTextRNM2");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores2ndRNM");
                                        Names = GameObject.Find("nameTextRNM2");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name2ndRNM");
                                        PlayerPrefs.SetString("Scores2ndRNM", scoreNext.text);
                                        PlayerPrefs.SetString("Name2ndRNM", nameNext.text);

                                        Scores = GameObject.Find("scoreTextRNM1");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores1stRNM");
                                        Names = GameObject.Find("nameTextRNM1");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name1stRNM");
                                        PlayerPrefs.SetString("Scores1stRNM", scoreNext.text);
                                        PlayerPrefs.SetString("Name1stRNM", nameNext.text);
                                    }
                                    else if (Globals.overallScore < scoreComparison)
                                    {
                                        Scores = GameObject.Find("scoreTextRNM9");
                                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        score.text = PlayerPrefs.GetString("Scores9thRNM");
                                        scoreText = score.text;
                                        scoreComparison = Convert.ToInt32(scoreText); 
                                        Names = GameObject.Find("nameTextRNM9");
                                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        name.text = PlayerPrefs.GetString("Name9thRNM");

                                        //checking if #9
                                        if (Globals.overallScore > scoreComparison)
                                        {
                                            //pushing scores lower
                                            Scores = GameObject.Find("scoreTextRNM11");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores10thRNM");
                                            Names = GameObject.Find("nameTextRNM11");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name10thRNM");
                                            PlayerPrefs.SetString("Scores11thRNM", scoreNext.text);
                                            PlayerPrefs.SetString("Name11thRNM", nameNext.text);

                                            Scores = GameObject.Find("scoreTextRNM10");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores9thRNM");
                                            Names = GameObject.Find("nameTextRNM10");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name9thRNM");
                                            PlayerPrefs.SetString("Scores10thRNM", scoreNext.text);
                                            PlayerPrefs.SetString("Name10thRNM", nameNext.text);

                                            Pos = GameObject.Find("posTextRNM9");
                                            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                            pos.fontStyle = FontStyles.Bold;
                                            pos.color = new Color32(246, 255, 0, 255);
                                            Scores = GameObject.Find("scoreTextRNM9");
                                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            score.fontStyle = FontStyles.Bold;
                                            score.color = new Color32(246, 255, 0, 255);
                                            Names = GameObject.Find("nameTextRNM9");
                                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            name.fontStyle = FontStyles.Bold;
                                            name.color = new Color32(246, 255, 0, 255);
                                            score.text = _LeaderboardMain.urScore.text;
                                            name.text = nameInput.text;
                                            PlayerPrefs.SetString("Scores9thRNM", score.text);
                                            PlayerPrefs.SetString("Name9thRNM", name.text);

                                            Scores = GameObject.Find("scoreTextRNM8");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores8thRNM");
                                            Names = GameObject.Find("nameTextRNM8");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name8thRNM");
                                            PlayerPrefs.SetString("Scores8thRNM", scoreNext.text);
                                            PlayerPrefs.SetString("Name8thRNM", nameNext.text);

                                            Scores = GameObject.Find("scoreTextRNM7");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores7thRNM");
                                            Names = GameObject.Find("nameTextRNM7");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name7thRNM");
                                            PlayerPrefs.SetString("Scores7thRNM", scoreNext.text);
                                            PlayerPrefs.SetString("Name7thRNM", nameNext.text);

                                            Scores = GameObject.Find("scoreTextRNM6");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores6thRNM");
                                            Names = GameObject.Find("nameTextRNM6");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name6thRNM");
                                            PlayerPrefs.SetString("Scores6thRNM", scoreNext.text);
                                            PlayerPrefs.SetString("Name6thRNM", nameNext.text);

                                            Scores = GameObject.Find("scoreTextRNM5");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores5thRNM");
                                            Names = GameObject.Find("nameTextRNM5");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name5thRNM");
                                            PlayerPrefs.SetString("Scores5thRNM", scoreNext.text);
                                            PlayerPrefs.SetString("Name5thRNM", nameNext.text);

                                            Scores = GameObject.Find("scoreTextRNM4");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores4thRNM");
                                            Names = GameObject.Find("nameTextRNM4");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name4thRNM");
                                            PlayerPrefs.SetString("Scores4thRNM", scoreNext.text);
                                            PlayerPrefs.SetString("Name4th", nameNext.text);

                                            Scores = GameObject.Find("scoreTextRNM3");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores3rdRNM");
                                            Names = GameObject.Find("nameTextRNM3");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name3rdRNM");
                                            PlayerPrefs.SetString("Scores3rdRNM", scoreNext.text);
                                            PlayerPrefs.SetString("Name3rdRNM", nameNext.text);

                                            Scores = GameObject.Find("scoreTextRNM2");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores2ndRNM");
                                            Names = GameObject.Find("nameTextRNM2");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name2ndRNM");
                                            PlayerPrefs.SetString("Scores2ndRNM", scoreNext.text);
                                            PlayerPrefs.SetString("Name2ndRNM", nameNext.text);

                                            Scores = GameObject.Find("scoreTextRNM1");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores1stRNM");
                                            Names = GameObject.Find("nameTextRNM1");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name1stRNM");
                                            PlayerPrefs.SetString("Scores1stRNM", scoreNext.text);
                                            PlayerPrefs.SetString("Name1stRNM", nameNext.text);
                                        }
                                        else if (Globals.overallScore < scoreComparison)
                                        {
                                            Scores = GameObject.Find("scoreTextRNM10");
                                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            score.text = PlayerPrefs.GetString("Scores10thRNM");
                                            scoreText = score.text;
                                            scoreComparison = Convert.ToInt32(scoreText);
                                            Names = GameObject.Find("nameTextRNM10");
                                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            name.text = PlayerPrefs.GetString("Name10thRNM");

                                            //checking if #10
                                            if (Globals.overallScore > scoreComparison)
                                            {
                                                //pushing scores lower
                                                Scores = GameObject.Find("scoreTextRNM11");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores10thRNM");
                                                Names = GameObject.Find("nameTextRNM11");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name10thRNM");
                                                PlayerPrefs.SetString("Scores11thRNM", scoreNext.text);
                                                PlayerPrefs.SetString("Name11thRNM", nameNext.text);

                                                Pos = GameObject.Find("posTextRNM10");
                                                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                                pos.fontStyle = FontStyles.Bold;
                                                pos.color = new Color32(246, 255, 0, 255);
                                                Scores = GameObject.Find("scoreTextRNM10");
                                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                score.fontStyle = FontStyles.Bold;
                                                score.color = new Color32(246, 255, 0, 255);
                                                Names = GameObject.Find("nameTextRNM10");
                                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                name.fontStyle = FontStyles.Bold;
                                                name.color = new Color32(246, 255, 0, 255);
                                                score.text = _LeaderboardMain.urScore.text;
                                                name.text = nameInput.text;
                                                PlayerPrefs.SetString("Scores10thRNM", score.text);
                                                PlayerPrefs.SetString("Name10thRNM", name.text);

                                                Scores = GameObject.Find("scoreTextRNM9");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores9thRNM");
                                                Names = GameObject.Find("nameTextRNM9");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name9thRNM");
                                                PlayerPrefs.SetString("Scores9thRNM", scoreNext.text);
                                                PlayerPrefs.SetString("Name9thRNM", nameNext.text);

                                                Scores = GameObject.Find("scoreTextRNM8");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores8thRNM");
                                                Names = GameObject.Find("nameTextRNM8");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name8thRNM");
                                                PlayerPrefs.SetString("Scores8thRNM", scoreNext.text);
                                                PlayerPrefs.SetString("Name8thRNM", nameNext.text);

                                                Scores = GameObject.Find("scoreTextRNM7");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores7thRNM");
                                                Names = GameObject.Find("nameTextRNM7");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name7thRNM");
                                                PlayerPrefs.SetString("Scores7thRNM", scoreNext.text);
                                                PlayerPrefs.SetString("Name7thRNM", nameNext.text);

                                                Scores = GameObject.Find("scoreTextRNM6");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores6thRNM");
                                                Names = GameObject.Find("nameTextRNM6");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name6thRNM");
                                                PlayerPrefs.SetString("Scores6thRNM", scoreNext.text);
                                                PlayerPrefs.SetString("Name6thRNM", nameNext.text);

                                                Scores = GameObject.Find("scoreTextRNM5");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores5thRNM");
                                                Names = GameObject.Find("nameTextRNM5");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name5thRNM");
                                                PlayerPrefs.SetString("Scores5thRNM", scoreNext.text);
                                                PlayerPrefs.SetString("Name5thRNM", nameNext.text);

                                                Scores = GameObject.Find("scoreTextRNM4");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores4thRNM");
                                                Names = GameObject.Find("nameTextRNM4");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name4thRNM");
                                                PlayerPrefs.SetString("Scores4thRNM", scoreNext.text);
                                                PlayerPrefs.SetString("Name4thRNM", nameNext.text);

                                                Scores = GameObject.Find("scoreTextRNM3");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores3rdRNM");
                                                Names = GameObject.Find("nameTextRNM3");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name3rdRNM");
                                                PlayerPrefs.SetString("Scores3rdRNM", scoreNext.text);
                                                PlayerPrefs.SetString("Name3rdRNM", nameNext.text);

                                                Scores = GameObject.Find("scoreTextRNM2");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores2ndRNM");
                                                Names = GameObject.Find("nameTextRNM2");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name2ndRNM");
                                                PlayerPrefs.SetString("Scores2ndRNM", scoreNext.text);
                                                PlayerPrefs.SetString("Name2ndRNM", nameNext.text);

                                                Scores = GameObject.Find("scoreTextRNM1");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores1stRNM");
                                                Names = GameObject.Find("nameTextRNM1");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name1stRNM");
                                                PlayerPrefs.SetString("Scores1stRNM", scoreNext.text);
                                                PlayerPrefs.SetString("Name1stRNM", nameNext.text);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        PlayerPrefs.Save();
    }

    public void RNMViewing()
    {
        Scores = GameObject.Find("scoreTextRNM1");
        score = Scores.gameObject.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores1stRNM");
        Names = GameObject.Find("nameTextRNM1");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name1stRNM");

        Scores = GameObject.Find("scoreTextRNM2");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores2ndRNM");
        Names = GameObject.Find("nameTextRNM2");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name2ndRNM");

        Scores = GameObject.Find("scoreTextRNM3");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores3rdRNM");
        Names = GameObject.Find("nameTextRNM3");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name3rdRNM");

        Scores = GameObject.Find("scoreTextRNM4");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores4thRNM");
        Names = GameObject.Find("nameTextRNM4");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name4thRNM");

        Scores = GameObject.Find("scoreTextRNM5");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores5thRNM");
        Names = GameObject.Find("nameTextRNM5");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name5thRNM");

        Scores = GameObject.Find("scoreTextRNM6");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores6thRNM");
        Names = GameObject.Find("nameTextRNM6");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name6thRNM");

        Scores = GameObject.Find("scoreTextRNM7");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores7thRNM");
        Names = GameObject.Find("nameTextRNM7");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name7thRNM");

        Scores = GameObject.Find("scoreTextRNM8");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores8thRNM");
        Names = GameObject.Find("nameTextRNM8");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name8thRNM");

        Scores = GameObject.Find("scoreTextRNM9");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores9thRNM");
        Names = GameObject.Find("nameTextRNM9");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name9thRNM");

        Scores = GameObject.Find("scoreTextRNM10");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores10thRNM");
        Names = GameObject.Find("nameTextRNM10");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name10thRNM");
    }
}
