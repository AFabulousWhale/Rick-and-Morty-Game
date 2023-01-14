﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange2 : MonoBehaviour
{
    public float lookRadius = 100f;
    public float Shipdistance;

    public GameObject Ship, Player, Scenery2, Scenery3, Enemy, Cube;
    public Transform shippos, playerpos;
    public bool shiprechedWaypoint;
    public bool Teleported;

    public WinLose _WinLose;
    public RandomSounds _RandomSounds;
    public PlayerTeleporting _PlayerTeleporting;
    public SceneChange1 _SceneChange1;
    public EnemySummoning _EnemySummoning;
    public HPSpawn _HPSpawn;
    public AppearDisappear _AorD;

    public Vector3 shipPos;

    public Timer _Timer;

    public Material skyThree;

    public bool soundPlayed;

    public WalkRInjured _WalkRInjured;
    public WalkMInjured _WalkMInjured;
    void Start()
    {
        soundPlayed = false;
        shiprechedWaypoint = false;
        Teleported = false;
        Ship.GetComponent<MeshRenderer>().enabled = true;
        foreach (Transform child in Scenery3.GetComponentsInChildren<Transform>(true))
        {
            child.gameObject.layer = 14;
        }
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        Shipdistance = Vector3.Distance(Ship.transform.position, transform.position);
        Enemy = GameObject.Find("__Enemy(Clone)");

        if (Shipdistance <= lookRadius && _RandomSounds.soundDone)
        {
            if (!soundPlayed)
            {
                _RandomSounds.Other = 1;
                soundPlayed = true;
            }
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
    public void OnTriggerEnter(Collider collision)
    {

        if (shiprechedWaypoint)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (Globals.Character == "Rick And Morty")
                {
                    if (_WalkRInjured.RDead)
                    {
                        Destroy(GameObject.Find("Rick"));
                    }
                    if (_WalkMInjured.MDead)
                    {
                        Destroy(GameObject.Find("Morty"));
                    }
                }
                _RandomSounds.Checkpoint();
                _RandomSounds.Other = 1;
                _SceneChange1.Scene = 3;
                Teleported = true;
                foreach (Transform child in Scenery2.GetComponentsInChildren<Transform>(true))
                {
                    child.gameObject.layer = 14;
                }
                foreach (Transform child in Scenery3.GetComponentsInChildren<Transform>(true))
                {
                    child.gameObject.layer = 0;
                }
                Ship.GetComponent<MeshRenderer>().enabled = true;
                RenderSettings.skybox = skyThree;
                var HPacks = GameObject.FindGameObjectsWithTag("Health Pack");
                foreach (var clone in HPacks)
                {
                    _HPSpawn.HPackSummoned--;
                    Destroy(clone);
                }
                Cube.SetActive(false);
                var EnemiesS = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (var cloneE in EnemiesS)
                {
                    Destroy(cloneE);
                }
                var EnemiesT = GameObject.FindGameObjectsWithTag("EnemyTwo");
                foreach (var cloneE in EnemiesT)
                {
                    Destroy(cloneE);
                }
                Cube.SetActive(true);
                var EnemiesB = GameObject.FindGameObjectsWithTag("EBullet");
                foreach (var cloneEB in EnemiesB)
                {
                    Destroy(cloneEB);
                }
                _RandomSounds.Other = 2;
                if (!Globals.isGameFinished)
                {
                    _AorD.actualScore = UnityEngine.Random.Range(90, 100);
                    _AorD.displayScore.text = _AorD.actualScore.ToString();
                    Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                    _AorD.ScoreA();
                }
                _PlayerTeleporting.TP2();
            }
        }
        if (collision.gameObject.tag == "Ship")
        {
            shipPos = new Vector3(shippos.position.x, Ship.transform.position.y, shippos.position.z);
            _RandomSounds.Other = 1;
            _Timer.TimerS = _Timer.TimerS + 40;
            _WinLose.isOvertime = false;
            Ship.transform.position = shipPos;
            shiprechedWaypoint = true;
            Ship.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
