using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AbilitiesMainJ : MonoBehaviour
{
    public bool invis, heal;

    public AbilitiesCooldownJ _AbilitiesCooldownJ;
    public SceneChange1 _SceneChange1;
    public SceneChange2 _SceneChange2;
    public AppearDisappear _AorD;
    public HealthJerry _HealthJerry;
    public RandomSounds _RandomSounds;
    public enemyController1 _enemyController1;
    public WalkingJ _WalkingJ;
    public WalkJInjured _WalkJInjured;

    public GameObject Apple, eatMain, gunMain, gun, invisHB;

    public Animator anim;

    public int healthChange;
    public int healedAmount;

    public Image apple, invisI;

    public bool Healing, HealStart, healcooldown;

    public float invisTimer = 10;

    public GameObject[] Enemies;
    Transform trans = null;
    public Transform closestEnemy;

    public HealthBar invisPower;
    public float invispercent;
    void Start()
    {
        healcooldown = true;
        HealStart = false;
        invispercent = 0;
        invisPower.SetMaxHealth(10);
        invisPower.SetHealth(10);
        invisHB.SetActive(false);
        _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
        _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
        _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);

        gunMain.GetComponent<Renderer>().enabled = true;
        gun.GetComponent<Renderer>().enabled = true;
        eatMain.GetComponent<Renderer>().enabled = false;
        Apple.GetComponent<Renderer>().enabled = false;
    }
    public Transform getClosestEnemy()
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float closestDistance = Mathf.Infinity;

        foreach (GameObject go in Enemies)
        {
            float currentDistance;
            currentDistance = Vector3.Distance(transform.position, go.transform.position);
            if (currentDistance < closestDistance)
            {
                closestDistance = currentDistance;
                trans = go.transform;
            }
        }
        return trans;
    }
    void Update()
    {
        if(Healing && !invis)
        {
            if (_SceneChange1.Scene == 1)
            {
                _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
                if (_HealthJerry.currentHealth != _HealthJerry.maxHealth)
                {
                    _AorD.vignetteLayer1.color.value = Color.green;
                    _AorD.vignetteLayer1.intensity.value = 0.5f;
                }
            }
            else if (_SceneChange1.Scene == 2)
            {
                _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
                if (_HealthJerry.currentHealth != _HealthJerry.maxHealth)
                {
                    _AorD.vignetteLayer2.color.value = Color.green;
                    _AorD.vignetteLayer2.intensity.value = 0.5f;
                }
            }
            else if (_SceneChange1.Scene == 3)
            {
                _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);
                if (_HealthJerry.currentHealth != _HealthJerry.maxHealth)
                {
                    _AorD.vignetteLayer3.color.value = Color.green;
                    _AorD.vignetteLayer3.intensity.value = 0.5f;
                }
            }
        }
        if(healedAmount == healthChange && !healcooldown || _HealthJerry.currentHealth == _HealthJerry.maxHealth && Healing)
        {
            healcooldown = true;
            Healing = false;
            _AbilitiesCooldownJ.CooldownJHeal();
        }

        invispercent -= Time.deltaTime;
        invisPower.SetHealth(invispercent);
        closestEnemy = getClosestEnemy();
        invisTimer -= Time.deltaTime;

        if(_HealthJerry.currentHealth == _HealthJerry.maxHealth || !Healing && _AbilitiesCooldownJ.coolDownTimerJH != -1)
        {
            apple.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
        }else if (!Healing && _AbilitiesCooldownJ.coolDownTimerJH == -1)
        {
            apple.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else if (!Healing && _AbilitiesCooldownJ.coolDownTimerJH == -1)
        {
            apple.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        if (_AbilitiesCooldownJ.coolDownTimerJI == -1 && !invis)
        {
            invisI.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        }

        //heal
        if (Input.GetKeyDown(KeyCode.E) && _AbilitiesCooldownJ.coolDownTimerJH == -1 && _HealthJerry.currentHealth != _HealthJerry.maxHealth && healcooldown && !_WalkJInjured.JDead)
        {
            healthChange = UnityEngine.Random.Range(30, 75);
            healcooldown = false;
            _RandomSounds.Other = 3;
            JHealingStart();
        }

        //invis
        if(Input.GetKeyDown(KeyCode.LeftControl) && _AbilitiesCooldownJ.coolDownTimerJI == -1 && !invis && !_WalkJInjured.JDead)
        {
            if (_SceneChange1.Scene == 1)
            {
                _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
                 _AorD.vignetteLayer1.color.value = Color.magenta;
                 _AorD.vignetteLayer1.intensity.value = 0.5f;
            }
            else if (_SceneChange1.Scene == 2)
            {
                _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
                _AorD.vignetteLayer2.color.value = Color.magenta;
                _AorD.vignetteLayer2.intensity.value = 0.5f;

            }
            else if (_SceneChange1.Scene == 3)
            {
                _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);
                _AorD.vignetteLayer3.color.value = Color.magenta;
                _AorD.vignetteLayer3.intensity.value = 0.5f;

            }

            gunMain.GetComponent<Renderer>().enabled = false;
            gun.GetComponent<Renderer>().enabled = false;
            invispercent = 10;
            invisHB.SetActive(true);
            invis = true;
            invisI.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
            _RandomSounds.Other = 3;
            _WalkingJ.walkSpeed = 200;
            invisTimer = 10;
            StartCoroutine(Belt());
            IEnumerator Belt()
            {
                GameObject.Find("JerryGunMain").gameObject.GetComponent<gunscriptJ>().enabled = false;
                _RandomSounds.Other = 10;
                yield return new WaitForSeconds(1f);
                if (!HealStart)
                {
                    gunMain.GetComponent<Renderer>().enabled = true;
                    gun.GetComponent<Renderer>().enabled = true;
                    GameObject.Find("JerryGunMain").gameObject.GetComponent<gunscriptJ>().enabled = true;
                }
            }
            foreach (GameObject Enemey1 in Enemies)
            {
                if (Enemey1 != GameObject.Find("Cube"))
                {
                    if (_SceneChange1.shiprechedWaypoint && !_SceneChange1.Teleported)
                    {
                        if (_SceneChange1.Scene == 1)
                        {
                            _enemyController1 = Enemey1.gameObject.GetComponent<enemyController1>();
                            _enemyController1.timeBtwShots = 10;
                            _enemyController1.Player = GameObject.Find("__WaypointPorta1").transform;
                        }
                    }
                    if (_SceneChange2.shiprechedWaypoint && !_SceneChange2.Teleported)
                    { 
                     if (_SceneChange1.Scene == 2)
                    {
                        _enemyController1 = Enemey1.gameObject.GetComponent<enemyController1>();
                        _enemyController1.timeBtwShots = 10;
                        _enemyController1.Player = GameObject.Find("__WaypointPortal3").transform;
                    }
                    }
                    else
                    {
                        _enemyController1 = Enemey1.gameObject.GetComponent<enemyController1>();
                        _enemyController1.timeBtwShots = 10;
                        _enemyController1.Player = GameObject.Find("__Ship").transform;
                    }
                }
            }
            _RandomSounds.Abilities();
            if (!Globals.isGameFinished)
            {
                _AorD.actualScore = UnityEngine.Random.Range(30, 40);
                _AorD.displayScore.text = _AorD.actualScore.ToString();
                Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                _AorD.ScoreA();
            }
        }

        if(invis && invisTimer <= 0)
        {
            _WalkingJ.walkSpeed = 160;
            foreach (GameObject Enemey1 in Enemies)
            {
                if (Enemey1 != GameObject.Find("Cube"))
                {
                    _enemyController1 = Enemey1.gameObject.GetComponent<enemyController1>();
                    _enemyController1.Player = GameObject.Find("Characters").transform;
                }
            }
            invisI.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
            invisHB.SetActive(false);
            invis = false;
            _AbilitiesCooldownJ.CooldownJInvis();
        }
    }

    public void JHealingStart()
    {
        if (!invis)
        {
            if (_SceneChange1.Scene == 1)
            {
                _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
                if (_HealthJerry.currentHealth != _HealthJerry.maxHealth)
                {
                    _AorD.vignetteLayer1.color.value = Color.green;
                    _AorD.vignetteLayer1.intensity.value = 0.5f;
                }
            }
            else if (_SceneChange1.Scene == 2)
            {
                _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
                if (_HealthJerry.currentHealth != _HealthJerry.maxHealth)
                {
                    _AorD.vignetteLayer2.color.value = Color.green;
                    _AorD.vignetteLayer2.intensity.value = 0.5f;
                }
            }
            else if (_SceneChange1.Scene == 3)
            {
                _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);
                if (_HealthJerry.currentHealth != _HealthJerry.maxHealth)
                {
                    _AorD.vignetteLayer3.color.value = Color.green;
                    _AorD.vignetteLayer3.intensity.value = 0.5f;
                }
            }
        }

        HealStart = true;
        GameObject.Find("JerryGunMain").gameObject.GetComponent<gunscriptJ>().enabled = false;
        _RandomSounds.Other = 9;
        Healing = true;
        apple.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
        gunMain.GetComponent<Renderer>().enabled = false;
        gun.GetComponent<Renderer>().enabled = false;
        eatMain.GetComponent<Renderer>().enabled = true;
        Apple.GetComponent<Renderer>().enabled = true;

        anim = GameObject.Find("EatMain").GetComponent<Animator>();
        anim.SetBool("Eating", true);
    }

    public void JHealing1()
    {
        Apple.GetComponent<Renderer>().enabled = false;
        StartCoroutine(Healing());
        IEnumerator Healing()
        {
            while ((healedAmount != healthChange) && (_HealthJerry.currentHealth != _HealthJerry.maxHealth) && (_HealthJerry.currentHealth != 0))
            {
                healedAmount++;
                _HealthJerry.currentHealth += 1;
                _HealthJerry.HealthJ.text = _HealthJerry.currentHealth.ToString();
                _HealthJerry.healthBar.SetHealth(_HealthJerry.currentHealth);
                yield return new WaitForSeconds(0.25f);
            }
        }
        healedAmount = 0;
    }

    public void JHealing2()
    {
        HealStart = false;
        anim.SetBool("Eating", false);
        gunMain.GetComponent<Renderer>().enabled = true;
        gun.GetComponent<Renderer>().enabled = true;
        eatMain.GetComponent<Renderer>().enabled = false;
        anim = GameObject.Find("JerryGunMain").GetComponent<Animator>();
        _RandomSounds.Abilities();
        if (!Globals.isGameFinished)
        {
            _AorD.actualScore = UnityEngine.Random.Range(30, 40);
            _AorD.displayScore.text = _AorD.actualScore.ToString();
            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
            _AorD.ScoreA();
        }
        GameObject.Find("JerryGunMain").gameObject.GetComponent<gunscriptJ>().enabled = true;
    }
}
