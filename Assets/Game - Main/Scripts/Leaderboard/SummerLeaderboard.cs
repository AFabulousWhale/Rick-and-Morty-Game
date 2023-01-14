using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using TMPro;

public class SummerLeaderboard : MonoBehaviour
{
    public int RandomI;
    public TMPro.TextMeshProUGUI scoreNext, nameNext, score, name, pos;
    public TMPro.TMP_InputField nameInput;

    public GameObject Scores, Names, Pos;

    public int scoreComparison;

    public AudioSource buttonS;

    public LeaderboardMain _LeaderboardMain;
    void Start()
    {
        RandomI = UnityEngine.Random.Range(0, 5);
    }

    public void SummerPlacement()
    {
        Scores = GameObject.Find("scoreTextS1");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores1stS");
        scoreComparison = Convert.ToInt32(score.text);
        Names = GameObject.Find("nameTextS1");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name1stS");

        //checking if #1
        if (Globals.overallScore > scoreComparison)
        {
            //pushing scores lower
            Scores = GameObject.Find("scoreTextS11");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores10thS");
            Names = GameObject.Find("nameTextS11");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name10thS");
            PlayerPrefs.SetString("Scores11thS", scoreNext.text);
            PlayerPrefs.SetString("Name11thS", nameNext.text);

            Scores = GameObject.Find("scoreTextS10");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores9thS");
            Names = GameObject.Find("nameTextS10");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name9thS");
            PlayerPrefs.SetString("Scores10thS", scoreNext.text);
            PlayerPrefs.SetString("Name10thS", nameNext.text);

            Scores = GameObject.Find("scoreTextS9");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores8thS");
            Names = GameObject.Find("nameTextS9");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name8thS");
            PlayerPrefs.SetString("Scores9thS", scoreNext.text);
            PlayerPrefs.SetString("Name9thS", nameNext.text);

            Scores = GameObject.Find("scoreTextS8");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores7thS");
            Names = GameObject.Find("nameTextS8");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name7thS");
            PlayerPrefs.SetString("Scores8thS", scoreNext.text);
            PlayerPrefs.SetString("Name8thS", nameNext.text);

            Scores = GameObject.Find("scoreTextS7");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores6thS");
            Names = GameObject.Find("nameTextS7");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name6thS");
            PlayerPrefs.SetString("Scores7thS", scoreNext.text);
            PlayerPrefs.SetString("Name7thS", nameNext.text);

            Scores = GameObject.Find("scoreTextS6");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores5thS");
            Names = GameObject.Find("nameTextS6");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name5thS");
            PlayerPrefs.SetString("Scores6thS", scoreNext.text);
            PlayerPrefs.SetString("Name6thS", nameNext.text);

            Scores = GameObject.Find("scoreTextS5");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores4thS");
            Names = GameObject.Find("nameTextS5");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name4thS");
            PlayerPrefs.SetString("Scores5thS", scoreNext.text);
            PlayerPrefs.SetString("Name5thS", nameNext.text);

            Scores = GameObject.Find("scoreTextS4");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores3rdS");
            Names = GameObject.Find("nameTextS4");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name3rdS");
            PlayerPrefs.SetString("Scores4thS", scoreNext.text);
            PlayerPrefs.SetString("Name4thS", nameNext.text);

            Scores = GameObject.Find("scoreTextS3");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores2ndS");
            Names = GameObject.Find("nameTextS3");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name2ndS");
            PlayerPrefs.SetString("Scores3rdS", scoreNext.text);
            PlayerPrefs.SetString("Name3rdS", nameNext.text);

            Scores = GameObject.Find("scoreTextS2");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores1stS");
            Names = GameObject.Find("nameTextS2");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name1stS");
            PlayerPrefs.SetString("Scores2ndS", scoreNext.text);
            PlayerPrefs.SetString("Name2ndS", nameNext.text);

            Pos = GameObject.Find("posTextS1");
            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
            pos.fontStyle = FontStyles.Bold;
            pos.color = new Color32(246, 255, 0, 255);
            Scores = GameObject.Find("scoreTextS1");
            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            score.fontStyle = FontStyles.Bold;
            score.color = new Color32(246, 255, 0, 255);
            Names = GameObject.Find("nameTextS1");
            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
            name.fontStyle = FontStyles.Bold;
            name.color = new Color32(246, 255, 0, 255);
            score.text = _LeaderboardMain.urScore.text;
            name.text = nameInput.text;
            PlayerPrefs.SetString("Scores1stS", score.text);
            PlayerPrefs.SetString("Name1stS", name.text);
        }
        else if (Globals.overallScore < scoreComparison)
        {
            Scores = GameObject.Find("scoreTextS2");
            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            score.text = PlayerPrefs.GetString("Scores2ndS");
            scoreComparison = Convert.ToInt32(score.text);
            Names = GameObject.Find("nameTextS2");
            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
            name.text = PlayerPrefs.GetString("Name2ndS");

            //checking if #2
            if (Globals.overallScore > scoreComparison)
            {
                //pushing scores lower
                Scores = GameObject.Find("scoreTextS11");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores10thS");
                Names = GameObject.Find("nameTextS11");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name10thS");
                PlayerPrefs.SetString("Scores11thS", scoreNext.text);
                PlayerPrefs.SetString("Name11thS", nameNext.text);

                Scores = GameObject.Find("scoreTextS10");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores9thS");
                Names = GameObject.Find("nameTextS10");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name9thS");
                PlayerPrefs.SetString("Scores10thS", scoreNext.text);
                PlayerPrefs.SetString("Name10thS", nameNext.text);

                Scores = GameObject.Find("scoreTextS9");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores8thS");
                Names = GameObject.Find("nameTextS9");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name8thS");
                PlayerPrefs.SetString("Scores9thS", scoreNext.text);
                PlayerPrefs.SetString("Name9thS", nameNext.text);

                Scores = GameObject.Find("scoreTextS8");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores7thS");
                Names = GameObject.Find("nameTextS8");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name7thS");
                PlayerPrefs.SetString("Scores8thS", scoreNext.text);
                PlayerPrefs.SetString("Name8thS", nameNext.text);

                Scores = GameObject.Find("scoreTextS7");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores6thS");
                Names = GameObject.Find("nameTextS7");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name6thS");
                PlayerPrefs.SetString("Scores7thS", scoreNext.text);
                PlayerPrefs.SetString("Name7thS", nameNext.text);

                Scores = GameObject.Find("scoreTextS6");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores5thS");
                Names = GameObject.Find("nameTextS6");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name5thS");
                PlayerPrefs.SetString("Scores6thS", scoreNext.text);
                PlayerPrefs.SetString("Name6thS", nameNext.text);

                Scores = GameObject.Find("scoreTextS5");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores4thS");
                Names = GameObject.Find("nameTextS5");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name4thS");
                PlayerPrefs.SetString("Scores5thS", scoreNext.text);
                PlayerPrefs.SetString("Name5thS", nameNext.text);

                Scores = GameObject.Find("scoreTextS4");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores3rdS");
                Names = GameObject.Find("nameTextS4");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name3rdS");
                PlayerPrefs.SetString("Scores4thS", scoreNext.text);
                PlayerPrefs.SetString("Name4thS", nameNext.text);

                Scores = GameObject.Find("scoreTextS3");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores2ndS");
                Names = GameObject.Find("nameTextS3");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name2ndS");
                PlayerPrefs.SetString("Scores3rdS", scoreNext.text);
                PlayerPrefs.SetString("Name3rdS", nameNext.text);

                Pos = GameObject.Find("posTextS2");
                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                pos.fontStyle = FontStyles.Bold;
                pos.color = new Color32(246, 255, 0, 255);
                Scores = GameObject.Find("scoreTextS2");
                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                score.fontStyle = FontStyles.Bold;
                score.color = new Color32(246, 255, 0, 255);
                Names = GameObject.Find("nameTextS2");
                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                name.fontStyle = FontStyles.Bold;
                name.color = new Color32(246, 255, 0, 255);
                score.text = _LeaderboardMain.urScore.text;
                name.text = nameInput.text;
                PlayerPrefs.SetString("Scores2ndS", score.text);
                PlayerPrefs.SetString("Name2ndS", name.text);

                Scores = GameObject.Find("scoreTextS1");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores1stS");
                Names = GameObject.Find("nameTextS1");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name1stS");
                PlayerPrefs.SetString("Scores1stS", scoreNext.text);
                PlayerPrefs.SetString("Name1stS", nameNext.text);
            }
            else if (Globals.overallScore < scoreComparison)
            {
                Scores = GameObject.Find("scoreTextS3");
                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                score.text = PlayerPrefs.GetString("Scores3rdS");
                scoreComparison = Convert.ToInt32(score.text);
                Names = GameObject.Find("nameTextS3");
                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                name.text = PlayerPrefs.GetString("Name3rdS");

                //checking if #3
                if (Globals.overallScore > scoreComparison)
                {
                    //pushing scores lower
                    Scores = GameObject.Find("scoreTextS11");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores10thS");
                    Names = GameObject.Find("nameTextS11");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name10thS");
                    PlayerPrefs.SetString("Scores11thS", scoreNext.text);
                    PlayerPrefs.SetString("Name11thS", nameNext.text);

                    Scores = GameObject.Find("scoreTextS10");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores9thS");
                    Names = GameObject.Find("nameTextS10");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name9thS");
                    PlayerPrefs.SetString("Scores10thS", scoreNext.text);
                    PlayerPrefs.SetString("Name10thS", nameNext.text);

                    Scores = GameObject.Find("scoreTextS9");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores8thS");
                    Names = GameObject.Find("nameTextS8");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name8thS");
                    PlayerPrefs.SetString("Scores9thS", scoreNext.text);
                    PlayerPrefs.SetString("Name9thS", nameNext.text);

                    Scores = GameObject.Find("scoreTextS8");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores7thS");
                    Names = GameObject.Find("nameTextS8");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name7thS");
                    PlayerPrefs.SetString("Scores8thS", scoreNext.text);
                    PlayerPrefs.SetString("Name8thS", nameNext.text);

                    Scores = GameObject.Find("scoreTextS7");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores6thS");
                    Names = GameObject.Find("nameTextS7");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name6thS");
                    PlayerPrefs.SetString("Scores7thS", scoreNext.text);
                    PlayerPrefs.SetString("Name7thS", nameNext.text);

                    Scores = GameObject.Find("scoreTextS6");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores5thS");
                    Names = GameObject.Find("nameTextS6");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name5thS");
                    PlayerPrefs.SetString("Scores6thS", scoreNext.text);
                    PlayerPrefs.SetString("Name6thS", nameNext.text);

                    Scores = GameObject.Find("scoreTextS5");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores4thS");
                    Names = GameObject.Find("nameTextS5");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name4thS");
                    PlayerPrefs.SetString("Scores5thS", scoreNext.text);
                    PlayerPrefs.SetString("Name5thS", nameNext.text);

                    Scores = GameObject.Find("scoreTextS4");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores3rdS");
                    Names = GameObject.Find("nameTextS4");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name3rdS");
                    PlayerPrefs.SetString("Scores4thS", scoreNext.text);
                    PlayerPrefs.SetString("Name4thS", nameNext.text);

                    Pos = GameObject.Find("posTextS3");
                    pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                    pos.fontStyle = FontStyles.Bold;
                    pos.color = new Color32(246, 255, 0, 255);
                    Scores = GameObject.Find("scoreTextS3");
                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    score.fontStyle = FontStyles.Bold;
                    score.color = new Color32(246, 255, 0, 255);
                    Names = GameObject.Find("nameTextS3");
                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    name.fontStyle = FontStyles.Bold;
                    name.color = new Color32(246, 255, 0, 255);
                    score.text = _LeaderboardMain.urScore.text;
                    name.text = nameInput.text;
                    PlayerPrefs.SetString("Scores3rdS", score.text);
                    PlayerPrefs.SetString("Name3rdS", name.text);

                    Scores = GameObject.Find("scoreTextS2");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores2ndS");
                    Names = GameObject.Find("nameTextS2");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name2ndS");
                    PlayerPrefs.SetString("Scores2ndS", scoreNext.text);
                    PlayerPrefs.SetString("Name2ndS", nameNext.text);

                    Scores = GameObject.Find("scoreTextS1");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores1stS");
                    Names = GameObject.Find("nameTextS1");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name1stS");
                    PlayerPrefs.SetString("Scores1stS", scoreNext.text);
                    PlayerPrefs.SetString("Name1stS", nameNext.text);
                }
                else if (Globals.overallScore < scoreComparison)
                {
                    Scores = GameObject.Find("scoreTextS4");
                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    score.text = PlayerPrefs.GetString("Scores4thS");
                    scoreComparison = Convert.ToInt32(score.text);
                    Names = GameObject.Find("nameTextS4");
                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    name.text = PlayerPrefs.GetString("Name4thS");

                    //checking if #4
                    if (Globals.overallScore > scoreComparison)
                    {
                        //pushing scores lower
                        Scores = GameObject.Find("scoreTextS11");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores10thS");
                        Names = GameObject.Find("nameTextS11");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name10thS");
                        PlayerPrefs.SetString("Scores11thS", scoreNext.text);
                        PlayerPrefs.SetString("Name11thS", nameNext.text);

                        Scores = GameObject.Find("scoreTextS10");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores9thS");
                        Names = GameObject.Find("nameTextS10");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name9thS");
                        PlayerPrefs.SetString("Scores10thS", scoreNext.text);
                        PlayerPrefs.SetString("Name10thS", nameNext.text);

                        Scores = GameObject.Find("scoreTextS9");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores8thS");
                        Names = GameObject.Find("nameTextS9");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name8thS");
                        PlayerPrefs.SetString("Scores9thS", scoreNext.text);
                        PlayerPrefs.SetString("Name9thS", nameNext.text);

                        Scores = GameObject.Find("scoreTextS8");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores7thS");
                        Names = GameObject.Find("nameTextS8");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name7thS");
                        PlayerPrefs.SetString("Scores8thS", scoreNext.text);
                        PlayerPrefs.SetString("Name8thS", nameNext.text);

                        Scores = GameObject.Find("scoreTextS7");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores6thS");
                        Names = GameObject.Find("nameTextS7");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name6thS");
                        PlayerPrefs.SetString("Scores7thS", scoreNext.text);
                        PlayerPrefs.SetString("Name7thS", nameNext.text);

                        Scores = GameObject.Find("scoreTextS6");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores5thS");
                        Names = GameObject.Find("nameTextS6");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name5thS");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        PlayerPrefs.SetString("Scores6thS", scoreNext.text);
                        PlayerPrefs.SetString("Name6thS", nameNext.text);

                        Scores = GameObject.Find("scoreTextS5");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores4thS");
                        Names = GameObject.Find("nameTextS5");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name4thS");
                        PlayerPrefs.SetString("Scores5thS", scoreNext.text);
                        PlayerPrefs.SetString("Name5thS", nameNext.text);

                        Pos = GameObject.Find("posTextS4");
                        pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                        pos.fontStyle = FontStyles.Bold;
                        pos.color = new Color32(246, 255, 0, 255);
                        Scores = GameObject.Find("scoreTextS4");
                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        score.fontStyle = FontStyles.Bold;
                        score.color = new Color32(246, 255, 0, 255);
                        Names = GameObject.Find("nameTextS4");
                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        name.fontStyle = FontStyles.Bold;
                        name.color = new Color32(246, 255, 0, 255);
                        score.text = _LeaderboardMain.urScore.text;
                        name.text = nameInput.text;
                        PlayerPrefs.SetString("Scores4thS", score.text);
                        PlayerPrefs.SetString("Name4thS", name.text);

                        Scores = GameObject.Find("scoreTextS3");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores3rdS");
                        Names = GameObject.Find("nameTextS3");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name3rdS");
                        PlayerPrefs.SetString("Scores3rdS", scoreNext.text);
                        PlayerPrefs.SetString("Name3rdS", nameNext.text);

                        Scores = GameObject.Find("scoreTextS2");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores2ndS");
                        Names = GameObject.Find("nameTextS2");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name2ndS");
                        PlayerPrefs.SetString("Scores2ndS", scoreNext.text);
                        PlayerPrefs.SetString("Name2ndS", nameNext.text);

                        Scores = GameObject.Find("scoreTextS1");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores1stS");
                        Names = GameObject.Find("nameTextS1");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name1stS");
                        PlayerPrefs.SetString("Scores1stS", scoreNext.text);
                        PlayerPrefs.SetString("Name1stS", nameNext.text);
                    }
                    else if (Globals.overallScore < scoreComparison)
                    {
                        Scores = GameObject.Find("scoreTextS5");
                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        score.text = PlayerPrefs.GetString("Scores5thS");
                        scoreComparison = Convert.ToInt32(score.text);
                        Names = GameObject.Find("nameTextS5");
                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        name.text = PlayerPrefs.GetString("Name4thS");

                        //checking if #5
                        if (Globals.overallScore > scoreComparison)
                        {
                            //pushing scores lower
                            Scores = GameObject.Find("scoreTextS11");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores10thS");
                            Names = GameObject.Find("nameTextS11");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name10thS");
                            PlayerPrefs.SetString("Scores11thS", scoreNext.text);
                            PlayerPrefs.SetString("Name11thS", nameNext.text);

                            Scores = GameObject.Find("scoreTextS10");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores9thS");
                            Names = GameObject.Find("nameTextS10");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name9thS");
                            PlayerPrefs.SetString("Scores10thS", scoreNext.text);
                            PlayerPrefs.SetString("Name10thS", nameNext.text);

                            Scores = GameObject.Find("scoreTextS9");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores8thS");
                            Names = GameObject.Find("nameTextS9");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name8thS");
                            PlayerPrefs.SetString("Scores9thS", scoreNext.text);
                            PlayerPrefs.SetString("Name9thS", nameNext.text);

                            Scores = GameObject.Find("scoreTextS8");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores7thS");
                            Names = GameObject.Find("nameTextS8");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name7thS");
                            PlayerPrefs.SetString("Scores8thS", scoreNext.text);
                            PlayerPrefs.SetString("Name8thS", nameNext.text);

                            Scores = GameObject.Find("scoreTextS7");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores6thS");
                            Names = GameObject.Find("nameTextS7");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name6thS");
                            PlayerPrefs.SetString("Scores7thS", scoreNext.text);
                            PlayerPrefs.SetString("Name7thS", nameNext.text);

                            Scores = GameObject.Find("scoreTextS6");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores5thS");
                            Names = GameObject.Find("nameTextS6");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name5thS");
                            PlayerPrefs.SetString("Scores6thS", scoreNext.text);
                            PlayerPrefs.SetString("Name6thS", nameNext.text);

                            Pos = GameObject.Find("posTextS5");
                            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                            pos.fontStyle = FontStyles.Bold;
                            pos.color = new Color32(246, 255, 0, 255);
                            Scores = GameObject.Find("scoreTextS5");
                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            score.fontStyle = FontStyles.Bold;
                            score.color = new Color32(246, 255, 0, 255);
                            Names = GameObject.Find("nameTextS5");
                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            name.fontStyle = FontStyles.Bold;
                            name.color = new Color32(246, 255, 0, 255);
                            score.text = _LeaderboardMain.urScore.text;
                            name.text = nameInput.text;
                            PlayerPrefs.SetString("Scores5thS", score.text);
                            PlayerPrefs.SetString("Name5thS", name.text);

                            Scores = GameObject.Find("scoreTextS4");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores4thS");
                            Names = GameObject.Find("nameTextS4");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name4thS");
                            PlayerPrefs.SetString("Scores4thS", scoreNext.text);
                            PlayerPrefs.SetString("Name4thS", nameNext.text);

                            Scores = GameObject.Find("scoreTextS3");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores3rdS");
                            Names = GameObject.Find("nameTextS3");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name3rdS");
                            PlayerPrefs.SetString("Scores3rdS", scoreNext.text);
                            PlayerPrefs.SetString("Name3rdS", nameNext.text);

                            Scores = GameObject.Find("scoreTextS2");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores2ndS");
                            Names = GameObject.Find("nameTextS2");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name2ndS");
                            PlayerPrefs.SetString("Scores2ndS", scoreNext.text);
                            PlayerPrefs.SetString("Name2ndS", nameNext.text);

                            Scores = GameObject.Find("scoreTextS1");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores1stS");
                            Names = GameObject.Find("nameTextS1");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name1stS");
                            PlayerPrefs.SetString("Scores1stS", scoreNext.text);
                            PlayerPrefs.SetString("Name1stS", nameNext.text);
                        }
                        else if (Globals.overallScore < scoreComparison)
                        {
                            Scores = GameObject.Find("scoreTextS6");
                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            score.text = PlayerPrefs.GetString("Scores6thS");
                            scoreComparison = Convert.ToInt32(score.text);
                            Names = GameObject.Find("nameTextS6");
                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            name.text = PlayerPrefs.GetString("Name6thS");

                            //checking if #6
                            if (Globals.overallScore > scoreComparison)
                            {
                                //pushing scores lower
                                Scores = GameObject.Find("scoreTextS11");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores10thS");
                                Names = GameObject.Find("nameTextS11");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name10thS");
                                PlayerPrefs.SetString("Scores11thS", scoreNext.text);
                                PlayerPrefs.SetString("Name11thS", nameNext.text);

                                Scores = GameObject.Find("scoreTextS10");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores9thS");
                                Names = GameObject.Find("nameTextS10");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name9thS");
                                PlayerPrefs.SetString("Scores10thS", scoreNext.text);
                                PlayerPrefs.SetString("Name10thS", nameNext.text);

                                Scores = GameObject.Find("scoreTextS9");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores8thS");
                                Names = GameObject.Find("nameTextS9");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name8thS");
                                PlayerPrefs.SetString("Scores9thS", scoreNext.text);
                                PlayerPrefs.SetString("Name9thS", nameNext.text);

                                Scores = GameObject.Find("scoreTextS8");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores7thS");
                                Names = GameObject.Find("nameTextS8");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name7thS");
                                PlayerPrefs.SetString("Scores8thS", scoreNext.text);
                                PlayerPrefs.SetString("Name8thS", nameNext.text);

                                Scores = GameObject.Find("scoreTextS7");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores6thS");
                                Names = GameObject.Find("nameTextS7");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name6thS");
                                PlayerPrefs.SetString("Scores7thS", scoreNext.text);
                                PlayerPrefs.SetString("Name7thS", nameNext.text);

                                Pos = GameObject.Find("posTextS6");
                                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                pos.fontStyle = FontStyles.Bold;
                                pos.color = new Color32(246, 255, 0, 255);
                                Scores = GameObject.Find("scoreTextS6");
                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                score.fontStyle = FontStyles.Bold;
                                score.color = new Color32(246, 255, 0, 255);
                                Names = GameObject.Find("nameTextS6");
                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                name.fontStyle = FontStyles.Bold;
                                name.color = new Color32(246, 255, 0, 255);
                                score.text = _LeaderboardMain.urScore.text;
                                name.text = nameInput.text;
                                PlayerPrefs.SetString("Scores6thS", score.text);
                                PlayerPrefs.SetString("Name6thS", name.text);

                                Scores = GameObject.Find("scoreTextS5");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores5thS");
                                Names = GameObject.Find("nameTextS5");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name5thS");
                                PlayerPrefs.SetString("Scores5thS", scoreNext.text);
                                PlayerPrefs.SetString("Name5thS", nameNext.text);

                                Scores = GameObject.Find("scoreTextS4");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores4thS");
                                Names = GameObject.Find("nameTextS4");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name4thS");
                                PlayerPrefs.SetString("Scores4thS", scoreNext.text);
                                PlayerPrefs.SetString("Name4thS", nameNext.text);

                                Scores = GameObject.Find("scoreTextS3");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores3rdS");
                                Names = GameObject.Find("nameTextS3");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name3rdS");
                                PlayerPrefs.SetString("Scores3rdS", scoreNext.text);
                                PlayerPrefs.SetString("Name3rdS", nameNext.text);

                                Scores = GameObject.Find("scoreTextS2");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores2ndS");
                                Names = GameObject.Find("nameTextS2");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name2ndS");
                                PlayerPrefs.SetString("Scores2ndS", scoreNext.text);
                                PlayerPrefs.SetString("Name2ndS", nameNext.text);

                                Scores = GameObject.Find("scoreTextS1");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores1stS");
                                Names = GameObject.Find("nameTextS1");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name1stS");
                                PlayerPrefs.SetString("Scores1stS", scoreNext.text);
                                PlayerPrefs.SetString("Name1stS", nameNext.text);
                            }
                            else if (Globals.overallScore < scoreComparison)
                            {
                                Scores = GameObject.Find("scoreTextS7");
                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                score.text = PlayerPrefs.GetString("Scores7thS");
                                scoreComparison = Convert.ToInt32(score.text);
                                Names = GameObject.Find("nameTextS7");
                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                name.text = PlayerPrefs.GetString("Name7thS");

                                //checking if #7
                                if (Globals.overallScore > scoreComparison)
                                {
                                    //pushing scores lower
                                    Scores = GameObject.Find("scoreTextS11");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores10thS");
                                    Names = GameObject.Find("nameTextS11");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name10thS");
                                    PlayerPrefs.SetString("Scores11thS", scoreNext.text);
                                    PlayerPrefs.SetString("Name11thS", nameNext.text);

                                    Scores = GameObject.Find("scoreTextS10");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores9thS");
                                    Names = GameObject.Find("nameTextS10");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name9thS");
                                    PlayerPrefs.SetString("Scores10thS", scoreNext.text);
                                    PlayerPrefs.SetString("Name10thS", nameNext.text);

                                    Scores = GameObject.Find("scoreTextS9");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores8thS");
                                    Names = GameObject.Find("nameTextS9");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name8thS");
                                    PlayerPrefs.SetString("Scores9thS", scoreNext.text);
                                    PlayerPrefs.SetString("Name9thS", nameNext.text);

                                    Scores = GameObject.Find("scoreTextS8");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores7thS");
                                    Names = GameObject.Find("nameTextS8");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name7thS");
                                    PlayerPrefs.SetString("Scores8thS", scoreNext.text);
                                    PlayerPrefs.SetString("Name8thS", nameNext.text);

                                    Pos = GameObject.Find("posTextS7");
                                    pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                    pos.fontStyle = FontStyles.Bold;
                                    pos.color = new Color32(246, 255, 0, 255);
                                    Scores = GameObject.Find("scoreTextS7");
                                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    score.fontStyle = FontStyles.Bold;
                                    score.color = new Color32(246, 255, 0, 255);
                                    Names = GameObject.Find("nameTextS7");
                                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    name.fontStyle = FontStyles.Bold;
                                    name.color = new Color32(246, 255, 0, 255);
                                    score.text = _LeaderboardMain.urScore.text;
                                    name.text = nameInput.text;
                                    PlayerPrefs.SetString("Scores7thS", score.text);
                                    PlayerPrefs.SetString("Name7thS", name.text);

                                    Scores = GameObject.Find("scoreTextS6");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores6thS");
                                    Names = GameObject.Find("nameTextS6");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name6thS");
                                    PlayerPrefs.SetString("Scores6thS", scoreNext.text);
                                    PlayerPrefs.SetString("Name6thS", nameNext.text);

                                    Scores = GameObject.Find("scoreTextS5");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores5thS");
                                    Names = GameObject.Find("nameTextS5");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name5thS");
                                    PlayerPrefs.SetString("Scores5thS", scoreNext.text);
                                    PlayerPrefs.SetString("Name5thS", nameNext.text);

                                    Scores = GameObject.Find("scoreTextS4");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores4thS");
                                    Names = GameObject.Find("nameTextS4");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name4thS");
                                    PlayerPrefs.SetString("Scores4thS", scoreNext.text);
                                    PlayerPrefs.SetString("Name4thS", nameNext.text);

                                    Scores = GameObject.Find("scoreTextS3");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores3rdS");
                                    Names = GameObject.Find("nameTextS3");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name3rdS");
                                    PlayerPrefs.SetString("Scores3rdS", scoreNext.text);
                                    PlayerPrefs.SetString("Name3rdS", nameNext.text);

                                    Scores = GameObject.Find("scoreTextS2");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores2ndS");
                                    Names = GameObject.Find("nameTextS2");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name2ndS");
                                    PlayerPrefs.SetString("Scores2ndS", scoreNext.text);
                                    PlayerPrefs.SetString("Name2ndS", nameNext.text);

                                    Scores = GameObject.Find("scoreTextS1");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores1stS");
                                    Names = GameObject.Find("nameTextS1");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name1stS");
                                    PlayerPrefs.SetString("Scores1stS", scoreNext.text);
                                    PlayerPrefs.SetString("Name1stS", nameNext.text);
                                }
                                else if (Globals.overallScore < scoreComparison)
                                {
                                    Scores = GameObject.Find("scoreTextS8");
                                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    score.text = PlayerPrefs.GetString("Scores8thS");
                                    scoreComparison = Convert.ToInt32(score.text);
                                    Names = GameObject.Find("nameTextS8");
                                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    name.text = PlayerPrefs.GetString("Name8thS");

                                    //checking if #8
                                    if (Globals.overallScore > scoreComparison)
                                    {
                                        //pushing scores lower
                                        Scores = GameObject.Find("scoreTextS11");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores10thS");
                                        Names = GameObject.Find("nameTextS11");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name10thS");
                                        PlayerPrefs.SetString("Scores11thS", scoreNext.text);
                                        PlayerPrefs.SetString("Name11thS", nameNext.text);

                                        Scores = GameObject.Find("scoreTextS10");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores9thS");
                                        Names = GameObject.Find("nameTextS10");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name9thS");
                                        PlayerPrefs.SetString("Scores10thS", scoreNext.text);
                                        PlayerPrefs.SetString("Name10thS", nameNext.text);

                                        Scores = GameObject.Find("scoreTextS9");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores8thS");
                                        Names = GameObject.Find("nameTextS9");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name8thS");
                                        PlayerPrefs.SetString("Scores9thS", scoreNext.text);
                                        PlayerPrefs.SetString("Name9thS", nameNext.text);

                                        Pos = GameObject.Find("posTextS8");
                                        pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                        pos.fontStyle = FontStyles.Bold;
                                        pos.color = new Color32(246, 255, 0, 255);
                                        Scores = GameObject.Find("scoreTextS8");
                                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        score.fontStyle = FontStyles.Bold;
                                        score.color = new Color32(246, 255, 0, 255);
                                        Names = GameObject.Find("nameTextS8");
                                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        name.fontStyle = FontStyles.Bold;
                                        name.color = new Color32(246, 255, 0, 255);
                                        score.text = _LeaderboardMain.urScore.text;
                                        name.text = nameInput.text;
                                        PlayerPrefs.SetString("Scores8thS", score.text);
                                        PlayerPrefs.SetString("Name8thS", name.text);

                                        Scores = GameObject.Find("scoreTextS7");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores7thS");
                                        Names = GameObject.Find("nameTextS7");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name7thS");
                                        PlayerPrefs.SetString("Scores7thS", scoreNext.text);
                                        PlayerPrefs.SetString("Name7thS", nameNext.text);

                                        Scores = GameObject.Find("scoreTextS6");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores6thS");
                                        Names = GameObject.Find("nameTextS6");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name6thS");
                                        PlayerPrefs.SetString("Scores6thS", scoreNext.text);
                                        PlayerPrefs.SetString("Name6thS", nameNext.text);

                                        Scores = GameObject.Find("scoreTextS5");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores5thS");
                                        Names = GameObject.Find("nameTextS5");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name5thS");
                                        PlayerPrefs.SetString("Scores5thS", scoreNext.text);
                                        PlayerPrefs.SetString("Name5thS", nameNext.text);

                                        Scores = GameObject.Find("scoreTextS4");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores4thS");
                                        Names = GameObject.Find("nameTextS4");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name4thS");
                                        PlayerPrefs.SetString("Scores4thS", scoreNext.text);
                                        PlayerPrefs.SetString("Name4thS", nameNext.text);

                                        Scores = GameObject.Find("scoreTextS3");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores3rdS");
                                        Names = GameObject.Find("nameTextS3");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name3rdS");
                                        PlayerPrefs.SetString("Scores3rdS", scoreNext.text);
                                        PlayerPrefs.SetString("Name3rdS", nameNext.text);

                                        Scores = GameObject.Find("scoreTextS2");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores2ndS");
                                        Names = GameObject.Find("nameTextS2");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name2ndS");
                                        PlayerPrefs.SetString("Scores2ndS", scoreNext.text);
                                        PlayerPrefs.SetString("Name2ndS", nameNext.text);

                                        Scores = GameObject.Find("scoreTextS1");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores1stS");
                                        Names = GameObject.Find("nameTextS1");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name1stS");
                                        PlayerPrefs.SetString("Scores1stS", scoreNext.text);
                                        PlayerPrefs.SetString("Name1stS", nameNext.text);
                                    }
                                    else if (Globals.overallScore < scoreComparison)
                                    {
                                        Scores = GameObject.Find("scoreTextS9");
                                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        score.text = PlayerPrefs.GetString("Scores9thS");
                                        scoreComparison = Convert.ToInt32(score.text);
                                        Names = GameObject.Find("nameTextS9");
                                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        name.text = PlayerPrefs.GetString("Name9thS");

                                        //checking if #9
                                        if (Globals.overallScore > scoreComparison)
                                        {
                                            //pushing scores lower
                                            Scores = GameObject.Find("scoreTextS11");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores10thS");
                                            Names = GameObject.Find("nameTextS11");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name10thS");
                                            PlayerPrefs.SetString("Scores11thS", scoreNext.text);
                                            PlayerPrefs.SetString("Name11thS", nameNext.text);

                                            Scores = GameObject.Find("scoreTextS10");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores9thS");
                                            Names = GameObject.Find("nameTextS10");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name9thS");
                                            PlayerPrefs.SetString("Scores10thS", scoreNext.text);
                                            PlayerPrefs.SetString("Name10thS", nameNext.text);

                                            Pos = GameObject.Find("posTextS9");
                                            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                            pos.fontStyle = FontStyles.Bold;
                                            pos.color = new Color32(246, 255, 0, 255);
                                            Scores = GameObject.Find("scoreTextS9");
                                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            score.fontStyle = FontStyles.Bold;
                                            score.color = new Color32(246, 255, 0, 255);
                                            Names = GameObject.Find("nameTextS9");
                                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            name.fontStyle = FontStyles.Bold;
                                            name.color = new Color32(246, 255, 0, 255);
                                            score.text = _LeaderboardMain.urScore.text;
                                            name.text = nameInput.text;
                                            PlayerPrefs.SetString("Scores9thS", score.text);
                                            PlayerPrefs.SetString("Name9thS", name.text);

                                            Scores = GameObject.Find("scoreTextS8");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores8thS");
                                            Names = GameObject.Find("nameTextS8");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name8thS");
                                            PlayerPrefs.SetString("Scores8thS", scoreNext.text);
                                            PlayerPrefs.SetString("Name8thS", nameNext.text);

                                            Scores = GameObject.Find("scoreTextS7");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores7thS");
                                            Names = GameObject.Find("nameTextS7");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name7thS");
                                            PlayerPrefs.SetString("Scores7thS", scoreNext.text);
                                            PlayerPrefs.SetString("Name7thS", nameNext.text);

                                            Scores = GameObject.Find("scoreTextS6");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores6thS");
                                            Names = GameObject.Find("nameTextS6");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name6thS");
                                            PlayerPrefs.SetString("Scores6thS", scoreNext.text);
                                            PlayerPrefs.SetString("Name6thS", nameNext.text);

                                            Scores = GameObject.Find("scoreTextS5");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores5thS");
                                            Names = GameObject.Find("nameTextS5");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name5thS");
                                            PlayerPrefs.SetString("Scores5thS", scoreNext.text);
                                            PlayerPrefs.SetString("Name5thS", nameNext.text);

                                            Scores = GameObject.Find("scoreTextS4");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores4thS");
                                            Names = GameObject.Find("nameTextS4");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name4thS");
                                            PlayerPrefs.SetString("Scores4thS", scoreNext.text);
                                            PlayerPrefs.SetString("Name4th", nameNext.text);

                                            Scores = GameObject.Find("scoreTextS3");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores3rdS");
                                            Names = GameObject.Find("nameTextS3");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name3rdS");
                                            PlayerPrefs.SetString("Scores3rdS", scoreNext.text);
                                            PlayerPrefs.SetString("Name3rdS", nameNext.text);

                                            Scores = GameObject.Find("scoreTextS2");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores2ndS");
                                            Names = GameObject.Find("nameTextS2");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name2ndS");
                                            PlayerPrefs.SetString("Scores2ndS", scoreNext.text);
                                            PlayerPrefs.SetString("Name2ndS", nameNext.text);

                                            Scores = GameObject.Find("scoreTextS1");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores1stS");
                                            Names = GameObject.Find("nameTextS1");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name1stS");
                                            PlayerPrefs.SetString("Scores1stS", scoreNext.text);
                                            PlayerPrefs.SetString("Name1stS", nameNext.text);
                                        }
                                        else if (Globals.overallScore < scoreComparison)
                                        {
                                            Scores = GameObject.Find("scoreTextS10");
                                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            score.text = PlayerPrefs.GetString("Scores10thS");
                                            scoreComparison = Convert.ToInt32(score.text);
                                            Names = GameObject.Find("nameTextS10");
                                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            name.text = PlayerPrefs.GetString("Name10thS");

                                            //checking if #10
                                            if (Globals.overallScore > scoreComparison)
                                            {
                                                //pushing scores lower
                                                Scores = GameObject.Find("scoreTextS11");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores10thS");
                                                Names = GameObject.Find("nameTextS11");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name10thS");
                                                PlayerPrefs.SetString("Scores11thS", scoreNext.text);
                                                PlayerPrefs.SetString("Name11thS", nameNext.text);

                                                Pos = GameObject.Find("posTextS10");
                                                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                                pos.fontStyle = FontStyles.Bold;
                                                pos.color = new Color32(246, 255, 0, 255);
                                                Scores = GameObject.Find("scoreTextS10");
                                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                score.fontStyle = FontStyles.Bold;
                                                score.color = new Color32(246, 255, 0, 255);
                                                Names = GameObject.Find("nameTextS10");
                                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                name.fontStyle = FontStyles.Bold;
                                                name.color = new Color32(246, 255, 0, 255);
                                                score.text = _LeaderboardMain.urScore.text;
                                                name.text = nameInput.text;
                                                PlayerPrefs.SetString("Scores10thS", score.text);
                                                PlayerPrefs.SetString("Name10thS", name.text);

                                                Scores = GameObject.Find("scoreTextS9");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores9thS");
                                                Names = GameObject.Find("nameTextS9");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name9thS");
                                                PlayerPrefs.SetString("Scores9thS", scoreNext.text);
                                                PlayerPrefs.SetString("Name9thS", nameNext.text);

                                                Scores = GameObject.Find("scoreTextS8");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores8thS");
                                                Names = GameObject.Find("nameTextS8");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name8thS");
                                                PlayerPrefs.SetString("Scores8thS", scoreNext.text);
                                                PlayerPrefs.SetString("Name8thS", nameNext.text);

                                                Scores = GameObject.Find("scoreTextS7");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores7thS");
                                                Names = GameObject.Find("nameTextS7");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name7thS");
                                                PlayerPrefs.SetString("Scores7thS", scoreNext.text);
                                                PlayerPrefs.SetString("Name7thS", nameNext.text);

                                                Scores = GameObject.Find("scoreTextS6");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores6thS");
                                                Names = GameObject.Find("nameTextS6");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name6thS");
                                                PlayerPrefs.SetString("Scores6thS", scoreNext.text);
                                                PlayerPrefs.SetString("Name6thS", nameNext.text);

                                                Scores = GameObject.Find("scoreTextS5");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores5thS");
                                                Names = GameObject.Find("nameTextS5");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name5thS");
                                                PlayerPrefs.SetString("Scores5thS", scoreNext.text);
                                                PlayerPrefs.SetString("Name5thS", nameNext.text);

                                                Scores = GameObject.Find("scoreTextS4");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores4thS");
                                                Names = GameObject.Find("nameTextS4");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name4thS");
                                                PlayerPrefs.SetString("Scores4thS", scoreNext.text);
                                                PlayerPrefs.SetString("Name4thS", nameNext.text);

                                                Scores = GameObject.Find("scoreTextS3");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores3rdS");
                                                Names = GameObject.Find("nameTextS3");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name3rdS");
                                                PlayerPrefs.SetString("Scores3rdS", scoreNext.text);
                                                PlayerPrefs.SetString("Name3rdS", nameNext.text);

                                                Scores = GameObject.Find("scoreTextS2");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores2ndS");
                                                Names = GameObject.Find("nameTextS2");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name2ndS");
                                                PlayerPrefs.SetString("Scores2ndS", scoreNext.text);
                                                PlayerPrefs.SetString("Name2ndS", nameNext.text);

                                                Scores = GameObject.Find("scoreTextS1");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores1stS");
                                                Names = GameObject.Find("nameTextS1");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name1stS");
                                                PlayerPrefs.SetString("Scores1stS", scoreNext.text);
                                                PlayerPrefs.SetString("Name1stS", nameNext.text);
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
    }

    public void SummerViewing()
    {
        Scores = GameObject.Find("scoreTextS1");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores1stS");
        Names = GameObject.Find("nameTextS1");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name1stS");

        Scores = GameObject.Find("scoreTextS2");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores2ndS");
        Names = GameObject.Find("nameTextS2");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name2ndS");

        Scores = GameObject.Find("scoreTextS3");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores3rdS");
        Names = GameObject.Find("nameTextS3");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name3rdS");

        Scores = GameObject.Find("scoreTextS4");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores4thS");
        Names = GameObject.Find("nameTextS4");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name4thS");

        Scores = GameObject.Find("scoreTextS5");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores5thS");
        Names = GameObject.Find("nameTextS5");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name5thS");

        Scores = GameObject.Find("scoreTextS6");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores6thS");
        Names = GameObject.Find("nameTextS6");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name6thS");

        Scores = GameObject.Find("scoreTextS7");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores7thS");
        Names = GameObject.Find("nameTextS7");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name7thS");

        Scores = GameObject.Find("scoreTextS8");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores8thS");
        Names = GameObject.Find("nameTextS8");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name8thS");

        Scores = GameObject.Find("scoreTextS9");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores9thS");
        Names = GameObject.Find("nameTextS9");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name9thS");

        Scores = GameObject.Find("scoreTextS10");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores10thS");
        Names = GameObject.Find("nameTextS10");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name10thS");
    }
}
