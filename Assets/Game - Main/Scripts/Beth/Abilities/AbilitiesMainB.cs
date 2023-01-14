using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilitiesMainB : MonoBehaviour
{
    public GameObject dart, darts, dartgun, gun, Crosshair, fpsCamY, fpsCamX, wineglass;
    public Animator anim;
    public bool Dart;
    public Transform dartspawn;
    public float dartspeed;
    public float dartLifeTime = 0.5f;

    public AbilitiesCooldownB _AbilitiesCooldownB;
    public RandomSounds _RandomSounds;
    public AppearDisappear _AorD;
    public HealthBeth _HealthBeth;
    public SceneChange1 _SceneChange1;
    public WalkBInjured _WalkBInjured;
    public WalkingB _WalkingB;

    public int healedAmount;
    public int healthChange;

    public bool Healing, Dash;

    public Image wine, sleep, dash;

    void Start()
    {
        Dash = false;
        Healing = false;
        wineglass.SetActive(false);
        dartgun.SetActive(false);
        gun.SetActive(true);
        _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
        _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
        _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);
    }


    void Update()
    {
        if(Healing)
        {
            if (_SceneChange1.Scene == 1)
            {
                _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
                _AorD.vignetteLayer1.color.value = Color.green;
                _AorD.vignetteLayer1.intensity.value = 0.5f;
            }
            else if (_SceneChange1.Scene == 2)
            {
                _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
                _AorD.vignetteLayer2.color.value = Color.green;
                _AorD.vignetteLayer2.intensity.value = 0.5f;
            }
            else if (_SceneChange1.Scene == 3)
            {
                _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);
                _AorD.vignetteLayer3.color.value = Color.green;
                _AorD.vignetteLayer3.intensity.value = 0.5f;
            }
        }
        else if(Dash)
        {
            if (_SceneChange1.Scene == 1)
            {
                _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
                _AorD.vignetteLayer1.color.value = Color.blue;
                _AorD.vignetteLayer1.intensity.value = 0.5f;
            }
            else if (_SceneChange1.Scene == 2)
            {
                _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
                _AorD.vignetteLayer2.color.value = Color.blue;
                _AorD.vignetteLayer2.intensity.value = 0.5f;
            }
            else if (_SceneChange1.Scene == 3)
            {
                _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);
                _AorD.vignetteLayer3.color.value = Color.blue;
                _AorD.vignetteLayer3.intensity.value = 0.5f;
            }
        }
        if (_HealthBeth.currentHealth == _HealthBeth.maxHealth || !Healing && _AbilitiesCooldownB.coolDownTimerBH != -1 || Dart)
        {
            wine.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
        }
        else if (_AbilitiesCooldownB.coolDownTimerBH == -1 && !Healing)
        {
            wine.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        if(!Dart && _AbilitiesCooldownB.coolDownTimerBD != -1 || Healing)
        {
            sleep.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
        }
        else if (!Dart && _AbilitiesCooldownB.coolDownTimerBD == -1)
        {
            sleep.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        if (!Dash && _AbilitiesCooldownB.coolDownTimerBDa != -1)
        {
            dash.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
        }
        else if (!Dash && _AbilitiesCooldownB.coolDownTimerBDa == -1)
        {
            dash.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt) && _AbilitiesCooldownB.coolDownTimerBD == -1 && !Healing && !_WalkBInjured.BDead)
        {
            _RandomSounds.Other = 3;
            DartStart();
        }

        if(Input.GetKeyDown(KeyCode.E) && _AbilitiesCooldownB.coolDownTimerBH == -1 && _HealthBeth.currentHealth != _HealthBeth.maxHealth && !Dart && !_WalkBInjured.BDead)
        {
            _RandomSounds.Other = 3;
            HealStart();
        }

        if (Input.GetKeyDown(KeyCode.LeftControl) && _AbilitiesCooldownB.coolDownTimerBDa == -1 && !_WalkBInjured.BDead) 
        {
            _RandomSounds.Other = 3;
            DashStart();
        }
    }

    public void DashStart()
    {
        Dash = true;
        StartCoroutine(waitspeed());

        IEnumerator waitspeed()
        {
            _RandomSounds.Other = 11;
            _WalkingB.walkSpeed = 600;
            yield return new WaitForSeconds(1f);
            _WalkingB.walkSpeed = 160;
            _AbilitiesCooldownB.CooldownBDash();
            if (!Globals.isGameFinished)
            {
                _AorD.actualScore = UnityEngine.Random.Range(20, 30);
                _AorD.displayScore.text = _AorD.actualScore.ToString();
                Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                _AorD.ScoreA();
            }
            Dash = false;
        }
    }
    public void HealStart()
    {
        this.gameObject.GetComponentInChildren<gunscriptB>().enabled = false;
        anim.SetBool("Heal", true);
        wineglass.SetActive(true);
        Healing = true;
        wine.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
        if (_SceneChange1.Scene == 1)
        {
            _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
            if (_HealthBeth.currentHealth != _HealthBeth.maxHealth)
            {
                _AorD.vignetteLayer1.color.value = Color.green;
                _AorD.vignetteLayer1.intensity.value = 0.5f;
            }
        }
        else if (_SceneChange1.Scene == 2)
        {
            _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
            if (_HealthBeth.currentHealth != _HealthBeth.maxHealth)
            {
                _AorD.vignetteLayer2.color.value = Color.green;
                _AorD.vignetteLayer2.intensity.value = 0.5f;
            }
        }
        else if (_SceneChange1.Scene == 3)
        {
            _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);
            if (_HealthBeth.currentHealth != _HealthBeth.maxHealth)
            {
                _AorD.vignetteLayer3.color.value = Color.green;
                _AorD.vignetteLayer3.intensity.value = 0.5f;
            }
        }
        healthChange = UnityEngine.Random.Range(30, 75);
        StartCoroutine(healing());
        IEnumerator healing()
        {
            while ((healedAmount != healthChange) && (_HealthBeth.currentHealth != _HealthBeth.maxHealth) && (_HealthBeth.currentHealth != 0))
            {
                healedAmount++;
                _HealthBeth.currentHealth += 1;
                _HealthBeth.HealthB.text = _HealthBeth.currentHealth.ToString();
                _HealthBeth.healthBar.SetHealth(_HealthBeth.currentHealth);
                yield return new WaitForSeconds(0.02f);
            }
        }
        healedAmount = 0;
    }

    public void Heal1()
    {
        this.gameObject.GetComponentInChildren<gunscriptB>().enabled = true;
        anim.SetBool("Heal", false);
        wineglass.SetActive(false);
        _AbilitiesCooldownB.CooldownBHeal();
        Healing = false;
        if (!Globals.isGameFinished)
        {
            _AorD.actualScore = UnityEngine.Random.Range(30, 40);
            _AorD.displayScore.text = _AorD.actualScore.ToString();
            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
            _AorD.ScoreA();
        }
        if (_SceneChange1.Scene == 1)
        {
            _AorD.vignetteLayer1.color.value = Color.black;
            _AorD.vignetteLayer1.intensity.value = 0.399f;
        }
        else if (_SceneChange1.Scene == 2)
        {
            _AorD.vignetteLayer2.color.value = Color.black;
            _AorD.vignetteLayer2.intensity.value = 0.399f;
        }
        else if (_SceneChange1.Scene == 3)
        {
            _AorD.vignetteLayer3.color.value = Color.black;
            _AorD.vignetteLayer3.intensity.value = 0.399f;
        }
    }
    public void DartStart()
    {
        sleep.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
        Dart = true;
        dartgun.SetActive(true);
        gun.SetActive(false);
        this.gameObject.GetComponentInChildren<gunscriptB>().enabled = false;
        anim.SetBool("Dart", true);
    }

    public void Dart1()
    {
        Dart = false;
        dartgun.SetActive(false);
        gun.SetActive(true);
        this.gameObject.GetComponentInChildren<gunscriptB>().enabled = true;
        anim.SetBool("Dart", false);
        _AbilitiesCooldownB.CooldownBDart();
        _RandomSounds.Abilities();
        if (!Globals.isGameFinished)
        {
            _AorD.actualScore = UnityEngine.Random.Range(30, 40);
            _AorD.displayScore.text = _AorD.actualScore.ToString();
            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
            _AorD.ScoreA();
        }
    }

    public void FireDarts()
    {
        darts = Instantiate(dart);

        Physics.IgnoreCollision(darts.GetComponent<Collider>(), dartspawn.parent.GetComponent<Collider>());

        darts.transform.position = dartspawn.position;

        darts.transform.rotation = dartspawn.transform.rotation;

        darts.GetComponent<Rigidbody>().AddForce(dartspawn.transform.forward * dartspeed, ForceMode.Impulse);

        StartCoroutine(DestoryDart(darts, dartLifeTime));
    }

    private IEnumerator DestoryDart(GameObject darts, float delay)
    {
        yield return new WaitForSeconds(delay);
        Ddarts(darts);
    }

    public void Ddarts(GameObject darts)
    {
        Destroy(darts);
    }
}
