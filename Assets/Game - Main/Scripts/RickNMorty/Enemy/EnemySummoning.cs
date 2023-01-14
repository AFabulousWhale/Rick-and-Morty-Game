using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EnemySummoning : MonoBehaviour
{
    public GameObject enemy, newEnemy;
    public int xPos;
    public int zPos;
    public int enemiesSummoned;

    public bool summonedEnemy;

    public SceneChange1 _SceneChange1;
    public SceneChange2 _SceneChange2;
    public enemyhit _enemyhit;
    public enemyShooting _enemyShooting;
    public ShipMovement _ShipMovement;
    public AbilitiesMainJ _AbilitiesMainJ;
    public enemyController1 _enemyController1;
    public Slider eSlider;

    public float Timer = 1;

    public bool canSpawnHere = false;

    public Collider[] enemycollider; 

    void Start()
    {
        InvokeRepeating("enemySpawning1", 2f, 3f);
        InvokeRepeating("enemySpawning2", 2f, 3f);
        InvokeRepeating("enemySpawning3", 2f, 3f);
        summonedEnemy = true;
        enemy.SetActive(false);

        if (Globals.Character == "Rick And Morty")
        {
            if (Globals.Difficulty == "Easy")
            {
                _enemyhit.enemyHealth = 200;
                _enemyShooting.damage = 3;
                eSlider.maxValue = 200;
            }
            else if (Globals.Difficulty == "Medium")
            {
                _enemyhit.enemyHealth = 300;
                _enemyShooting.damage = 7;
                eSlider.maxValue = 300;
            }
            else if (Globals.Difficulty == "Hard")
            {
                _enemyhit.enemyHealth = 500;
                _enemyShooting.damage = 9;
                eSlider.maxValue = 500;
            }
        }
        else if (Globals.Character == "Summer")
        {
            if (Globals.Difficulty == "Easy")
            {
                _enemyhit.enemyHealth = 150;
                _enemyShooting.damage = 3;
                eSlider.maxValue = 150;
            }
            else if (Globals.Difficulty == "Medium")
            {
                _enemyhit.enemyHealth = 200;
                _enemyShooting.damage = 5;
                eSlider.maxValue = 200;
            }
            else if (Globals.Difficulty == "Hard")
            {
                _enemyhit.enemyHealth = 300;
                _enemyShooting.damage = 7;
                eSlider.maxValue = 300;
            }
        }
        if (Globals.Character == "Jerry")
        {
            if (Globals.Difficulty == "Easy")
            {
                _enemyhit.enemyHealth = 300;
                _enemyShooting.damage = 7;
                eSlider.maxValue = 300;
            }
            else if (Globals.Difficulty == "Medium")
            {
                _enemyhit.enemyHealth = 400;
                _enemyShooting.damage = 9;
                eSlider.maxValue = 400;
            }
            else if (Globals.Difficulty == "Hard")
            {
                _enemyhit.enemyHealth = 600;
                _enemyShooting.damage = 10;
                eSlider.maxValue = 600;
            }
        }
        if (Globals.Character == "Beth")
        {
            if (Globals.Difficulty == "Easy")
            {
                _enemyhit.enemyHealth = 300;
                _enemyShooting.damage = 7;
                eSlider.maxValue = 300;
            }
            else if (Globals.Difficulty == "Medium")
            {
                _enemyhit.enemyHealth = 400;
                _enemyShooting.damage = 8;
                eSlider.maxValue = 400;
            }
            else if (Globals.Difficulty == "Hard")
            {
                _enemyhit.enemyHealth = 600;
                _enemyShooting.damage = 10;
                eSlider.maxValue = 600;
            }
        }
    }

    void Update()
    {
        if (_SceneChange1.Teleported)
        {
            enemiesSummoned = 0;
            _SceneChange1.Teleported = false;
        }
        if (_SceneChange2.Teleported)
        {
            enemiesSummoned = 0;
            _SceneChange2.Teleported = false;
        }
    }


    public void enemySpawning1()
    {
        if (_SceneChange1.Scene == 1 && _ShipMovement.Enemies.Length < 2)
        {
            if (!canSpawnHere)
            {
                xPos = UnityEngine.Random.Range(1381, -69);
                zPos = UnityEngine.Random.Range(-405, 1077);
                Vector3 spawnPos = new Vector3(xPos, enemy.transform.position.y, zPos);
                if (summonedEnemy)
                {
                    summonedEnemy = false;
                    enemiesSummoned++;
                    newEnemy = Instantiate(enemy, spawnPos, Quaternion.identity) as GameObject;
                    enemycollider = Physics.OverlapSphere(newEnemy.transform.position, 75f);
                    summonedEnemy = true;
                    if (enemycollider.Length == 0)
                    {
                        Timer = 1;
                        canSpawnHere = true;
                        newEnemy.SetActive(true);
                        canSpawnHere = false;
                        Array.Clear(enemycollider, 0, enemycollider.Length);
                        if (Globals.Character == "Jerry")
                        {
                            if (_AbilitiesMainJ.invis)
                            {
                                _enemyController1 = newEnemy.gameObject.GetComponent<enemyController1>();
                                _enemyController1.timeBtwShots = 10;
                                _enemyController1.Player = GameObject.Find("__Ship").transform;
                            }
                            else
                            {
                                _enemyController1 = newEnemy.gameObject.GetComponent<enemyController1>();
                                _enemyController1.Player = GameObject.Find("Characters").transform;
                                _enemyController1.timeBtwShots = _enemyController1.startTimeBtwShots;
                            }
                        }
                    }
                    else
                    {
                        enemiesSummoned--;
                        Destroy(newEnemy);
                        enemySpawning1();
                    }
                }
            }
        }
    }

    public void enemySpawning2()
    {
        if (_SceneChange1.Scene == 2 && _ShipMovement.Enemies.Length < 3)
        {
            if (!canSpawnHere)
            {
                xPos = UnityEngine.Random.Range(1201, 175);
                zPos = UnityEngine.Random.Range(-915, -1955);
                Vector3 spawnPos = new Vector3(xPos, enemy.transform.position.y, zPos);
                if (summonedEnemy)
                {
                    summonedEnemy = false;
                    enemiesSummoned++;
                    newEnemy = Instantiate(enemy, spawnPos, Quaternion.identity) as GameObject;
                    enemycollider = Physics.OverlapSphere(newEnemy.transform.position, 75f);
                    summonedEnemy = true;
                    if (enemycollider.Length == 0)
                    {
                        canSpawnHere = true;
                        newEnemy.SetActive(true);
                        Timer = 1;
                        canSpawnHere = false;
                        Array.Clear(enemycollider, 0, enemycollider.Length);
                        if (Globals.Character == "Jerry")
                        {
                            if (_AbilitiesMainJ.invis)
                            {
                                _enemyController1 = newEnemy.gameObject.GetComponent<enemyController1>();
                                _enemyController1.timeBtwShots = 10;
                                _enemyController1.Player = GameObject.Find("__Ship").transform;
                            }
                            else
                            {
                                _enemyController1 = newEnemy.gameObject.GetComponent<enemyController1>();
                                _enemyController1.Player = GameObject.Find("Characters").transform;
                            }
                        }
                    }
                    else
                    {
                        enemiesSummoned--;
                        Destroy(newEnemy);
                        enemySpawning2();
                    }
                }
            }
        }

    }

    public void enemySpawning3()
    {
        if (_SceneChange1.Scene == 3 && _ShipMovement.Enemies.Length < 4)
        {
            if (!canSpawnHere)
            {
                xPos = UnityEngine.Random.Range(1687, 3652);
                zPos = UnityEngine.Random.Range(-874, 725);
                Vector3 spawnPos = new Vector3(xPos, enemy.transform.position.y, zPos);
                if (summonedEnemy)
                {
                    summonedEnemy = false;
                    enemiesSummoned++;
                    newEnemy = Instantiate(enemy, spawnPos, Quaternion.identity) as GameObject;
                    enemycollider = Physics.OverlapSphere(newEnemy.transform.position, 75f);
                    summonedEnemy = true;
                    if (enemycollider.Length == 0)
                    {
                        canSpawnHere = true;
                        newEnemy.SetActive(true);
                        Timer = 1;
                        canSpawnHere = false;
                        Array.Clear(enemycollider, 0, enemycollider.Length);
                        if (Globals.Character == "Jerry")
                        {
                            if (_AbilitiesMainJ.invis)
                            {
                                _enemyController1 = newEnemy.gameObject.GetComponent<enemyController1>();
                                _enemyController1.timeBtwShots = 10;
                                _enemyController1.Player = GameObject.Find("__Ship").transform;
                            }
                            else
                            {
                                _enemyController1 = newEnemy.gameObject.GetComponent<enemyController1>();
                                _enemyController1.Player = GameObject.Find("Characters").transform;
                            }
                        }
                    }
                    else
                    {
                        enemiesSummoned--;
                        Destroy(newEnemy);
                        enemySpawning3();
                    }
                }
            }
        }
    }
}
