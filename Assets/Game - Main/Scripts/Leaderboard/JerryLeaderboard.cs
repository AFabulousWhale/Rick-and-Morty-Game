using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using TMPro;

public class JerryLeaderboard : MonoBehaviour
{
    public int RandomI;
    public TMPro.TextMeshProUGUI scoreNext, nameNext, score, name, pos;
    public TMPro.TMP_InputField nameInput;

    public GameObject Scores, Names, Pos;

    public int scoreComparison;

    public AudioSource buttonS;

    public LeaderboardMain _LeaderboardMain;
    // Start is called before the first frame update
    void Start()
    {
        RandomI = UnityEngine.Random.Range(0, 5);
    }

    public void JerryPlacement()
    {

        Scores = GameObject.Find("scoreTextJ1");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores1stJ");
        scoreComparison = Convert.ToInt32(score.text);
        Names = GameObject.Find("nameTextJ1");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name1stJ");

        //checking if #1
        if (Globals.overallScore > scoreComparison)
        {
            //pushing scores lower
            Scores = GameObject.Find("scoreTextJ11");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores10thJ");
            Names = GameObject.Find("nameTextJ11");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name10thJ");
            PlayerPrefs.SetString("Scores11thJ", scoreNext.text);
            PlayerPrefs.SetString("Name11thJ", nameNext.text);

            Scores = GameObject.Find("scoreTextJ10");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores9thJ");
            Names = GameObject.Find("nameTextJ10");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name9thJ");
            PlayerPrefs.SetString("Scores10thJ", scoreNext.text);
            PlayerPrefs.SetString("Name10thJ", nameNext.text);

            Scores = GameObject.Find("scoreTextJ9");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores8thJ");
            Names = GameObject.Find("nameTextJ9");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name8thJ");
            PlayerPrefs.SetString("Scores9thJ", scoreNext.text);
            PlayerPrefs.SetString("Name9thJ", nameNext.text);

            Scores = GameObject.Find("scoreTextJ8");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores7thJ");
            Names = GameObject.Find("nameTextJ8");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name7thJ");
            PlayerPrefs.SetString("Scores8thJ", scoreNext.text);
            PlayerPrefs.SetString("Name8thJ", nameNext.text);

            Scores = GameObject.Find("scoreTextJ7");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores6thJ");
            Names = GameObject.Find("nameTextJ7");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name6thJ");
            PlayerPrefs.SetString("Scores7thJ", scoreNext.text);
            PlayerPrefs.SetString("Name7thJ", nameNext.text);

            Scores = GameObject.Find("scoreTextJ6");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores5thJ");
            Names = GameObject.Find("nameTextJ6");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name5thJ");
            PlayerPrefs.SetString("Scores6thJ", scoreNext.text);
            PlayerPrefs.SetString("Name6thJ", nameNext.text);

            Scores = GameObject.Find("scoreTextJ5");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores4thJ");
            Names = GameObject.Find("nameTextJ5");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name4thJ");
            PlayerPrefs.SetString("Scores5thJ", scoreNext.text);
            PlayerPrefs.SetString("Name5thJ", nameNext.text);

            Scores = GameObject.Find("scoreTextJ4");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores3rdJ");
            Names = GameObject.Find("nameTextJ4");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name3rdJ");
            PlayerPrefs.SetString("Scores4thJ", scoreNext.text);
            PlayerPrefs.SetString("Name4thJ", nameNext.text);

            Scores = GameObject.Find("scoreTextJ3");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores2ndJ");
            Names = GameObject.Find("nameTextJ3");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name2ndJ");
            PlayerPrefs.SetString("Scores3rdJ", scoreNext.text);
            PlayerPrefs.SetString("Name3rdJ", nameNext.text);

            Scores = GameObject.Find("scoreTextJ2");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores1stJ");
            Names = GameObject.Find("nameTextJ2");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name1stJ");
            PlayerPrefs.SetString("Scores2ndJ", scoreNext.text);
            PlayerPrefs.SetString("Name2ndJ", nameNext.text);

            Pos = GameObject.Find("posTextJ1");
            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
            pos.fontStyle = FontStyles.Bold;
            pos.color = new Color32(246, 255, 0, 255);
            Scores = GameObject.Find("scoreTextJ1");
            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            score.fontStyle = FontStyles.Bold;
            score.color = new Color32(246, 255, 0, 255);
            Names = GameObject.Find("nameTextJ1");
            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
            name.fontStyle = FontStyles.Bold;
            name.color = new Color32(246, 255, 0, 255);
            score.text = _LeaderboardMain.urScore.text;
            name.text = nameInput.text;
            PlayerPrefs.SetString("Scores1stJ", score.text);
            PlayerPrefs.SetString("Name1stJ", name.text);
        }
        else if (Globals.overallScore < scoreComparison)
        {
            Scores = GameObject.Find("scoreTextJ2");
            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            score.text = PlayerPrefs.GetString("Scores2ndJ");
            scoreComparison = Convert.ToInt32(score.text);
            Names = GameObject.Find("nameTextJ2");
            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
            name.text = PlayerPrefs.GetString("Name2ndJ");

            //checking if #2
            if (Globals.overallScore > scoreComparison)
            {
                //pushing scores lower
                Scores = GameObject.Find("scoreTextJ11");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores10thJ");
                Names = GameObject.Find("nameTextJ11");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name10thJ");
                PlayerPrefs.SetString("Scores11thJ", scoreNext.text);
                PlayerPrefs.SetString("Name11thJ", nameNext.text);

                Scores = GameObject.Find("scoreTextJ10");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores9thJ");
                Names = GameObject.Find("nameTextJ10");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name9thJ");
                PlayerPrefs.SetString("Scores10thJ", scoreNext.text);
                PlayerPrefs.SetString("Name10thJ", nameNext.text);

                Scores = GameObject.Find("scoreTextJ9");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores8thJ");
                Names = GameObject.Find("nameTextJ9");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name8thJ");
                PlayerPrefs.SetString("Scores9thJ", scoreNext.text);
                PlayerPrefs.SetString("Name9thJ", nameNext.text);

                Scores = GameObject.Find("scoreTextJ8");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores7thJ");
                Names = GameObject.Find("nameTextJ8");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name7thJ");
                PlayerPrefs.SetString("Scores8thJ", scoreNext.text);
                PlayerPrefs.SetString("Name8thJ", nameNext.text);

                Scores = GameObject.Find("scoreTextJ7");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores6thJ");
                Names = GameObject.Find("nameTextJ7");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name6thJ");
                PlayerPrefs.SetString("Scores7thJ", scoreNext.text);
                PlayerPrefs.SetString("Name7thJ", nameNext.text);

                Scores = GameObject.Find("scoreTextJ6");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores5thJ");
                Names = GameObject.Find("nameTextJ6");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name5thJ");
                PlayerPrefs.SetString("Scores6thJ", scoreNext.text);
                PlayerPrefs.SetString("Name6thJ", nameNext.text);

                Scores = GameObject.Find("scoreTextJ5");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores4thJ");
                Names = GameObject.Find("nameTextJ5");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name4thJ");
                PlayerPrefs.SetString("Scores5thJ", scoreNext.text);
                PlayerPrefs.SetString("Name5thJ", nameNext.text);

                Scores = GameObject.Find("scoreTextJ4");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores3rdJ");
                Names = GameObject.Find("nameTextJ4");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name3rdJ");
                PlayerPrefs.SetString("Scores4thJ", scoreNext.text);
                PlayerPrefs.SetString("Name4thJ", nameNext.text);

                Scores = GameObject.Find("scoreTextJ3");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores2ndJ");
                Names = GameObject.Find("nameTextJ3");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name2ndJ");
                PlayerPrefs.SetString("Scores3rdJ", scoreNext.text);
                PlayerPrefs.SetString("Name3rdJ", nameNext.text);

                Pos = GameObject.Find("posTextJ2");
                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                pos.fontStyle = FontStyles.Bold;
                pos.color = new Color32(246, 255, 0, 255);
                Scores = GameObject.Find("scoreTextJ2");
                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                score.fontStyle = FontStyles.Bold;
                score.color = new Color32(246, 255, 0, 255);
                Names = GameObject.Find("nameTextJ2");
                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                name.fontStyle = FontStyles.Bold;
                name.color = new Color32(246, 255, 0, 255);
                score.text = _LeaderboardMain.urScore.text;
                name.text = nameInput.text;
                PlayerPrefs.SetString("Scores2ndJ", score.text);
                PlayerPrefs.SetString("Name2ndJ", name.text);

                Scores = GameObject.Find("scoreTextJ1");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores1stJ");
                Names = GameObject.Find("nameTextJ1");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name1stJ");
                PlayerPrefs.SetString("Scores1stJ", scoreNext.text);
                PlayerPrefs.SetString("Name1stJ", nameNext.text);
            }
            else if (Globals.overallScore < scoreComparison)
            {
                Scores = GameObject.Find("scoreTextJ3");
                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                score.text = PlayerPrefs.GetString("Scores3rdJ");
                scoreComparison = Convert.ToInt32(score.text);
                Names = GameObject.Find("nameTextJ3");
                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                name.text = PlayerPrefs.GetString("Name3rdJ");

                //checking if #3
                if (Globals.overallScore > scoreComparison)
                {
                    //pushing scores lower
                    Scores = GameObject.Find("scoreTextJ11");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores10thJ");
                    Names = GameObject.Find("nameTextJ11");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name10thJ");
                    PlayerPrefs.SetString("Scores11thJ", scoreNext.text);
                    PlayerPrefs.SetString("Name11thJ", nameNext.text);

                    Scores = GameObject.Find("scoreTextJ10");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores9thJ");
                    Names = GameObject.Find("nameTextJ10");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name9thJ");
                    PlayerPrefs.SetString("Scores10thJ", scoreNext.text);
                    PlayerPrefs.SetString("Name10thJ", nameNext.text);

                    Scores = GameObject.Find("scoreTextJ9");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores8thJ");
                    Names = GameObject.Find("nameTextJ8");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name8thJ");
                    PlayerPrefs.SetString("Scores9thJ", scoreNext.text);
                    PlayerPrefs.SetString("Name9thJ", nameNext.text);

                    Scores = GameObject.Find("scoreTextJ8");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores7thJ");
                    Names = GameObject.Find("nameTextJ8");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name7thJ");
                    PlayerPrefs.SetString("Scores8thJ", scoreNext.text);
                    PlayerPrefs.SetString("Name8thJ", nameNext.text);

                    Scores = GameObject.Find("scoreTextJ7");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores6thJ");
                    Names = GameObject.Find("nameTextJ7");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name6thJ");
                    PlayerPrefs.SetString("Scores7thJ", scoreNext.text);
                    PlayerPrefs.SetString("Name7thJ", nameNext.text);

                    Scores = GameObject.Find("scoreTextJ6");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores5thJ");
                    Names = GameObject.Find("nameTextJ6");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name5thJ");
                    PlayerPrefs.SetString("Scores6thJ", scoreNext.text);
                    PlayerPrefs.SetString("Name6thJ", nameNext.text);

                    Scores = GameObject.Find("scoreTextJ5");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores4thJ");
                    Names = GameObject.Find("nameTextJ5");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name4thJ");
                    PlayerPrefs.SetString("Scores5thJ", scoreNext.text);
                    PlayerPrefs.SetString("Name5thJ", nameNext.text);

                    Scores = GameObject.Find("scoreTextJ4");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores3rdJ");
                    Names = GameObject.Find("nameTextJ4");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name3rdJ");
                    PlayerPrefs.SetString("Scores4thJ", scoreNext.text);
                    PlayerPrefs.SetString("Name4thJ", nameNext.text);

                    Pos = GameObject.Find("posTextJ3");
                    pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                    pos.fontStyle = FontStyles.Bold;
                    pos.color = new Color32(246, 255, 0, 255);
                    Scores = GameObject.Find("scoreTextJ3");
                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    score.fontStyle = FontStyles.Bold;
                    score.color = new Color32(246, 255, 0, 255);
                    Names = GameObject.Find("nameTextJ3");
                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    name.fontStyle = FontStyles.Bold;
                    name.color = new Color32(246, 255, 0, 255);
                    score.text = _LeaderboardMain.urScore.text;
                    name.text = nameInput.text;
                    PlayerPrefs.SetString("Scores3rdJ", score.text);
                    PlayerPrefs.SetString("Name3rdJ", name.text);

                    Scores = GameObject.Find("scoreTextJ2");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores2ndJ");
                    Names = GameObject.Find("nameTextJ2");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name2ndJ");
                    PlayerPrefs.SetString("Scores2ndJ", scoreNext.text);
                    PlayerPrefs.SetString("Name2ndJ", nameNext.text);

                    Scores = GameObject.Find("scoreTextJ1");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores1stJ");
                    Names = GameObject.Find("nameTextJ1");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name1stJ");
                    PlayerPrefs.SetString("Scores1stJ", scoreNext.text);
                    PlayerPrefs.SetString("Name1stJ", nameNext.text);
                }
                else if (Globals.overallScore < scoreComparison)
                {
                    Scores = GameObject.Find("scoreTextJ4");
                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    score.text = PlayerPrefs.GetString("Scores4thJ");
                    scoreComparison = Convert.ToInt32(score.text);
                    Names = GameObject.Find("nameTextJ4");
                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    name.text = PlayerPrefs.GetString("Name4thJ");

                    //checking if #4
                    if (Globals.overallScore > scoreComparison)
                    {
                        //pushing scores lower
                        Scores = GameObject.Find("scoreTextJ11");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores10thJ");
                        Names = GameObject.Find("nameTextJ11");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name10thJ");
                        PlayerPrefs.SetString("Scores11thJ", scoreNext.text);
                        PlayerPrefs.SetString("Name11thJ", nameNext.text);

                        Scores = GameObject.Find("scoreTextJ10");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores9thJ");
                        Names = GameObject.Find("nameTextJ10");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name9thJ");
                        PlayerPrefs.SetString("Scores10thJ", scoreNext.text);
                        PlayerPrefs.SetString("Name10thJ", nameNext.text);

                        Scores = GameObject.Find("scoreTextJ9");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores8thJ");
                        Names = GameObject.Find("nameTextJ9");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name8thJ");
                        PlayerPrefs.SetString("Scores9thJ", scoreNext.text);
                        PlayerPrefs.SetString("Name9thJ", nameNext.text);

                        Scores = GameObject.Find("scoreTextJ8");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores7thJ");
                        Names = GameObject.Find("nameTextJ8");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name7thJ");
                        PlayerPrefs.SetString("Scores8thJ", scoreNext.text);
                        PlayerPrefs.SetString("Name8thJ", nameNext.text);

                        Scores = GameObject.Find("scoreTextJ7");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores6thJ");
                        Names = GameObject.Find("nameTextJ7");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name6thJ");
                        PlayerPrefs.SetString("Scores7thJ", scoreNext.text);
                        PlayerPrefs.SetString("Name7thJ", nameNext.text);

                        Scores = GameObject.Find("scoreTextJ6");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores5thJ");
                        Names = GameObject.Find("nameTextJ6");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name5thJ");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        PlayerPrefs.SetString("Scores6thJ", scoreNext.text);
                        PlayerPrefs.SetString("Name6thJ", nameNext.text);

                        Scores = GameObject.Find("scoreTextJ5");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores4thJ");
                        Names = GameObject.Find("nameTextJ5");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name4thJ");
                        PlayerPrefs.SetString("Scores5thJ", scoreNext.text);
                        PlayerPrefs.SetString("Name5thJ", nameNext.text);

                        Pos = GameObject.Find("posTextJ4");
                        pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                        pos.fontStyle = FontStyles.Bold;
                        pos.color = new Color32(246, 255, 0, 255);
                        Scores = GameObject.Find("scoreTextJ4");
                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        score.fontStyle = FontStyles.Bold;
                        score.color = new Color32(246, 255, 0, 255);
                        Names = GameObject.Find("nameTextJ4");
                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        name.fontStyle = FontStyles.Bold;
                        name.color = new Color32(246, 255, 0, 255);
                        score.text = _LeaderboardMain.urScore.text;
                        name.text = nameInput.text;
                        PlayerPrefs.SetString("Scores4thJ", score.text);
                        PlayerPrefs.SetString("Name4thJ", name.text);

                        Scores = GameObject.Find("scoreTextJ3");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores3rdJ");
                        Names = GameObject.Find("nameTextJ3");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name3rdJ");
                        PlayerPrefs.SetString("Scores3rdJ", scoreNext.text);
                        PlayerPrefs.SetString("Name3rdJ", nameNext.text);

                        Scores = GameObject.Find("scoreTextJ2");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores2ndJ");
                        Names = GameObject.Find("nameTextJ2");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name2ndJ");
                        PlayerPrefs.SetString("Scores2ndJ", scoreNext.text);
                        PlayerPrefs.SetString("Name2ndJ", nameNext.text);

                        Scores = GameObject.Find("scoreTextJ1");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores1stJ");
                        Names = GameObject.Find("nameTextJ1");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name1stJ");
                        PlayerPrefs.SetString("Scores1stJ", scoreNext.text);
                        PlayerPrefs.SetString("Name1stJ", nameNext.text);
                    }
                    else if (Globals.overallScore < scoreComparison)
                    {
                        Scores = GameObject.Find("scoreTextJ5");
                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        score.text = PlayerPrefs.GetString("Scores5thJ");
                        scoreComparison = Convert.ToInt32(score.text);
                        Names = GameObject.Find("nameTextJ5");
                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        name.text = PlayerPrefs.GetString("Name4thJ");

                        //checking if #5
                        if (Globals.overallScore > scoreComparison)
                        {
                            //pushing scores lower
                            Scores = GameObject.Find("scoreTextJ11");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores10thJ");
                            Names = GameObject.Find("nameTextJ11");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name10thJ");
                            PlayerPrefs.SetString("Scores11thJ", scoreNext.text);
                            PlayerPrefs.SetString("Name11thJ", nameNext.text);

                            Scores = GameObject.Find("scoreTextJ10");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores9thJ");
                            Names = GameObject.Find("nameTextJ10");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name9thJ");
                            PlayerPrefs.SetString("Scores10thJ", scoreNext.text);
                            PlayerPrefs.SetString("Name10thJ", nameNext.text);

                            Scores = GameObject.Find("scoreTextJ9");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores8thJ");
                            Names = GameObject.Find("nameTextJ9");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name8thJ");
                            PlayerPrefs.SetString("Scores9thJ", scoreNext.text);
                            PlayerPrefs.SetString("Name9thJ", nameNext.text);

                            Scores = GameObject.Find("scoreTextJ8");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores7thJ");
                            Names = GameObject.Find("nameTextJ8");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name7thJ");
                            PlayerPrefs.SetString("Scores8thJ", scoreNext.text);
                            PlayerPrefs.SetString("Name8thJ", nameNext.text);

                            Scores = GameObject.Find("scoreTextJ7");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores6thJ");
                            Names = GameObject.Find("nameTextJ7");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name6thJ");
                            PlayerPrefs.SetString("Scores7thJ", scoreNext.text);
                            PlayerPrefs.SetString("Name7thJ", nameNext.text);

                            Scores = GameObject.Find("scoreTextJ6");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores5thJ");
                            Names = GameObject.Find("nameTextJ6");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name5thJ");
                            PlayerPrefs.SetString("Scores6thJ", scoreNext.text);
                            PlayerPrefs.SetString("Name6thJ", nameNext.text);

                            Pos = GameObject.Find("posTextJ5");
                            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                            pos.fontStyle = FontStyles.Bold;
                            pos.color = new Color32(246, 255, 0, 255);
                            Scores = GameObject.Find("scoreTextJ5");
                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            score.fontStyle = FontStyles.Bold;
                            score.color = new Color32(246, 255, 0, 255);
                            Names = GameObject.Find("nameTextJ5");
                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            name.fontStyle = FontStyles.Bold;
                            name.color = new Color32(246, 255, 0, 255);
                            score.text = _LeaderboardMain.urScore.text;
                            name.text = nameInput.text;
                            PlayerPrefs.SetString("Scores5thJ", score.text);
                            PlayerPrefs.SetString("Name5thJ", name.text);

                            Scores = GameObject.Find("scoreTextJ4");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores4thJ");
                            Names = GameObject.Find("nameTextJ4");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name4thJ");
                            PlayerPrefs.SetString("Scores4thJ", scoreNext.text);
                            PlayerPrefs.SetString("Name4thJ", nameNext.text);

                            Scores = GameObject.Find("scoreTextJ3");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores3rdJ");
                            Names = GameObject.Find("nameTextJ3");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name3rdJ");
                            PlayerPrefs.SetString("Scores3rdJ", scoreNext.text);
                            PlayerPrefs.SetString("Name3rdJ", nameNext.text);

                            Scores = GameObject.Find("scoreTextJ2");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores2ndJ");
                            Names = GameObject.Find("nameTextJ2");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name2ndJ");
                            PlayerPrefs.SetString("Scores2ndJ", scoreNext.text);
                            PlayerPrefs.SetString("Name2ndJ", nameNext.text);

                            Scores = GameObject.Find("scoreTextJ1");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores1stJ");
                            Names = GameObject.Find("nameTextJ1");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name1stJ");
                            PlayerPrefs.SetString("Scores1stJ", scoreNext.text);
                            PlayerPrefs.SetString("Name1stJ", nameNext.text);
                        }
                        else if (Globals.overallScore < scoreComparison)
                        {
                            Scores = GameObject.Find("scoreTextJ6");
                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            score.text = PlayerPrefs.GetString("Scores6thJ");
                            scoreComparison = Convert.ToInt32(score.text);
                            Names = GameObject.Find("nameTextJ6");
                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            name.text = PlayerPrefs.GetString("Name6thJ");

                            //checking if #6
                            if (Globals.overallScore > scoreComparison)
                            {
                                //pushing scores lower
                                Scores = GameObject.Find("scoreTextJ11");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores10thJ");
                                Names = GameObject.Find("nameTextJ11");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name10thJ");
                                PlayerPrefs.SetString("Scores11thJ", scoreNext.text);
                                PlayerPrefs.SetString("Name11thJ", nameNext.text);

                                Scores = GameObject.Find("scoreTextJ10");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores9thJ");
                                Names = GameObject.Find("nameTextJ10");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name9thJ");
                                PlayerPrefs.SetString("Scores10thJ", scoreNext.text);
                                PlayerPrefs.SetString("Name10thJ", nameNext.text);

                                Scores = GameObject.Find("scoreTextJ9");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores8thJ");
                                Names = GameObject.Find("nameTextJ9");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name8thJ");
                                PlayerPrefs.SetString("Scores9thJ", scoreNext.text);
                                PlayerPrefs.SetString("Name9thJ", nameNext.text);

                                Scores = GameObject.Find("scoreTextJ8");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores7thJ");
                                Names = GameObject.Find("nameTextJ8");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name7thJ");
                                PlayerPrefs.SetString("Scores8thJ", scoreNext.text);
                                PlayerPrefs.SetString("Name8thJ", nameNext.text);

                                Scores = GameObject.Find("scoreTextJ7");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores6thJ");
                                Names = GameObject.Find("nameTextJ7");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name6thJ");
                                PlayerPrefs.SetString("Scores7thJ", scoreNext.text);
                                PlayerPrefs.SetString("Name7thJ", nameNext.text);

                                Pos = GameObject.Find("posTextJ6");
                                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                pos.fontStyle = FontStyles.Bold;
                                pos.color = new Color32(246, 255, 0, 255);
                                Scores = GameObject.Find("scoreTextJ6");
                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                score.fontStyle = FontStyles.Bold;
                                score.color = new Color32(246, 255, 0, 255);
                                Names = GameObject.Find("nameTextJ6");
                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                name.fontStyle = FontStyles.Bold;
                                name.color = new Color32(246, 255, 0, 255);
                                score.text = _LeaderboardMain.urScore.text;
                                name.text = nameInput.text;
                                PlayerPrefs.SetString("Scores6thJ", score.text);
                                PlayerPrefs.SetString("Name6thJ", name.text);

                                Scores = GameObject.Find("scoreTextJ5");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores5thJ");
                                Names = GameObject.Find("nameTextJ5");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name5thJ");
                                PlayerPrefs.SetString("Scores5thJ", scoreNext.text);
                                PlayerPrefs.SetString("Name5thJ", nameNext.text);

                                Scores = GameObject.Find("scoreTextJ4");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores4thJ");
                                Names = GameObject.Find("nameTextJ4");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name4thJ");
                                PlayerPrefs.SetString("Scores4thJ", scoreNext.text);
                                PlayerPrefs.SetString("Name4thJ", nameNext.text);

                                Scores = GameObject.Find("scoreTextJ3");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores3rdJ");
                                Names = GameObject.Find("nameTextJ3");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name3rdJ");
                                PlayerPrefs.SetString("Scores3rdJ", scoreNext.text);
                                PlayerPrefs.SetString("Name3rdJ", nameNext.text);

                                Scores = GameObject.Find("scoreTextJ2");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores2ndJ");
                                Names = GameObject.Find("nameTextJ2");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name2ndJ");
                                PlayerPrefs.SetString("Scores2ndJ", scoreNext.text);
                                PlayerPrefs.SetString("Name2ndJ", nameNext.text);

                                Scores = GameObject.Find("scoreTextJ1");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores1stJ");
                                Names = GameObject.Find("nameTextJ1");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name1stJ");
                                PlayerPrefs.SetString("Scores1stJ", scoreNext.text);
                                PlayerPrefs.SetString("Name1stJ", nameNext.text);
                            }
                            else if (Globals.overallScore < scoreComparison)
                            {
                                Scores = GameObject.Find("scoreTextJ7");
                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                score.text = PlayerPrefs.GetString("Scores7thJ");
                                scoreComparison = Convert.ToInt32(score.text);
                                Names = GameObject.Find("nameTextJ7");
                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                name.text = PlayerPrefs.GetString("Name7thJ");

                                //checking if #7
                                if (Globals.overallScore > scoreComparison)
                                {
                                    //pushing scores lower
                                    Scores = GameObject.Find("scoreTextJ11");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores10thJ");
                                    Names = GameObject.Find("nameTextJ11");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name10thJ");
                                    PlayerPrefs.SetString("Scores11thJ", scoreNext.text);
                                    PlayerPrefs.SetString("Name11thJ", nameNext.text);

                                    Scores = GameObject.Find("scoreTextJ10");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores9thJ");
                                    Names = GameObject.Find("nameTextJ10");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name9thJ");
                                    PlayerPrefs.SetString("Scores10thJ", scoreNext.text);
                                    PlayerPrefs.SetString("Name10thJ", nameNext.text);

                                    Scores = GameObject.Find("scoreTextJ9");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores8thJ");
                                    Names = GameObject.Find("nameTextJ9");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name8thJ");
                                    PlayerPrefs.SetString("Scores9thJ", scoreNext.text);
                                    PlayerPrefs.SetString("Name9thJ", nameNext.text);

                                    Scores = GameObject.Find("scoreTextJ8");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores7thJ");
                                    Names = GameObject.Find("nameTextJ8");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name7thJ");
                                    PlayerPrefs.SetString("Scores8thJ", scoreNext.text);
                                    PlayerPrefs.SetString("Name8thJ", nameNext.text);

                                    Pos = GameObject.Find("posTextJ7");
                                    pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                    pos.fontStyle = FontStyles.Bold;
                                    pos.color = new Color32(246, 255, 0, 255);
                                    Scores = GameObject.Find("scoreTextJ7");
                                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    score.fontStyle = FontStyles.Bold;
                                    score.color = new Color32(246, 255, 0, 255);
                                    Names = GameObject.Find("nameTextJ7");
                                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    name.fontStyle = FontStyles.Bold;
                                    name.color = new Color32(246, 255, 0, 255);
                                    score.text = _LeaderboardMain.urScore.text;
                                    name.text = nameInput.text;
                                    PlayerPrefs.SetString("Scores7thJ", score.text);
                                    PlayerPrefs.SetString("Name7thJ", name.text);

                                    Scores = GameObject.Find("scoreTextJ6");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores6thJ");
                                    Names = GameObject.Find("nameTextJ6");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name6thJ");
                                    PlayerPrefs.SetString("Scores6thJ", scoreNext.text);
                                    PlayerPrefs.SetString("Name6thJ", nameNext.text);

                                    Scores = GameObject.Find("scoreTextJ5");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores5thJ");
                                    Names = GameObject.Find("nameTextJ5");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name5thJ");
                                    PlayerPrefs.SetString("Scores5thJ", scoreNext.text);
                                    PlayerPrefs.SetString("Name5thJ", nameNext.text);

                                    Scores = GameObject.Find("scoreTextJ4");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores4thJ");
                                    Names = GameObject.Find("nameTextJ4");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name4thJ");
                                    PlayerPrefs.SetString("Scores4thJ", scoreNext.text);
                                    PlayerPrefs.SetString("Name4thJ", nameNext.text);

                                    Scores = GameObject.Find("scoreTextJ3");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores3rdJ");
                                    Names = GameObject.Find("nameTextJ3");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name3rdJ");
                                    PlayerPrefs.SetString("Scores3rdJ", scoreNext.text);
                                    PlayerPrefs.SetString("Name3rdJ", nameNext.text);

                                    Scores = GameObject.Find("scoreTextJ2");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores2ndJ");
                                    Names = GameObject.Find("nameTextJ2");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name2ndJ");
                                    PlayerPrefs.SetString("Scores2ndJ", scoreNext.text);
                                    PlayerPrefs.SetString("Name2ndJ", nameNext.text);

                                    Scores = GameObject.Find("scoreTextJ1");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores1stJ");
                                    Names = GameObject.Find("nameTextJ1");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name1stJ");
                                    PlayerPrefs.SetString("Scores1stJ", scoreNext.text);
                                    PlayerPrefs.SetString("Name1stJ", nameNext.text);
                                }
                                else if (Globals.overallScore < scoreComparison)
                                {
                                    Scores = GameObject.Find("scoreTextJ8");
                                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    score.text = PlayerPrefs.GetString("Scores8thJ");
                                    scoreComparison = Convert.ToInt32(score.text);
                                    Names = GameObject.Find("nameTextJ8");
                                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    name.text = PlayerPrefs.GetString("Name8thJ");

                                    //checking if #8
                                    if (Globals.overallScore > scoreComparison)
                                    {
                                        //pushing scores lower
                                        Scores = GameObject.Find("scoreTextJ11");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores10thJ");
                                        Names = GameObject.Find("nameTextJ11");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name10thJ");
                                        PlayerPrefs.SetString("Scores11thJ", scoreNext.text);
                                        PlayerPrefs.SetString("Name11thJ", nameNext.text);

                                        Scores = GameObject.Find("scoreTextJ10");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores9thJ");
                                        Names = GameObject.Find("nameTextJ10");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name9thJ");
                                        PlayerPrefs.SetString("Scores10thJ", scoreNext.text);
                                        PlayerPrefs.SetString("Name10thJ", nameNext.text);

                                        Scores = GameObject.Find("scoreTextJ9");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores8thJ");
                                        Names = GameObject.Find("nameTextJ9");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name8thJ");
                                        PlayerPrefs.SetString("Scores9thJ", scoreNext.text);
                                        PlayerPrefs.SetString("Name9thJ", nameNext.text);

                                        Pos = GameObject.Find("posTextJ8");
                                        pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                        pos.fontStyle = FontStyles.Bold;
                                        pos.color = new Color32(246, 255, 0, 255);
                                        Scores = GameObject.Find("scoreTextJ8");
                                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        score.fontStyle = FontStyles.Bold;
                                        score.color = new Color32(246, 255, 0, 255);
                                        Names = GameObject.Find("nameTextJ8");
                                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        name.fontStyle = FontStyles.Bold;
                                        name.color = new Color32(246, 255, 0, 255);
                                        score.text = _LeaderboardMain.urScore.text;
                                        name.text = nameInput.text;
                                        PlayerPrefs.SetString("Scores8thJ", score.text);
                                        PlayerPrefs.SetString("Name8thJ", name.text);

                                        Scores = GameObject.Find("scoreTextJ7");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores7thJ");
                                        Names = GameObject.Find("nameTextJ7");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name7thJ");
                                        PlayerPrefs.SetString("Scores7thJ", scoreNext.text);
                                        PlayerPrefs.SetString("Name7thJ", nameNext.text);

                                        Scores = GameObject.Find("scoreTextJ6");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores6thJ");
                                        Names = GameObject.Find("nameTextJ6");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name6thJ");
                                        PlayerPrefs.SetString("Scores6thJ", scoreNext.text);
                                        PlayerPrefs.SetString("Name6thJ", nameNext.text);

                                        Scores = GameObject.Find("scoreTextJ5");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores5thJ");
                                        Names = GameObject.Find("nameTextJ5");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name5thJ");
                                        PlayerPrefs.SetString("Scores5thJ", scoreNext.text);
                                        PlayerPrefs.SetString("Name5thJ", nameNext.text);

                                        Scores = GameObject.Find("scoreTextJ4");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores4thJ");
                                        Names = GameObject.Find("nameTextJ4");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name4thJ");
                                        PlayerPrefs.SetString("Scores4thJ", scoreNext.text);
                                        PlayerPrefs.SetString("Name4thJ", nameNext.text);

                                        Scores = GameObject.Find("scoreTextJ3");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores3rdJ");
                                        Names = GameObject.Find("nameTextJ3");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name3rdJ");
                                        PlayerPrefs.SetString("Scores3rdJ", scoreNext.text);
                                        PlayerPrefs.SetString("Name3rdJ", nameNext.text);

                                        Scores = GameObject.Find("scoreTextJ2");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores2ndJ");
                                        Names = GameObject.Find("nameTextJ2");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name2ndJ");
                                        PlayerPrefs.SetString("Scores2ndJ", scoreNext.text);
                                        PlayerPrefs.SetString("Name2ndJ", nameNext.text);

                                        Scores = GameObject.Find("scoreTextJ1");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores1stJ");
                                        Names = GameObject.Find("nameTextJ1");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name1stJ");
                                        PlayerPrefs.SetString("Scores1stJ", scoreNext.text);
                                        PlayerPrefs.SetString("Name1stJ", nameNext.text);
                                    }
                                    else if (Globals.overallScore < scoreComparison)
                                    {
                                        Scores = GameObject.Find("scoreTextJ9");
                                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        score.text = PlayerPrefs.GetString("Scores9thJ");
                                        scoreComparison = Convert.ToInt32(score.text);
                                        Names = GameObject.Find("nameTextJ9");
                                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        name.text = PlayerPrefs.GetString("Name9thJ");

                                        //checking if #9
                                        if (Globals.overallScore > scoreComparison)
                                        {
                                            //pushing scores lower
                                            Scores = GameObject.Find("scoreTextJ11");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores10thJ");
                                            Names = GameObject.Find("nameTextJ11");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name10thJ");
                                            PlayerPrefs.SetString("Scores11thJ", scoreNext.text);
                                            PlayerPrefs.SetString("Name11thJ", nameNext.text);

                                            Scores = GameObject.Find("scoreTextJ10");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores9thJ");
                                            Names = GameObject.Find("nameTextJ10");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name9thJ");
                                            PlayerPrefs.SetString("Scores10thJ", scoreNext.text);
                                            PlayerPrefs.SetString("Name10thJ", nameNext.text);

                                            Pos = GameObject.Find("posTextJ9");
                                            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                            pos.fontStyle = FontStyles.Bold;
                                            pos.color = new Color32(246, 255, 0, 255);
                                            Scores = GameObject.Find("scoreTextJ9");
                                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            score.fontStyle = FontStyles.Bold;
                                            score.color = new Color32(246, 255, 0, 255);
                                            Names = GameObject.Find("nameTextJ9");
                                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            name.fontStyle = FontStyles.Bold;
                                            name.color = new Color32(246, 255, 0, 255);
                                            score.text = _LeaderboardMain.urScore.text;
                                            name.text = nameInput.text;
                                            PlayerPrefs.SetString("Scores9thJ", score.text);
                                            PlayerPrefs.SetString("Name9thJ", name.text);

                                            Scores = GameObject.Find("scoreTextJ8");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores8thJ");
                                            Names = GameObject.Find("nameTextJ8");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name8thJ");
                                            PlayerPrefs.SetString("Scores8thJ", scoreNext.text);
                                            PlayerPrefs.SetString("Name8thJ", nameNext.text);

                                            Scores = GameObject.Find("scoreTextJ7");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores7thJ");
                                            Names = GameObject.Find("nameTextJ7");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name7thJ");
                                            PlayerPrefs.SetString("Scores7thJ", scoreNext.text);
                                            PlayerPrefs.SetString("Name7thJ", nameNext.text);

                                            Scores = GameObject.Find("scoreTextJ6");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores6thJ");
                                            Names = GameObject.Find("nameTextJ6");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name6thJ");
                                            PlayerPrefs.SetString("Scores6thJ", scoreNext.text);
                                            PlayerPrefs.SetString("Name6thJ", nameNext.text);

                                            Scores = GameObject.Find("scoreTextJ5");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores5thJ");
                                            Names = GameObject.Find("nameTextJ5");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name5thJ");
                                            PlayerPrefs.SetString("Scores5thJ", scoreNext.text);
                                            PlayerPrefs.SetString("Name5thJ", nameNext.text);

                                            Scores = GameObject.Find("scoreTextJ4");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores4thJ");
                                            Names = GameObject.Find("nameTextJ4");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name4thJ");
                                            PlayerPrefs.SetString("Scores4thJ", scoreNext.text);
                                            PlayerPrefs.SetString("Name4th", nameNext.text);

                                            Scores = GameObject.Find("scoreTextJ3");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores3rdJ");
                                            Names = GameObject.Find("nameTextJ3");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name3rdJ");
                                            PlayerPrefs.SetString("Scores3rdJ", scoreNext.text);
                                            PlayerPrefs.SetString("Name3rdJ", nameNext.text);

                                            Scores = GameObject.Find("scoreTextJ2");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores2ndJ");
                                            Names = GameObject.Find("nameTextJ2");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name2ndJ");
                                            PlayerPrefs.SetString("Scores2ndJ", scoreNext.text);
                                            PlayerPrefs.SetString("Name2ndJ", nameNext.text);

                                            Scores = GameObject.Find("scoreTextJ1");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores1stJ");
                                            Names = GameObject.Find("nameTextJ1");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name1stJ");
                                            PlayerPrefs.SetString("Scores1stJ", scoreNext.text);
                                            PlayerPrefs.SetString("Name1stJ", nameNext.text);
                                        }
                                        else if (Globals.overallScore < scoreComparison)
                                        {
                                            Scores = GameObject.Find("scoreTextJ10");
                                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            score.text = PlayerPrefs.GetString("Scores10thJ");
                                            scoreComparison = Convert.ToInt32(score.text);
                                            Names = GameObject.Find("nameTextJ10");
                                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            name.text = PlayerPrefs.GetString("Name10thJ");

                                            //checking if #10
                                            if (Globals.overallScore > scoreComparison)
                                            {
                                                //pushing scores lower
                                                Scores = GameObject.Find("scoreTextJ11");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores10thJ");
                                                Names = GameObject.Find("nameTextJ11");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name10thJ");
                                                PlayerPrefs.SetString("Scores11thJ", scoreNext.text);
                                                PlayerPrefs.SetString("Name11thJ", nameNext.text);

                                                Pos = GameObject.Find("posTextJ10");
                                                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                                pos.fontStyle = FontStyles.Bold;
                                                pos.color = new Color32(246, 255, 0, 255);
                                                Scores = GameObject.Find("scoreTextJ10");
                                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                score.fontStyle = FontStyles.Bold;
                                                score.color = new Color32(246, 255, 0, 255);
                                                Names = GameObject.Find("nameTextJ10");
                                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                name.fontStyle = FontStyles.Bold;
                                                name.color = new Color32(246, 255, 0, 255);
                                                score.text = _LeaderboardMain.urScore.text;
                                                name.text = nameInput.text;
                                                PlayerPrefs.SetString("Scores10thJ", score.text);
                                                PlayerPrefs.SetString("Name10thJ", name.text);

                                                Scores = GameObject.Find("scoreTextJ9");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores9thJ");
                                                Names = GameObject.Find("nameTextJ9");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name9thJ");
                                                PlayerPrefs.SetString("Scores9thJ", scoreNext.text);
                                                PlayerPrefs.SetString("Name9thJ", nameNext.text);

                                                Scores = GameObject.Find("scoreTextJ8");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores8thJ");
                                                Names = GameObject.Find("nameTextJ8");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name8thJ");
                                                PlayerPrefs.SetString("Scores8thJ", scoreNext.text);
                                                PlayerPrefs.SetString("Name8thJ", nameNext.text);

                                                Scores = GameObject.Find("scoreTextJ7");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores7thJ");
                                                Names = GameObject.Find("nameTextJ7");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name7thJ");
                                                PlayerPrefs.SetString("Scores7thJ", scoreNext.text);
                                                PlayerPrefs.SetString("Name7thJ", nameNext.text);

                                                Scores = GameObject.Find("scoreTextJ6");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores6thJ");
                                                Names = GameObject.Find("nameTextJ6");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name6thJ");
                                                PlayerPrefs.SetString("Scores6thJ", scoreNext.text);
                                                PlayerPrefs.SetString("Name6thJ", nameNext.text);

                                                Scores = GameObject.Find("scoreTextJ5");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores5thJ");
                                                Names = GameObject.Find("nameTextJ5");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name5thJ");
                                                PlayerPrefs.SetString("Scores5thJ", scoreNext.text);
                                                PlayerPrefs.SetString("Name5thJ", nameNext.text);

                                                Scores = GameObject.Find("scoreTextJ4");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores4thJ");
                                                Names = GameObject.Find("nameTextJ4");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name4thJ");
                                                PlayerPrefs.SetString("Scores4thJ", scoreNext.text);
                                                PlayerPrefs.SetString("Name4thJ", nameNext.text);

                                                Scores = GameObject.Find("scoreTextJ3");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores3rdJ");
                                                Names = GameObject.Find("nameTextJ3");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name3rdJ");
                                                PlayerPrefs.SetString("Scores3rdJ", scoreNext.text);
                                                PlayerPrefs.SetString("Name3rdJ", nameNext.text);

                                                Scores = GameObject.Find("scoreTextJ2");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores2ndJ");
                                                Names = GameObject.Find("nameTextJ2");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name2ndJ");
                                                PlayerPrefs.SetString("Scores2ndJ", scoreNext.text);
                                                PlayerPrefs.SetString("Name2ndJ", nameNext.text);

                                                Scores = GameObject.Find("scoreTextJ1");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores1stJ");
                                                Names = GameObject.Find("nameTextJ1");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name1stJ");
                                                PlayerPrefs.SetString("Scores1stJ", scoreNext.text);
                                                PlayerPrefs.SetString("Name1stJ", nameNext.text);
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

    public void JerryViewing()
    {
        Scores = GameObject.Find("scoreTextJ1");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores1stJ");
        Names = GameObject.Find("nameTextJ1");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name1stJ");

        Scores = GameObject.Find("scoreTextJ2");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores2ndJ");
        Names = GameObject.Find("nameTextJ2");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name2ndJ");

        Scores = GameObject.Find("scoreTextJ3");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores3rdJ");
        Names = GameObject.Find("nameTextJ3");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name3rdJ");

        Scores = GameObject.Find("scoreTextJ4");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores4thJ");
        Names = GameObject.Find("nameTextJ4");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name4thJ");

        Scores = GameObject.Find("scoreTextJ5");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores5thJ");
        Names = GameObject.Find("nameTextJ5");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name5thJ");

        Scores = GameObject.Find("scoreTextJ6");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores6thJ");
        Names = GameObject.Find("nameTextJ6");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name6thJ");

        Scores = GameObject.Find("scoreTextJ7");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores7thJ");
        Names = GameObject.Find("nameTextJ7");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name7thJ");

        Scores = GameObject.Find("scoreTextJ8");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores8thJ");
        Names = GameObject.Find("nameTextJ8");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name8thJ");

        Scores = GameObject.Find("scoreTextJ9");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores9thJ");
        Names = GameObject.Find("nameTextJ9");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name9thJ");

        Scores = GameObject.Find("scoreTextJ10");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores10thJ");
        Names = GameObject.Find("nameTextJ10");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name10thJ");
    }
}
