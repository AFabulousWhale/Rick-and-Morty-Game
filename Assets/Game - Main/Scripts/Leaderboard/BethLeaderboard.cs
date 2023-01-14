using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using TMPro;

public class BethLeaderboard : MonoBehaviour
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

    public void BethPlacement()
    {
        Scores = GameObject.Find("scoreTextB1");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores1stB");
        scoreComparison = Convert.ToInt32(score.text);
        Names = GameObject.Find("nameTextB1");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name1stB");

        //checking if #1
        if (Globals.overallScore > scoreComparison)
        {
            //pushing scores lower
            Scores = GameObject.Find("scoreTextB11");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores10thB");
            Names = GameObject.Find("nameTextB11");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name10thB");
            PlayerPrefs.SetString("Scores11thB", scoreNext.text);
            PlayerPrefs.SetString("Name11thB", nameNext.text);

            Scores = GameObject.Find("scoreTextB10");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores9thB");
            Names = GameObject.Find("nameTextB10");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name9thB");
            PlayerPrefs.SetString("Scores10thB", scoreNext.text);
            PlayerPrefs.SetString("Name10thB", nameNext.text);

            Scores = GameObject.Find("scoreTextB9");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores8thB");
            Names = GameObject.Find("nameTextB9");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name8thB");
            PlayerPrefs.SetString("Scores9thB", scoreNext.text);
            PlayerPrefs.SetString("Name9thB", nameNext.text);

            Scores = GameObject.Find("scoreTextB8");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores7thB");
            Names = GameObject.Find("nameTextB8");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name7thB");
            PlayerPrefs.SetString("Scores8thB", scoreNext.text);
            PlayerPrefs.SetString("Name8thB", nameNext.text);

            Scores = GameObject.Find("scoreTextB7");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores6thB");
            Names = GameObject.Find("nameTextB7");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name6thB");
            PlayerPrefs.SetString("Scores7thB", scoreNext.text);
            PlayerPrefs.SetString("Name7thB", nameNext.text);

            Scores = GameObject.Find("scoreTextB6");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores5thB");
            Names = GameObject.Find("nameTextB6");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name5thB");
            PlayerPrefs.SetString("Scores6thB", scoreNext.text);
            PlayerPrefs.SetString("Name6thB", nameNext.text);

            Scores = GameObject.Find("scoreTextB5");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores4thB");
            Names = GameObject.Find("nameTextB5");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name4thB");
            PlayerPrefs.SetString("Scores5thB", scoreNext.text);
            PlayerPrefs.SetString("Name5thB", nameNext.text);

            Scores = GameObject.Find("scoreTextB4");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores3rdB");
            Names = GameObject.Find("nameTextB4");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name3rdB");
            PlayerPrefs.SetString("Scores4thB", scoreNext.text);
            PlayerPrefs.SetString("Name4thB", nameNext.text);

            Scores = GameObject.Find("scoreTextB3");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores2ndB");
            Names = GameObject.Find("nameTextB3");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name2ndB");
            PlayerPrefs.SetString("Scores3rdB", scoreNext.text);
            PlayerPrefs.SetString("Name3rdB", nameNext.text);

            Scores = GameObject.Find("scoreTextB2");
            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            scoreNext.text = PlayerPrefs.GetString("Scores1stB");
            Names = GameObject.Find("nameTextB2");
            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
            nameNext.text = PlayerPrefs.GetString("Name1stB");
            PlayerPrefs.SetString("Scores2ndB", scoreNext.text);
            PlayerPrefs.SetString("Name2ndB", nameNext.text);

            Pos = GameObject.Find("posTextB1");
            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
            pos.fontStyle = FontStyles.Bold;
            pos.color = new Color32(246, 255, 0, 255);
            Scores = GameObject.Find("scoreTextB1");
            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            score.fontStyle = FontStyles.Bold;
            score.color = new Color32(246, 255, 0, 255);
            Names = GameObject.Find("nameTextB1");
            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
            name.fontStyle = FontStyles.Bold;
            name.color = new Color32(246, 255, 0, 255);
            score.text = _LeaderboardMain.urScore.text;
            name.text = nameInput.text;
            PlayerPrefs.SetString("Scores1stB", score.text);
            PlayerPrefs.SetString("Name1stB", name.text);
        }
        else if (Globals.overallScore < scoreComparison)
        {
            Scores = GameObject.Find("scoreTextB2");
            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
            score.text = PlayerPrefs.GetString("Scores2ndB");
            scoreComparison = Convert.ToInt32(score.text);
            Names = GameObject.Find("nameTextB2");
            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
            name.text = PlayerPrefs.GetString("Name2ndB");

            //checking if #2
            if (Globals.overallScore > scoreComparison)
            {
                //pushing scores lower
                Scores = GameObject.Find("scoreTextB11");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores10thB");
                Names = GameObject.Find("nameTextB11");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name10thB");
                PlayerPrefs.SetString("Scores11thB", scoreNext.text);
                PlayerPrefs.SetString("Name11thB", nameNext.text);

                Scores = GameObject.Find("scoreTextB10");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores9thB");
                Names = GameObject.Find("nameTextB10");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name9thB");
                PlayerPrefs.SetString("Scores10thB", scoreNext.text);
                PlayerPrefs.SetString("Name10thB", nameNext.text);

                Scores = GameObject.Find("scoreTextB9");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores8thB");
                Names = GameObject.Find("nameTextB9");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name8thB");
                PlayerPrefs.SetString("Scores9thB", scoreNext.text);
                PlayerPrefs.SetString("Name9thB", nameNext.text);

                Scores = GameObject.Find("scoreTextB8");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores7thB");
                Names = GameObject.Find("nameTextB8");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name7thB");
                PlayerPrefs.SetString("Scores8thB", scoreNext.text);
                PlayerPrefs.SetString("Name8thB", nameNext.text);

                Scores = GameObject.Find("scoreTextB7");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores6thB");
                Names = GameObject.Find("nameTextB7");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name6thB");
                PlayerPrefs.SetString("Scores7thB", scoreNext.text);
                PlayerPrefs.SetString("Name7thB", nameNext.text);

                Scores = GameObject.Find("scoreTextB6");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores5thB");
                Names = GameObject.Find("nameTextB6");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name5thB");
                PlayerPrefs.SetString("Scores6thB", scoreNext.text);
                PlayerPrefs.SetString("Name6thB", nameNext.text);

                Scores = GameObject.Find("scoreTextB5");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores4thB");
                Names = GameObject.Find("nameTextB5");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name4thB");
                PlayerPrefs.SetString("Scores5thB", scoreNext.text);
                PlayerPrefs.SetString("Name5thB", nameNext.text);

                Scores = GameObject.Find("scoreTextB4");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores3rdB");
                Names = GameObject.Find("nameTextB4");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name3rdB");
                PlayerPrefs.SetString("Scores4thB", scoreNext.text);
                PlayerPrefs.SetString("Name4thB", nameNext.text);

                Scores = GameObject.Find("scoreTextB3");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores2ndB");
                Names = GameObject.Find("nameTextB3");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name2ndB");
                PlayerPrefs.SetString("Scores3rdB", scoreNext.text);
                PlayerPrefs.SetString("Name3rdB", nameNext.text);

                Pos = GameObject.Find("posTextB2");
                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                pos.fontStyle = FontStyles.Bold;
                pos.color = new Color32(246, 255, 0, 255);
                Scores = GameObject.Find("scoreTextB2");
                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                score.fontStyle = FontStyles.Bold;
                score.color = new Color32(246, 255, 0, 255);
                Names = GameObject.Find("nameTextB2");
                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                name.fontStyle = FontStyles.Bold;
                name.color = new Color32(246, 255, 0, 255);
                score.text = _LeaderboardMain.urScore.text;
                name.text = nameInput.text;
                PlayerPrefs.SetString("Scores2ndB", score.text);
                PlayerPrefs.SetString("Name2ndB", name.text);

                Scores = GameObject.Find("scoreTextB1");
                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                scoreNext.text = PlayerPrefs.GetString("Scores1stB");
                Names = GameObject.Find("nameTextB1");
                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                nameNext.text = PlayerPrefs.GetString("Name1stB");
                PlayerPrefs.SetString("Scores1stB", scoreNext.text);
                PlayerPrefs.SetString("Name1stB", nameNext.text);
            }
            else if (Globals.overallScore < scoreComparison)
            {
                Scores = GameObject.Find("scoreTextB3");
                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                score.text = PlayerPrefs.GetString("Scores3rdB");
                scoreComparison = Convert.ToInt32(score.text);
                Names = GameObject.Find("nameTextB3");
                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                name.text = PlayerPrefs.GetString("Name3rdB");

                //checking if #3
                if (Convert.ToInt32(_LeaderboardMain.urScore) > scoreComparison)
                {
                    //pushing scores lower
                    Scores = GameObject.Find("scoreTextB11");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores10thB");
                    Names = GameObject.Find("nameTextB11");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name10thB");
                    PlayerPrefs.SetString("Scores11thB", scoreNext.text);
                    PlayerPrefs.SetString("Name11thB", nameNext.text);

                    Scores = GameObject.Find("scoreTextB10");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores9thB");
                    Names = GameObject.Find("nameTextB10");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name9thB");
                    PlayerPrefs.SetString("Scores10thB", scoreNext.text);
                    PlayerPrefs.SetString("Name10thB", nameNext.text);

                    Scores = GameObject.Find("scoreTextB9");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores8thB");
                    Names = GameObject.Find("nameTextB8");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name8thB");
                    PlayerPrefs.SetString("Scores9thB", scoreNext.text);
                    PlayerPrefs.SetString("Name9thB", nameNext.text);

                    Scores = GameObject.Find("scoreTextB8");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores7thB");
                    Names = GameObject.Find("nameTextB8");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name7thB");
                    PlayerPrefs.SetString("Scores8thB", scoreNext.text);
                    PlayerPrefs.SetString("Name8thB", nameNext.text);

                    Scores = GameObject.Find("scoreTextB7");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores6thB");
                    Names = GameObject.Find("nameTextB7");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name6thB");
                    PlayerPrefs.SetString("Scores7thB", scoreNext.text);
                    PlayerPrefs.SetString("Name7thB", nameNext.text);

                    Scores = GameObject.Find("scoreTextB6");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores5thB");
                    Names = GameObject.Find("nameTextB6");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name5thB");
                    PlayerPrefs.SetString("Scores6thB", scoreNext.text);
                    PlayerPrefs.SetString("Name6thB", nameNext.text);

                    Scores = GameObject.Find("scoreTextB5");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores4thB");
                    Names = GameObject.Find("nameTextB5");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name4thB");
                    PlayerPrefs.SetString("Scores5thB", scoreNext.text);
                    PlayerPrefs.SetString("Name5thB", nameNext.text);

                    Scores = GameObject.Find("scoreTextB4");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores3rdB");
                    Names = GameObject.Find("nameTextB4");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name3rdB");
                    PlayerPrefs.SetString("Scores4thB", scoreNext.text);
                    PlayerPrefs.SetString("Name4thB", nameNext.text);

                    Pos = GameObject.Find("posTextB3");
                    pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                    pos.fontStyle = FontStyles.Bold;
                    pos.color = new Color32(246, 255, 0, 255);
                    Scores = GameObject.Find("scoreTextB3");
                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    score.fontStyle = FontStyles.Bold;
                    score.color = new Color32(246, 255, 0, 255);
                    Names = GameObject.Find("nameTextB3");
                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    name.fontStyle = FontStyles.Bold;
                    name.color = new Color32(246, 255, 0, 255);
                    score.text = _LeaderboardMain.urScore.text;
                    name.text = nameInput.text;
                    PlayerPrefs.SetString("Scores3rdB", score.text);
                    PlayerPrefs.SetString("Name3rdB", name.text);

                    Scores = GameObject.Find("scoreTextB2");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores2ndB");
                    Names = GameObject.Find("nameTextB2");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name2ndB");
                    PlayerPrefs.SetString("Scores2ndB", scoreNext.text);
                    PlayerPrefs.SetString("Name2ndB", nameNext.text);

                    Scores = GameObject.Find("scoreTextB1");
                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    scoreNext.text = PlayerPrefs.GetString("Scores1stB");
                    Names = GameObject.Find("nameTextB1");
                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    nameNext.text = PlayerPrefs.GetString("Name1stB");
                    PlayerPrefs.SetString("Scores1stB", scoreNext.text);
                    PlayerPrefs.SetString("Name1stB", nameNext.text);
                }
                else if (Globals.overallScore < scoreComparison)
                {
                    Scores = GameObject.Find("scoreTextB4");
                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                    score.text = PlayerPrefs.GetString("Scores4thB");
                    scoreComparison = Convert.ToInt32(score.text);
                    Names = GameObject.Find("nameTextB4");
                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                    name.text = PlayerPrefs.GetString("Name4thB");

                    //checking if #4
                    if (Convert.ToInt32(_LeaderboardMain.urScore) > scoreComparison)
                    {
                        //pushing scores lower
                        Scores = GameObject.Find("scoreTextB11");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores10thB");
                        Names = GameObject.Find("nameTextB11");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name10thB");
                        PlayerPrefs.SetString("Scores11thB", scoreNext.text);
                        PlayerPrefs.SetString("Name11thB", nameNext.text);

                        Scores = GameObject.Find("scoreTextB10");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores9thB");
                        Names = GameObject.Find("nameTextB10");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name9thB");
                        PlayerPrefs.SetString("Scores10thB", scoreNext.text);
                        PlayerPrefs.SetString("Name10thB", nameNext.text);

                        Scores = GameObject.Find("scoreTextB9");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores8thB");
                        Names = GameObject.Find("nameTextB9");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name8thB");
                        PlayerPrefs.SetString("Scores9thB", scoreNext.text);
                        PlayerPrefs.SetString("Name9thB", nameNext.text);

                        Scores = GameObject.Find("scoreTextB8");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores7thB");
                        Names = GameObject.Find("nameTextB8");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name7thB");
                        PlayerPrefs.SetString("Scores8thB", scoreNext.text);
                        PlayerPrefs.SetString("Name8thB", nameNext.text);

                        Scores = GameObject.Find("scoreTextB7");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores6thB");
                        Names = GameObject.Find("nameTextB7");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name6thB");
                        PlayerPrefs.SetString("Scores7thB", scoreNext.text);
                        PlayerPrefs.SetString("Name7thB", nameNext.text);

                        Scores = GameObject.Find("scoreTextB6");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores5thB");
                        Names = GameObject.Find("nameTextB6");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name5thB");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        PlayerPrefs.SetString("Scores6thB", scoreNext.text);
                        PlayerPrefs.SetString("Name6thB", nameNext.text);

                        Scores = GameObject.Find("scoreTextB5");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores4thB");
                        Names = GameObject.Find("nameTextB5");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name4thB");
                        PlayerPrefs.SetString("Scores5thB", scoreNext.text);
                        PlayerPrefs.SetString("Name5thB", nameNext.text);

                        Pos = GameObject.Find("posTextB4");
                        pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                        pos.fontStyle = FontStyles.Bold;
                        pos.color = new Color32(246, 255, 0, 255);
                        Scores = GameObject.Find("scoreTextB4");
                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        score.fontStyle = FontStyles.Bold;
                        score.color = new Color32(246, 255, 0, 255);
                        Names = GameObject.Find("nameTextB4");
                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        name.fontStyle = FontStyles.Bold;
                        name.color = new Color32(246, 255, 0, 255);
                        score.text = _LeaderboardMain.urScore.text;
                        name.text = nameInput.text;
                        PlayerPrefs.SetString("Scores4thB", score.text);
                        PlayerPrefs.SetString("Name4thB", name.text);

                        Scores = GameObject.Find("scoreTextB3");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores3rdB");
                        Names = GameObject.Find("nameTextB3");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name3rdB");
                        PlayerPrefs.SetString("Scores3rdB", scoreNext.text);
                        PlayerPrefs.SetString("Name3rdB", nameNext.text);

                        Scores = GameObject.Find("scoreTextB2");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores2ndB");
                        Names = GameObject.Find("nameTextB2");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name2ndB");
                        PlayerPrefs.SetString("Scores2ndB", scoreNext.text);
                        PlayerPrefs.SetString("Name2ndB", nameNext.text);

                        Scores = GameObject.Find("scoreTextB1");
                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        scoreNext.text = PlayerPrefs.GetString("Scores1stB");
                        Names = GameObject.Find("nameTextB1");
                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        nameNext.text = PlayerPrefs.GetString("Name1stB");
                        PlayerPrefs.SetString("Scores1stB", scoreNext.text);
                        PlayerPrefs.SetString("Name1stB", nameNext.text);
                    }
                    else if (Globals.overallScore < scoreComparison)
                    {
                        Scores = GameObject.Find("scoreTextB5");
                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                        score.text = PlayerPrefs.GetString("Scores5thB");
                        scoreComparison = Convert.ToInt32(score.text);
                        Names = GameObject.Find("nameTextB5");
                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                        name.text = PlayerPrefs.GetString("Name4thB");

                        //checking if #5
                        if (Convert.ToInt32(_LeaderboardMain.urScore) > scoreComparison)
                        {
                            //pushing scores lower
                            Scores = GameObject.Find("scoreTextB11");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores10thB");
                            Names = GameObject.Find("nameTextB11");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name10thB");
                            PlayerPrefs.SetString("Scores11thB", scoreNext.text);
                            PlayerPrefs.SetString("Name11thB", nameNext.text);

                            Scores = GameObject.Find("scoreTextB10");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores9thB");
                            Names = GameObject.Find("nameTextB10");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name9thB");
                            PlayerPrefs.SetString("Scores10thB", scoreNext.text);
                            PlayerPrefs.SetString("Name10thB", nameNext.text);

                            Scores = GameObject.Find("scoreTextB9");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores8thB");
                            Names = GameObject.Find("nameTextB9");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name8thB");
                            PlayerPrefs.SetString("Scores9thB", scoreNext.text);
                            PlayerPrefs.SetString("Name9thB", nameNext.text);

                            Scores = GameObject.Find("scoreTextB8");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores7thB");
                            Names = GameObject.Find("nameTextB8");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name7thB");
                            PlayerPrefs.SetString("Scores8thB", scoreNext.text);
                            PlayerPrefs.SetString("Name8thB", nameNext.text);

                            Scores = GameObject.Find("scoreTextB7");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores6thB");
                            Names = GameObject.Find("nameTextB7");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name6thB");
                            PlayerPrefs.SetString("Scores7thB", scoreNext.text);
                            PlayerPrefs.SetString("Name7thB", nameNext.text);

                            Scores = GameObject.Find("scoreTextB6");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores5thB");
                            Names = GameObject.Find("nameTextB6");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name5thB");
                            PlayerPrefs.SetString("Scores6thB", scoreNext.text);
                            PlayerPrefs.SetString("Name6thB", nameNext.text);

                            Pos = GameObject.Find("posTextB5");
                            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                            pos.fontStyle = FontStyles.Bold;
                            pos.color = new Color32(246, 255, 0, 255);
                            Scores = GameObject.Find("scoreTextB5");
                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            score.fontStyle = FontStyles.Bold;
                            score.color = new Color32(246, 255, 0, 255);
                            Names = GameObject.Find("nameTextB5");
                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            name.fontStyle = FontStyles.Bold;
                            name.color = new Color32(246, 255, 0, 255);
                            score.text = _LeaderboardMain.urScore.text;
                            name.text = nameInput.text;
                            PlayerPrefs.SetString("Scores5thB", score.text);
                            PlayerPrefs.SetString("Name5thB", name.text);

                            Scores = GameObject.Find("scoreTextB4");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores4thB");
                            Names = GameObject.Find("nameTextB4");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name4thB");
                            PlayerPrefs.SetString("Scores4thB", scoreNext.text);
                            PlayerPrefs.SetString("Name4thB", nameNext.text);

                            Scores = GameObject.Find("scoreTextB3");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores3rdB");
                            Names = GameObject.Find("nameTextB3");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name3rdB");
                            PlayerPrefs.SetString("Scores3rdB", scoreNext.text);
                            PlayerPrefs.SetString("Name3rdB", nameNext.text);

                            Scores = GameObject.Find("scoreTextB2");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores2ndB");
                            Names = GameObject.Find("nameTextB2");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name2ndB");
                            PlayerPrefs.SetString("Scores2ndB", scoreNext.text);
                            PlayerPrefs.SetString("Name2ndB", nameNext.text);

                            Scores = GameObject.Find("scoreTextB1");
                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            scoreNext.text = PlayerPrefs.GetString("Scores1stB");
                            Names = GameObject.Find("nameTextB1");
                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            nameNext.text = PlayerPrefs.GetString("Name1stB");
                            PlayerPrefs.SetString("Scores1stB", scoreNext.text);
                            PlayerPrefs.SetString("Name1stB", nameNext.text);
                        }
                        else if (Globals.overallScore < scoreComparison)
                        {
                            Scores = GameObject.Find("scoreTextB6");
                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                            score.text = PlayerPrefs.GetString("Scores6thB");
                            scoreComparison = Convert.ToInt32(score.text);
                            Names = GameObject.Find("nameTextB6");
                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                            name.text = PlayerPrefs.GetString("Name6thB");

                            //checking if #6
                            if (Convert.ToInt32(_LeaderboardMain.urScore) > scoreComparison)
                            {
                                //pushing scores lower
                                Scores = GameObject.Find("scoreTextB11");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores10thB");
                                Names = GameObject.Find("nameTextB11");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name10thB");
                                PlayerPrefs.SetString("Scores11thB", scoreNext.text);
                                PlayerPrefs.SetString("Name11thB", nameNext.text);

                                Scores = GameObject.Find("scoreTextB10");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores9thB");
                                Names = GameObject.Find("nameTextB10");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name9thB");
                                PlayerPrefs.SetString("Scores10thB", scoreNext.text);
                                PlayerPrefs.SetString("Name10thB", nameNext.text);

                                Scores = GameObject.Find("scoreTextB9");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores8thB");
                                Names = GameObject.Find("nameTextB9");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name8thB");
                                PlayerPrefs.SetString("Scores9thB", scoreNext.text);
                                PlayerPrefs.SetString("Name9thB", nameNext.text);

                                Scores = GameObject.Find("scoreTextB8");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores7thB");
                                Names = GameObject.Find("nameTextB8");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name7thB");
                                PlayerPrefs.SetString("Scores8thB", scoreNext.text);
                                PlayerPrefs.SetString("Name8thB", nameNext.text);

                                Scores = GameObject.Find("scoreTextB7");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores6thB");
                                Names = GameObject.Find("nameTextB7");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name6thB");
                                PlayerPrefs.SetString("Scores7thB", scoreNext.text);
                                PlayerPrefs.SetString("Name7thB", nameNext.text);

                                Pos = GameObject.Find("posTextB6");
                                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                pos.fontStyle = FontStyles.Bold;
                                pos.color = new Color32(246, 255, 0, 255);
                                Scores = GameObject.Find("scoreTextB6");
                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                score.fontStyle = FontStyles.Bold;
                                score.color = new Color32(246, 255, 0, 255);
                                Names = GameObject.Find("nameTextB6");
                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                name.fontStyle = FontStyles.Bold;
                                name.color = new Color32(246, 255, 0, 255);
                                score.text = _LeaderboardMain.urScore.text;
                                name.text = nameInput.text;
                                PlayerPrefs.SetString("Scores6thB", score.text);
                                PlayerPrefs.SetString("Name6thB", name.text);

                                Scores = GameObject.Find("scoreTextB5");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores5thB");
                                Names = GameObject.Find("nameTextB5");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name5thB");
                                PlayerPrefs.SetString("Scores5thB", scoreNext.text);
                                PlayerPrefs.SetString("Name5thB", nameNext.text);

                                Scores = GameObject.Find("scoreTextB4");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores4thB");
                                Names = GameObject.Find("nameTextB4");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name4thB");
                                PlayerPrefs.SetString("Scores4thB", scoreNext.text);
                                PlayerPrefs.SetString("Name4thB", nameNext.text);

                                Scores = GameObject.Find("scoreTextB3");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores3rdB");
                                Names = GameObject.Find("nameTextB3");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name3rdB");
                                PlayerPrefs.SetString("Scores3rdB", scoreNext.text);
                                PlayerPrefs.SetString("Name3rdB", nameNext.text);

                                Scores = GameObject.Find("scoreTextB2");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores2ndB");
                                Names = GameObject.Find("nameTextB2");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name2ndB");
                                PlayerPrefs.SetString("Scores2ndB", scoreNext.text);
                                PlayerPrefs.SetString("Name2ndB", nameNext.text);

                                Scores = GameObject.Find("scoreTextB1");
                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                scoreNext.text = PlayerPrefs.GetString("Scores1stB");
                                Names = GameObject.Find("nameTextB1");
                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                nameNext.text = PlayerPrefs.GetString("Name1stB");
                                PlayerPrefs.SetString("Scores1stB", scoreNext.text);
                                PlayerPrefs.SetString("Name1stB", nameNext.text);
                            }
                            else if (Globals.overallScore < scoreComparison)
                            {
                                Scores = GameObject.Find("scoreTextB7");
                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                score.text = PlayerPrefs.GetString("Scores7thB");
                                scoreComparison = Convert.ToInt32(score.text);
                                Names = GameObject.Find("nameTextB7");
                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                name.text = PlayerPrefs.GetString("Name7thB");

                                //checking if #7
                                if (Globals.overallScore > scoreComparison)
                                {
                                    //pushing scores lower
                                    Scores = GameObject.Find("scoreTextB11");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores10thB");
                                    Names = GameObject.Find("nameTextB11");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name10thB");
                                    PlayerPrefs.SetString("Scores11thB", scoreNext.text);
                                    PlayerPrefs.SetString("Name11thB", nameNext.text);

                                    Scores = GameObject.Find("scoreTextB10");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores9thB");
                                    Names = GameObject.Find("nameTextB10");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name9thB");
                                    PlayerPrefs.SetString("Scores10thB", scoreNext.text);
                                    PlayerPrefs.SetString("Name10thB", nameNext.text);

                                    Scores = GameObject.Find("scoreTextB9");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores8thB");
                                    Names = GameObject.Find("nameTextB9");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name8thB");
                                    PlayerPrefs.SetString("Scores9thB", scoreNext.text);
                                    PlayerPrefs.SetString("Name9thB", nameNext.text);

                                    Scores = GameObject.Find("scoreTextB8");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores7thB");
                                    Names = GameObject.Find("nameTextB8");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name7thB");
                                    PlayerPrefs.SetString("Scores8thB", scoreNext.text);
                                    PlayerPrefs.SetString("Name8thB", nameNext.text);

                                    Pos = GameObject.Find("posTextB7");
                                    pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                    pos.fontStyle = FontStyles.Bold;
                                    pos.color = new Color32(246, 255, 0, 255);
                                    Scores = GameObject.Find("scoreTextB7");
                                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    score.fontStyle = FontStyles.Bold;
                                    score.color = new Color32(246, 255, 0, 255);
                                    Names = GameObject.Find("nameTextB7");
                                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    name.fontStyle = FontStyles.Bold;
                                    name.color = new Color32(246, 255, 0, 255);
                                    score.text = _LeaderboardMain.urScore.text;
                                    name.text = nameInput.text;
                                    PlayerPrefs.SetString("Scores7thB", score.text);
                                    PlayerPrefs.SetString("Name7thB", name.text);

                                    Scores = GameObject.Find("scoreTextB6");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores6thB");
                                    Names = GameObject.Find("nameTextB6");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name6thB");
                                    PlayerPrefs.SetString("Scores6thB", scoreNext.text);
                                    PlayerPrefs.SetString("Name6thB", nameNext.text);

                                    Scores = GameObject.Find("scoreTextB5");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores5thB");
                                    Names = GameObject.Find("nameTextB5");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name5thB");
                                    PlayerPrefs.SetString("Scores5thB", scoreNext.text);
                                    PlayerPrefs.SetString("Name5thB", nameNext.text);

                                    Scores = GameObject.Find("scoreTextB4");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores4thB");
                                    Names = GameObject.Find("nameTextB4");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name4thB");
                                    PlayerPrefs.SetString("Scores4thB", scoreNext.text);
                                    PlayerPrefs.SetString("Name4thB", nameNext.text);

                                    Scores = GameObject.Find("scoreTextB3");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores3rdB");
                                    Names = GameObject.Find("nameTextB3");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name3rdB");
                                    PlayerPrefs.SetString("Scores3rdB", scoreNext.text);
                                    PlayerPrefs.SetString("Name3rdB", nameNext.text);

                                    Scores = GameObject.Find("scoreTextB2");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores2ndB");
                                    Names = GameObject.Find("nameTextB2");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name2ndB");
                                    PlayerPrefs.SetString("Scores2ndB", scoreNext.text);
                                    PlayerPrefs.SetString("Name2ndB", nameNext.text);

                                    Scores = GameObject.Find("scoreTextB1");
                                    scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    scoreNext.text = PlayerPrefs.GetString("Scores1stB");
                                    Names = GameObject.Find("nameTextB1");
                                    nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    nameNext.text = PlayerPrefs.GetString("Name1stB");
                                    PlayerPrefs.SetString("Scores1stB", scoreNext.text);
                                    PlayerPrefs.SetString("Name1stB", nameNext.text);
                                }
                                else if (Globals.overallScore < scoreComparison)
                                {
                                    Scores = GameObject.Find("scoreTextB8");
                                    score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                    score.text = PlayerPrefs.GetString("Scores8thB");
                                    scoreComparison = Convert.ToInt32(score.text);
                                    Names = GameObject.Find("nameTextB8");
                                    name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                    name.text = PlayerPrefs.GetString("Name8thB");

                                    //checking if #8
                                    if (Globals.overallScore > scoreComparison)
                                    {
                                        //pushing scores lower
                                        Scores = GameObject.Find("scoreTextB11");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores10thB");
                                        Names = GameObject.Find("nameTextB11");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name10thB");
                                        PlayerPrefs.SetString("Scores11thB", scoreNext.text);
                                        PlayerPrefs.SetString("Name11thB", nameNext.text);

                                        Scores = GameObject.Find("scoreTextB10");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores9thB");
                                        Names = GameObject.Find("nameTextB10");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name9thB");
                                        PlayerPrefs.SetString("Scores10thB", scoreNext.text);
                                        PlayerPrefs.SetString("Name10thB", nameNext.text);

                                        Scores = GameObject.Find("scoreTextB9");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores8thB");
                                        Names = GameObject.Find("nameTextB9");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name8thB");
                                        PlayerPrefs.SetString("Scores9thB", scoreNext.text);
                                        PlayerPrefs.SetString("Name9thB", nameNext.text);

                                        Pos = GameObject.Find("posTextB8");
                                        pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                        pos.fontStyle = FontStyles.Bold;
                                        pos.color = new Color32(246, 255, 0, 255);
                                        Scores = GameObject.Find("scoreTextB8");
                                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        score.fontStyle = FontStyles.Bold;
                                        score.color = new Color32(246, 255, 0, 255);
                                        Names = GameObject.Find("nameTextB8");
                                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        name.fontStyle = FontStyles.Bold;
                                        name.color = new Color32(246, 255, 0, 255);
                                        score.text = _LeaderboardMain.urScore.text;
                                        name.text = nameInput.text;
                                        PlayerPrefs.SetString("Scores8thB", score.text);
                                        PlayerPrefs.SetString("Name8thB", name.text);

                                        Scores = GameObject.Find("scoreTextB7");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores7thB");
                                        Names = GameObject.Find("nameTextB7");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name7thB");
                                        PlayerPrefs.SetString("Scores7thB", scoreNext.text);
                                        PlayerPrefs.SetString("Name7thB", nameNext.text);

                                        Scores = GameObject.Find("scoreTextB6");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores6thB");
                                        Names = GameObject.Find("nameTextB6");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name6thB");
                                        PlayerPrefs.SetString("Scores6thB", scoreNext.text);
                                        PlayerPrefs.SetString("Name6thB", nameNext.text);

                                        Scores = GameObject.Find("scoreTextB5");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores5thB");
                                        Names = GameObject.Find("nameTextB5");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name5thB");
                                        PlayerPrefs.SetString("Scores5thB", scoreNext.text);
                                        PlayerPrefs.SetString("Name5thB", nameNext.text);

                                        Scores = GameObject.Find("scoreTextB4");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores4thB");
                                        Names = GameObject.Find("nameTextB4");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name4thB");
                                        PlayerPrefs.SetString("Scores4thB", scoreNext.text);
                                        PlayerPrefs.SetString("Name4thB", nameNext.text);

                                        Scores = GameObject.Find("scoreTextB3");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores3rdB");
                                        Names = GameObject.Find("nameTextB3");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name3rdB");
                                        PlayerPrefs.SetString("Scores3rdB", scoreNext.text);
                                        PlayerPrefs.SetString("Name3rdB", nameNext.text);

                                        Scores = GameObject.Find("scoreTextB2");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores2ndB");
                                        Names = GameObject.Find("nameTextB2");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name2ndB");
                                        PlayerPrefs.SetString("Scores2ndB", scoreNext.text);
                                        PlayerPrefs.SetString("Name2ndB", nameNext.text);

                                        Scores = GameObject.Find("scoreTextB1");
                                        scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        scoreNext.text = PlayerPrefs.GetString("Scores1stB");
                                        Names = GameObject.Find("nameTextB1");
                                        nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        nameNext.text = PlayerPrefs.GetString("Name1stB");
                                        PlayerPrefs.SetString("Scores1stB", scoreNext.text);
                                        PlayerPrefs.SetString("Name1stB", nameNext.text);
                                    }
                                    else if (Globals.overallScore < scoreComparison)
                                    {
                                        Scores = GameObject.Find("scoreTextB9");
                                        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                        score.text = PlayerPrefs.GetString("Scores9thB");
                                        scoreComparison = Convert.ToInt32(score.text);
                                        Names = GameObject.Find("nameTextB9");
                                        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                        name.text = PlayerPrefs.GetString("Name9thB");

                                        //checking if #9
                                        if (Globals.overallScore > scoreComparison)
                                        {
                                            //pushing scores lower
                                            Scores = GameObject.Find("scoreTextB11");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores10thB");
                                            Names = GameObject.Find("nameTextB11");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name10thB");
                                            PlayerPrefs.SetString("Scores11thB", scoreNext.text);
                                            PlayerPrefs.SetString("Name11thB", nameNext.text);

                                            Scores = GameObject.Find("scoreTextB10");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores9thB");
                                            Names = GameObject.Find("nameTextB10");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name9thB");
                                            PlayerPrefs.SetString("Scores10thB", scoreNext.text);
                                            PlayerPrefs.SetString("Name10thB", nameNext.text);

                                            Pos = GameObject.Find("posTextB9");
                                            pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                            pos.fontStyle = FontStyles.Bold;
                                            pos.color = new Color32(246, 255, 0, 255);
                                            Scores = GameObject.Find("scoreTextB9");
                                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            score.fontStyle = FontStyles.Bold;
                                            score.color = new Color32(246, 255, 0, 255);
                                            Names = GameObject.Find("nameTextB9");
                                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            name.fontStyle = FontStyles.Bold;
                                            name.color = new Color32(246, 255, 0, 255);
                                            score.text = _LeaderboardMain.urScore.text;
                                            name.text = nameInput.text;
                                            PlayerPrefs.SetString("Scores9thB", score.text);
                                            PlayerPrefs.SetString("Name9thB", name.text);

                                            Scores = GameObject.Find("scoreTextB8");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores8thB");
                                            Names = GameObject.Find("nameTextB8");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name8thB");
                                            PlayerPrefs.SetString("Scores8thB", scoreNext.text);
                                            PlayerPrefs.SetString("Name8thB", nameNext.text);

                                            Scores = GameObject.Find("scoreTextB7");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores7thB");
                                            Names = GameObject.Find("nameTextB7");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name7thB");
                                            PlayerPrefs.SetString("Scores7thB", scoreNext.text);
                                            PlayerPrefs.SetString("Name7thB", nameNext.text);

                                            Scores = GameObject.Find("scoreTextB6");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores6thB");
                                            Names = GameObject.Find("nameTextB6");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name6thB");
                                            PlayerPrefs.SetString("Scores6thB", scoreNext.text);
                                            PlayerPrefs.SetString("Name6thB", nameNext.text);

                                            Scores = GameObject.Find("scoreTextB5");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores5thB");
                                            Names = GameObject.Find("nameTextB5");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name5thB");
                                            PlayerPrefs.SetString("Scores5thB", scoreNext.text);
                                            PlayerPrefs.SetString("Name5thB", nameNext.text);

                                            Scores = GameObject.Find("scoreTextB4");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores4thB");
                                            Names = GameObject.Find("nameTextB4");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name4thB");
                                            PlayerPrefs.SetString("Scores4thB", scoreNext.text);
                                            PlayerPrefs.SetString("Name4th", nameNext.text);

                                            Scores = GameObject.Find("scoreTextB3");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores3rdB");
                                            Names = GameObject.Find("nameTextB3");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name3rdB");
                                            PlayerPrefs.SetString("Scores3rdB", scoreNext.text);
                                            PlayerPrefs.SetString("Name3rdB", nameNext.text);

                                            Scores = GameObject.Find("scoreTextB2");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores2ndB");
                                            Names = GameObject.Find("nameTextB2");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name2ndB");
                                            PlayerPrefs.SetString("Scores2ndB", scoreNext.text);
                                            PlayerPrefs.SetString("Name2ndB", nameNext.text);

                                            Scores = GameObject.Find("scoreTextB1");
                                            scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            scoreNext.text = PlayerPrefs.GetString("Scores1stB");
                                            Names = GameObject.Find("nameTextB1");
                                            nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            nameNext.text = PlayerPrefs.GetString("Name1stB");
                                            PlayerPrefs.SetString("Scores1stB", scoreNext.text);
                                            PlayerPrefs.SetString("Name1stB", nameNext.text);
                                        }
                                        else if (Globals.overallScore < scoreComparison)
                                        {
                                            Scores = GameObject.Find("scoreTextB10");
                                            score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                            score.text = PlayerPrefs.GetString("Scores10thB");
                                            scoreComparison = Convert.ToInt32(score.text);
                                            Names = GameObject.Find("nameTextB10");
                                            name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                            name.text = PlayerPrefs.GetString("Name10thB");

                                            //checking if #10
                                            if (Globals.overallScore > scoreComparison)
                                            {
                                                //pushing scores lower
                                                Scores = GameObject.Find("scoreTextB11");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores10thB");
                                                Names = GameObject.Find("nameTextB11");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name10thB");
                                                PlayerPrefs.SetString("Scores11thB", scoreNext.text);
                                                PlayerPrefs.SetString("Name11thB", nameNext.text);

                                                Pos = GameObject.Find("posTextB10");
                                                pos = Pos.GetComponent<TMPro.TextMeshProUGUI>();
                                                pos.fontStyle = FontStyles.Bold;
                                                pos.color = new Color32(246, 255, 0, 255);
                                                Scores = GameObject.Find("scoreTextB10");
                                                score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                score.fontStyle = FontStyles.Bold;
                                                score.color = new Color32(246, 255, 0, 255);
                                                Names = GameObject.Find("nameTextB10");
                                                name = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                name.fontStyle = FontStyles.Bold;
                                                name.color = new Color32(246, 255, 0, 255);
                                                score.text = _LeaderboardMain.urScore.text;
                                                name.text = nameInput.text;
                                                PlayerPrefs.SetString("Scores10thB", score.text);
                                                PlayerPrefs.SetString("Name10thB", name.text);

                                                Scores = GameObject.Find("scoreTextB9");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores9thB");
                                                Names = GameObject.Find("nameTextB9");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name9thB");
                                                PlayerPrefs.SetString("Scores9thB", scoreNext.text);
                                                PlayerPrefs.SetString("Name9thB", nameNext.text);

                                                Scores = GameObject.Find("scoreTextB8");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores8thB");
                                                Names = GameObject.Find("nameTextB8");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name8thB");
                                                PlayerPrefs.SetString("Scores8thB", scoreNext.text);
                                                PlayerPrefs.SetString("Name8thB", nameNext.text);

                                                Scores = GameObject.Find("scoreTextB7");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores7thB");
                                                Names = GameObject.Find("nameTextB7");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name7thB");
                                                PlayerPrefs.SetString("Scores7thB", scoreNext.text);
                                                PlayerPrefs.SetString("Name7thB", nameNext.text);

                                                Scores = GameObject.Find("scoreTextB6");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores6thB");
                                                Names = GameObject.Find("nameTextB6");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name6thB");
                                                PlayerPrefs.SetString("Scores6thB", scoreNext.text);
                                                PlayerPrefs.SetString("Name6thB", nameNext.text);

                                                Scores = GameObject.Find("scoreTextB5");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores5thB");
                                                Names = GameObject.Find("nameTextB5");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name5thB");
                                                PlayerPrefs.SetString("Scores5thB", scoreNext.text);
                                                PlayerPrefs.SetString("Name5thB", nameNext.text);

                                                Scores = GameObject.Find("scoreTextB4");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores4thB");
                                                Names = GameObject.Find("nameTextB4");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name4thB");
                                                PlayerPrefs.SetString("Scores4thB", scoreNext.text);
                                                PlayerPrefs.SetString("Name4thB", nameNext.text);

                                                Scores = GameObject.Find("scoreTextB3");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores3rdB");
                                                Names = GameObject.Find("nameTextB3");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name3rdB");
                                                PlayerPrefs.SetString("Scores3rdB", scoreNext.text);
                                                PlayerPrefs.SetString("Name3rdB", nameNext.text);

                                                Scores = GameObject.Find("scoreTextB2");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores2ndB");
                                                Names = GameObject.Find("nameTextB2");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name2ndB");
                                                PlayerPrefs.SetString("Scores2ndB", scoreNext.text);
                                                PlayerPrefs.SetString("Name2ndB", nameNext.text);

                                                Scores = GameObject.Find("scoreTextB1");
                                                scoreNext = Scores.GetComponent<TMPro.TextMeshProUGUI>();
                                                scoreNext.text = PlayerPrefs.GetString("Scores1stB");
                                                Names = GameObject.Find("nameTextB1");
                                                nameNext = Names.GetComponent<TMPro.TextMeshProUGUI>();
                                                nameNext.text = PlayerPrefs.GetString("Name1stB");
                                                PlayerPrefs.SetString("Scores1stB", scoreNext.text);
                                                PlayerPrefs.SetString("Name1stB", nameNext.text);
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

    public void BethViewing()
    {
        Scores = GameObject.Find("scoreTextB1");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores1stB");
        Names = GameObject.Find("nameTextB1");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name1stB");

        Scores = GameObject.Find("scoreTextB2");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores2ndB");
        Names = GameObject.Find("nameTextB2");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name2ndB");

        Scores = GameObject.Find("scoreTextB3");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores3rdB");
        Names = GameObject.Find("nameTextB3");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name3rdB");

        Scores = GameObject.Find("scoreTextB4");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores4thB");
        Names = GameObject.Find("nameTextB4");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name4thB");

        Scores = GameObject.Find("scoreTextB5");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores5thB");
        Names = GameObject.Find("nameTextB5");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name5thB");

        Scores = GameObject.Find("scoreTextB6");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores6thB");
        Names = GameObject.Find("nameTextB6");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name6thB");

        Scores = GameObject.Find("scoreTextB7");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores7thB");
        Names = GameObject.Find("nameTextB7");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name7thB");

        Scores = GameObject.Find("scoreTextB8");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores8thB");
        Names = GameObject.Find("nameTextB8");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name8thB");

        Scores = GameObject.Find("scoreTextB9");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores9thB");
        Names = GameObject.Find("nameTextB9");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name9thB");

        Scores = GameObject.Find("scoreTextB10");
        score = Scores.GetComponent<TMPro.TextMeshProUGUI>();
        score.text = PlayerPrefs.GetString("Scores10thB");
        Names = GameObject.Find("nameTextB10");
        name = Names.GetComponent<TMPro.TextMeshProUGUI>();
        name.text = PlayerPrefs.GetString("Name10thB");
    }
}
