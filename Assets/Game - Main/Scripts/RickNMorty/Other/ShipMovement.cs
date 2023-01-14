using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float lookRadius = 100f;
    public bool enemyContact;
    Transform trans = null;

    public GameObject Post1, Post2, Post3;
    public GameObject[] Enemies;
    public Transform Waypoint1, Waypoint2, Waypoint3, Waypoint4, Waypoint5, closestEnemy;
    public int current = 0;
    float rotSpeed;
    public float speed;
    float WPRadius = 10;

    public Vector3 shipMovePos1, shipMovePos2, shipMovePos3, shipMovePos4, shipMovePos5;

    public Transform Player;
    public int wait = 2;

    public float Enemydistance;
    public float Playerdistance;

    public EnemySummoning _EnemySummoning;
    public SceneChange1 _SceneChange1;
    public WPRotate _WPRotate;
    public WPRotate2 _WPRotate2;

    Vector3 Waypoint3pos;

    void start()
    {
        closestEnemy = null;
        enemyContact = false;

        Post1.SetActive(true);
        Post2.SetActive(false);
        Post3.SetActive(false);
        Waypoint3pos = Waypoint3.transform.position;
    }

    public Transform getClosestEnemy()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float closestDistance = Mathf.Infinity;

        foreach (GameObject go in Enemies)
        {
            float currentDistance;
            currentDistance = Vector3.Distance(transform.position, go.transform.position);
            if(currentDistance < closestDistance)
            {
                closestDistance = currentDistance;
                trans = go.transform;
            }
        }
        return trans;
    }
    void Update()
    {
        closestEnemy = getClosestEnemy();

        Playerdistance = Vector3.Distance(Player.position, transform.position);
        Enemydistance = Vector3.Distance(trans.position, transform.position);

        if (!PauseMenu.GameIsPaused)
        {
            if (_SceneChange1.Scene == 1)
            {
                if ((Playerdistance <= lookRadius) && (Enemydistance >= lookRadius))
                {
                    StartCoroutine(Scene1Move());
                }
                else if (Enemydistance <= lookRadius)
                {
                    StopCoroutine(Scene1Move());
                }
            }
            else if (_SceneChange1.Scene == 2 && !_WPRotate2.Rotated)
            {
                Post1.SetActive(false);
                Post2.SetActive(true);
                Post3.SetActive(false);
                if ((Playerdistance <= lookRadius) && (Enemydistance >= lookRadius))
                {
                    StartCoroutine(Scene2Move1());
                }
                else if (Enemydistance <= lookRadius)
                {
                    StopCoroutine(Scene2Move1());
                }
            }
            else if (_SceneChange1.Scene == 2 && _WPRotate2.Rotated)
            {
                if ((Playerdistance <= lookRadius) && (Enemydistance >= lookRadius))
                {
                    StartCoroutine(Scene2Move2());
                }
                else if (Enemydistance <= lookRadius)
                {
                    StopCoroutine(Scene2Move2());
                }
            }
            else if (_SceneChange1.Scene == 3 && !_WPRotate.Rotated)
            {
                Post1.SetActive(false);
                Post2.SetActive(false);
                Post3.SetActive(true);
                if ((Playerdistance <= lookRadius) && (Enemydistance >= lookRadius))
                {
                    StartCoroutine(Scene3Move1());
                }
                else if (Enemydistance <= lookRadius)
                {
                    StopCoroutine(Scene3Move1());
                }
            }
            else if (_WPRotate.Rotated)
            {
                if ((Playerdistance <= lookRadius) && (Enemydistance >= lookRadius))
                {
                    StartCoroutine(Scene3Move2());
                }
                else if (Enemydistance <= lookRadius)
                {
                    StopCoroutine(Scene3Move2());
                }
            }
        }

    }


    IEnumerator Scene1Move()
    {
        shipMovePos1 = new Vector3(Waypoint1.position.x, transform.position.y, Waypoint1.position.z);
        yield return new WaitForSeconds(0.1f);
        transform.position = Vector3.MoveTowards(transform.position, shipMovePos1, speed * Time.deltaTime);
    }

    IEnumerator Scene2Move1()
    {
        shipMovePos2 = new Vector3(Waypoint2.position.x, transform.position.y, Waypoint2.position.z);
        yield return new WaitForSeconds(0.1f);
        transform.position = Vector3.MoveTowards(transform.position, shipMovePos2, speed * Time.deltaTime);
    }

    IEnumerator Scene2Move2()
    {
        shipMovePos3 = new Vector3(Waypoint3.position.x, transform.position.y, Waypoint3.position.z);
        yield return new WaitForSeconds(0.1f);
        transform.position = Vector3.MoveTowards(transform.position, shipMovePos3, speed * Time.deltaTime);
    }

    IEnumerator Scene3Move1()
    {
        shipMovePos4 = new Vector3(Waypoint4.position.x, transform.position.y, Waypoint4.position.z);
        yield return new WaitForSeconds(0.1f);
        transform.position = Vector3.MoveTowards(transform.position, shipMovePos4, speed * Time.deltaTime);
    }

    IEnumerator Scene3Move2()
    {
        shipMovePos5 = new Vector3(Waypoint5.transform.position.x, transform.position.y, Waypoint5.transform.position.z);
        yield return new WaitForSeconds(0.1f);
        transform.position = Vector3.MoveTowards(transform.position, shipMovePos5, speed * Time.deltaTime);
    }



    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
