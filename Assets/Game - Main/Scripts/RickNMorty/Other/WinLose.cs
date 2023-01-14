using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinLose : MonoBehaviour
{

    public GameObject Victory, Defeat, Overtime, Times, player;

    public Timer _Timer;
    public ShipMovement _ShipMovement;
    public RandomSounds _RandomSounds;
    public SceneChange1 _SceneChange1;
    public ChangingCharacter _ChangingCharacter;

    public GameEnd _GameEnd;

    public AudioSource Boo;

    public bool endGame;
    public bool soundPlayed;

    public bool isOvertime;
    public bool isNearShip;
    public bool fiveTimer;

    void Start()
    {
        fiveTimer = false;
        isNearShip = false;
        isOvertime = false;
        soundPlayed = false;
        Victory.SetActive(false);
        Defeat.SetActive(false);
        Overtime.SetActive(false);
        Times.SetActive(true);
    }


    void Update()
    { //lose game
        if (_Timer.TimerS <= 0 && !isOvertime)
        {
            if (_ShipMovement.Playerdistance >= _ShipMovement.lookRadius)
            {
                if (!Globals.isGameFinished)
                {
                    Globals.isGameFinished = true;
                    Time.timeScale = 0.5f;
                    endGame = true;
                    if (!soundPlayed)
                    {
                        _RandomSounds.Other = 8;
                        soundPlayed = true;
                    }
                    StartCoroutine(GameOver());

                    IEnumerator GameOver()
                    {
                        Defeat.SetActive(true);
                        yield return new WaitForSeconds(3);
                        Time.timeScale = 1;
                        Cursor.visible = true;
                        Cursor.lockState = CursorLockMode.None;
                        var HPacks = GameObject.FindGameObjectsWithTag("Health Pack");
                        foreach (var clone in HPacks)
                        {
                            Destroy(clone);
                        }
                        var EnemiesS = GameObject.FindGameObjectsWithTag("Enemy");
                        foreach (var cloneE in EnemiesS)
                        {
                            Destroy(cloneE);
                        }
                        var EnemiesB = GameObject.FindGameObjectsWithTag("EBullet");
                        foreach (var cloneEB in EnemiesB)
                        {
                            Destroy(cloneEB);
                        }
                        SceneManager.LoadScene("Game Over");

                    }
                }
            }
            else if (_ShipMovement.Playerdistance <= _ShipMovement.lookRadius)
            {
                isOvertime = true;
            }
        }

        //win game
        if (_GameEnd.triggerGameEnd)
        {
            if (!Globals.isGameFinished)
            {
                Globals.isGameFinished = true;
                Time.timeScale = 0.5f;
                endGame = true;
                StartCoroutine(BackToMenu());
                IEnumerator BackToMenu()
                {
                    Victory.SetActive(true);
                    yield return new WaitForSeconds(3);
                    Time.timeScale = 1;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    var HPacks = GameObject.FindGameObjectsWithTag("Health Pack");
                    foreach (var clone in HPacks)
                    {
                        Destroy(clone);
                    }
                    var EnemiesS = GameObject.FindGameObjectsWithTag("Enemy");
                    foreach (var cloneE in EnemiesS)
                    {
                        Destroy(cloneE);
                    }
                    var EnemiesB = GameObject.FindGameObjectsWithTag("EBullet");
                    foreach (var cloneEB in EnemiesB)
                    {
                        Destroy(cloneEB);
                    }
                    if (Globals.Character == "Rick And Morty")
                    {
                        if (_ChangingCharacter.charSelect == 1)
                        {
                            Globals.RickorMorty = 1;
                        }
                    }
                    SceneManager.LoadScene("Leaderboard");
                }
            }
        }

        if (isOvertime && !endGame)
        {
            if (_ShipMovement.Playerdistance >= _ShipMovement.lookRadius)
            {
                isNearShip = false;
            }
            else if (_ShipMovement.Playerdistance <= _ShipMovement.lookRadius)
            {
                isNearShip = true;
            }

            if (isNearShip)
            {
                _Timer.countdownOnce = 0;
                fiveTimer = false;
                _Timer.TimerS = 0;
                Overtime.SetActive(true);
                _Timer.TimeTMP.color = new Color32(246, 255, 0, 0);
            }
            else if (!isNearShip)
            {
                if (_Timer.countdownOnce <= 0)
                {
                    Overtime.SetActive(false);
                    _Timer.TimeTMP.color = new Color32(246, 255, 0, 255);
                    _Timer.countdownOnce = 1;
                    _Timer.TimerS = 6;
                    fiveTimer = true;
                }

                if(_Timer.TimerS <= 0)
                {
                    isOvertime = false;
                }
            }
        }else if (!isOvertime)
        {
            Overtime.SetActive(false);
            _Timer.TimeTMP.color = new Color32(255, 255, 255, 255);
        }
    }

}
