using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange1 : MonoBehaviour
{
    public float lookRadius = 100f;
    public float Shipdistance;

    public GameObject Ship, Player, Scenery1, Scenery2, Enemy, Cube;
    public Transform shippos, playerpos;
    public bool shiprechedWaypoint;
    public bool Teleported;

    public WinLose _WinLose;
    public RandomSounds _RandomSounds;
    public PlayerTeleporting _PlayerTeleporting;
    public EnemySummoning _EnemySummoning;
    public HPSpawn _HPSpawn;
    public AppearDisappear _AorD;

    public Timer _Timer;

    public Vector3 shipPos;

    public int Scene;

    public Material skyOne;

    int distance = 5000;

    public bool soundPlayed;
    public bool StopOvertime;

    public WalkRInjured _WalkRInjured;
    public WalkMInjured _WalkMInjured;
    void Start()
    {
        StopOvertime = false;
        Cube.SetActive(true);
        soundPlayed = false;
        RenderSettings.skybox = skyOne;
        Scene = 1;
        foreach (Transform child in Scenery2.GetComponentsInChildren<Transform>(true))
        {
            child.gameObject.layer = 14;
        }
        shiprechedWaypoint = false;
        Teleported = false;
        Ship.GetComponent<MeshRenderer>().enabled = true;

        gameObject.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        Shipdistance = Vector3.Distance(Ship.transform.position, transform.position);
        Terrain.activeTerrain.detailObjectDistance = distance;
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
                Scene = 2;
                Teleported = true;
                foreach (Transform child in Scenery2.GetComponentsInChildren<Transform>(true))
                {
                    child.gameObject.layer = 0;
                }
                foreach (Transform child in Scenery1.GetComponentsInChildren<Transform>(true))
                {
                    child.gameObject.layer = 14;
                }
                Ship.GetComponent<MeshRenderer>().enabled = true;
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
                _PlayerTeleporting.TP1();
            }
        }
        if (collision.gameObject.tag == "Ship")
        {
            shipPos = new Vector3(shippos.position.x, Ship.transform.position.y, shippos.position.z);
            _RandomSounds.Other = 1;
            _Timer.TimerS = _Timer.TimerS + 30;
            _WinLose.isOvertime = false;
            Ship.transform.position = shipPos;
            Ship.transform.Rotate(0, 0, -180);
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
