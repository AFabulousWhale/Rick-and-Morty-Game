using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HPSpawn : MonoBehaviour
{
    public GameObject HPack, newHPack;
    public int xPos;
    public int zPos;
    public int HPackSummoned;

    public bool summonedHPack = true;

    public SceneChange1 _SceneChange1;
    public SceneChange2 _SceneChange2;

    public bool canSpawnHere = false;
    public Collider[] HPcollider;

    public float Timer = 3;
    void Start()
    {
        HPack.SetActive(false);
    }

    void Update()
    {

        if (_SceneChange1.Teleported)
        {
            HPackSummoned = 0;
            _SceneChange1.Teleported = false;
        }
        if (_SceneChange2.Teleported)
        {
            HPackSummoned = 0;
            _SceneChange2.Teleported = false;
        }
        Timer -= Time.deltaTime;

        if (_SceneChange1.Scene == 1 && HPackSummoned < 3)
        {
            HpackSpawning1();
        }

        if (_SceneChange1.Scene == 2 && HPackSummoned < 5)
        {
            HpackSpawning2();
        }

        if (_SceneChange1.Scene == 3 && HPackSummoned < 7)
        {
            HpackSpawning3();
        }

        
    }

    public void HpackSpawning1()
    {
        if (!canSpawnHere)
        {
            xPos = UnityEngine.Random.Range(1381, -69);
            zPos = UnityEngine.Random.Range(-405, 1077);
            Vector3 spawnPos = new Vector3(xPos, HPack.transform.position.y, zPos);
            if (summonedHPack && Timer <= 0)
            {
                summonedHPack = false;
                HPackSummoned++;
                newHPack = Instantiate(HPack, spawnPos, Quaternion.identity) as GameObject;
                HPcollider = Physics.OverlapSphere(newHPack.transform.position, 35f);
                summonedHPack = true;
                if (HPcollider.Length == 0)
                {
                    canSpawnHere = true;
                    newHPack.SetActive(true);
                    Timer = 3;
                    canSpawnHere = false;
                    Array.Clear(HPcollider, 0, HPcollider.Length);
                    
                }
                else
                {
                    Destroy(newHPack);
                    HPackSummoned--;
                }
            }
        }
    }

    public void HpackSpawning2()
    {
        if (!canSpawnHere)
        {
            xPos = UnityEngine.Random.Range(1201, 175);
            zPos = UnityEngine.Random.Range(-915, -1955);
            Vector3 spawnPos = new Vector3(xPos, HPack.transform.position.y, zPos);
            if (summonedHPack && Timer <= 0)
            {
                summonedHPack = false;
                HPackSummoned++;
                newHPack = Instantiate(HPack, spawnPos, Quaternion.identity) as GameObject;
                HPcollider = Physics.OverlapSphere(newHPack.transform.position, 35f);
                summonedHPack = true;
                if (HPcollider.Length == 0)
                {
                    canSpawnHere = true;
                    newHPack.SetActive(true);
                    Timer = 3;
                    canSpawnHere = false;
                    Array.Clear(HPcollider, 0, HPcollider.Length);

                }
                else
                {
                    Destroy(newHPack);
                    HPackSummoned--;
                }
            }
        }
    }

    public void HpackSpawning3()
    {
        if (!canSpawnHere)
        {
            xPos = UnityEngine.Random.Range(1687, 3652);
            zPos = UnityEngine.Random.Range(-874, 725);
            Vector3 spawnPos = new Vector3(xPos, HPack.transform.position.y, zPos);
            if (summonedHPack && Timer <= 0)
            {
                summonedHPack = false;
                HPackSummoned++;
                newHPack = Instantiate(HPack, spawnPos, Quaternion.identity) as GameObject;
                HPcollider = Physics.OverlapSphere(newHPack.transform.position, 35f);
                summonedHPack = true;
                if (HPcollider.Length == 0)
                {
                    canSpawnHere = true;
                    newHPack.SetActive(true);
                    Timer = 3;
                    canSpawnHere = false;
                    Array.Clear(HPcollider, 0, HPcollider.Length);

                }
                else
                {
                    Destroy(newHPack);
                    HPackSummoned--;
                }
            }
        }
    }
}