using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AbilitiesMainS : MonoBehaviour
{
    public GameObject ice, fire, drain, hole, arrows;

    public ParticleSystem fireEffect;
    public int ArrowType;

    public AbilitiesCoolDownS _AbilitiesCoolDownS;
    public gunscriptS _gunscriptS;
    public AppearDisappear _AorD;
    public enemyhit _enemyhit;
    public RandomSounds _RandomSounds;
    public HealthSummer _HealthSummer;
    public WalkSInjured _WalkSInjured;
    public SceneChange1 _SceneChange1;

    public bool isUsingarrowType = false;
    public bool isUsingPierce = false;
    public bool firstE = true;
    public bool pierce = false;
    public bool Multiple = false;
    public bool draining = false;

    public float damageToAdd;
    public float healedAmount;
    void Start()
    {
        hole.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        arrows.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        ice.SetActive(true);
        fire.SetActive(false);
        drain.SetActive(false);
        ArrowType = 1;
        _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
        _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
        _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);
    }


    void Update()
    {
        //Arrow Types
        if (ArrowType == 1)
        {
            ice.SetActive(true);
            fire.SetActive(false);
            drain.SetActive(false);
        }
        else if (ArrowType == 2)
        {
            ice.SetActive(false);
            fire.SetActive(true);
            drain.SetActive(false);
        }
        else if (ArrowType == 3)
        {
            ice.SetActive(false);
            fire.SetActive(false);
            drain.SetActive(true);
        }

        if(_AbilitiesCoolDownS.coolDownTimerSAT == -1 && isUsingarrowType)
        {
            if (ArrowType == 1)
            {
                fireEffect.Stop();
            }
            else if (ArrowType == 2)
            {
                fireEffect.Play();
            }
            else if (ArrowType == 3)
            {
                fireEffect.Stop();
            }
        }

        if (_AbilitiesCoolDownS.coolDownTimerSAT == -1 && !isUsingarrowType)
        {
            if (_HealthSummer.currentHealth != _HealthSummer.maxHealth)
            {
                drain.GetComponent<Image>().color = new Color32(0, 0, 0, 225);
            }
            else if (_HealthSummer.currentHealth == _HealthSummer.maxHealth)
            {
                drain.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
            }
            ice.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
            fire.GetComponent<Image>().color = new Color32(255, 255, 255, 225);
        }

        if (Input.GetKeyDown(KeyCode.E) && _AbilitiesCoolDownS.coolDownTimerSAT == -1 && !_WalkSInjured.SDead)
        {
            _RandomSounds.Other = 3;
            if (firstE)
            {
                isUsingarrowType = true;
                ice.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
                fire.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
                drain.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
                firstE = false;
            }
            else if (!firstE)
            {
                if (ArrowType == 1)
                {
                    ArrowType = 2;
                }
                else if (ArrowType == 2)
                {
                    ArrowType = 3;
                }
                else if (ArrowType == 3)
                {
                    ArrowType = 1;
                }
            }
        }

            if (_gunscriptS.shoot && isUsingarrowType && _AbilitiesCoolDownS.coolDownTimerSAT == -1 && !_WalkSInjured.SDead)
        {
            _RandomSounds.Abilities();
            isUsingarrowType = false;
            firstE = true;
            if (ArrowType == 1)
            {
                Debug.LogError("Ice Arrow");
                ice.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
                if (!Multiple)
                {
                    _gunscriptS.Bullets.gameObject.tag = "IceArrow";
                }else if(Multiple)
                {
                    _gunscriptS.Bullets.gameObject.tag = "IceArrow";
                    _gunscriptS.Bullets2.gameObject.tag = "IceArrow";
                    _gunscriptS.Bullets3.gameObject.tag = "IceArrow";
                }
                _AbilitiesCoolDownS.CooldownSarrowType();
            }
            else if (ArrowType == 2)
            {
                Debug.LogError("Fire Arrow");
               fire.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
                if (!Multiple)
                {
                    _gunscriptS.Bullets.gameObject.tag = "FireArrow";
                }
                else if (Multiple)
                {
                    _gunscriptS.Bullets.gameObject.tag = "FireArrow";
                    _gunscriptS.Bullets2.gameObject.tag = "FireArrow";
                    _gunscriptS.Bullets3.gameObject.tag = "FireArrow";
                }
                _AbilitiesCoolDownS.CooldownSarrowType();
            }
            else if (ArrowType == 3 && _HealthSummer.currentHealth != _HealthSummer.maxHealth)
            {
                draining = true;
                Debug.LogError("Drain Arrow");
                drain.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
                if (!Multiple)
                {
                    _gunscriptS.Bullets.gameObject.tag = "DrainArrow";
                }
                else if (Multiple)
                {
                    _gunscriptS.Bullets.gameObject.tag = "DrainArrow";
                    _gunscriptS.Bullets2.gameObject.tag = "DrainArrow";
                    _gunscriptS.Bullets3.gameObject.tag = "DrainArrow";
                }
                _AbilitiesCoolDownS.CooldownSarrowType();
            }
            if (!Globals.isGameFinished)
            {
                _AorD.actualScore = UnityEngine.Random.Range(20, 30);
                _AorD.displayScore.text = _AorD.actualScore.ToString();
                Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                _AorD.ScoreA();
            }
        }else if (_gunscriptS.shoot && !isUsingarrowType)
        {
            if (!Multiple)
            {
                _gunscriptS.Bullets.gameObject.tag = "NormalArrow";
            }
            else if (Multiple)
            {
                _gunscriptS.Bullets.gameObject.tag = "NormalArrow";
                _gunscriptS.Bullets2.gameObject.tag = "NormalArrow";
                _gunscriptS.Bullets3.gameObject.tag = "NormalArrow";
            }
        }

            //Pierce ability
            if (Input.GetKeyDown(KeyCode.LeftAlt) && _AbilitiesCoolDownS.coolDownTimerP == -1 && !_WalkSInjured.SDead)
       {
            _RandomSounds.Other = 3;
            hole.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
            isUsingPierce = true;
        }

        if (_gunscriptS.shoot && isUsingPierce &&_AbilitiesCoolDownS.coolDownTimerP == -1 && !_WalkSInjured.SDead)
        {
            _RandomSounds.Abilities();
            hole.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
            isUsingPierce = false;
            pierce = true;
            _AbilitiesCoolDownS.CooldownPierce();
            if (!Globals.isGameFinished)
            {
                _AorD.actualScore = UnityEngine.Random.Range(30, 40);
                _AorD.displayScore.text = _AorD.actualScore.ToString();
                Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                _AorD.ScoreA();
            }
        }
        if (_AbilitiesCoolDownS.coolDownTimerP == -1 && !isUsingPierce)
        {
            hole.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        //Multiple ability
        if (Input.GetKeyDown(KeyCode.LeftControl) && _AbilitiesCoolDownS.coolDownTimerM == -1 && !_WalkSInjured.SDead)
        {
            _RandomSounds.Other = 3;
            arrows.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
            Multiple = true;
        }

        if (_gunscriptS.shoot && Multiple && _AbilitiesCoolDownS.coolDownTimerM == -1 && !_WalkSInjured.SDead)
        {
            _RandomSounds.Abilities();
            arrows.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
            Multiple = false;
            _AbilitiesCoolDownS.CooldownMultiple();
            if (!Globals.isGameFinished)
            {
                _AorD.actualScore = UnityEngine.Random.Range(10, 25);
                _AorD.displayScore.text = _AorD.actualScore.ToString();
                Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                _AorD.ScoreA();
            }
        }

        if(_AbilitiesCoolDownS.coolDownTimerM == -1 && !Multiple)
        {
            arrows.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }

    public void drained()
    {
        damageToAdd = _gunscriptS.shotDamage / 3;
        StartCoroutine(Healing());
        IEnumerator Healing()
        {
            while ((healedAmount < damageToAdd) && (_HealthSummer.currentHealth != _HealthSummer.maxHealth) && (_HealthSummer.currentHealth != 0))
            {
                healedAmount++;
                _HealthSummer.currentHealth += 1;
                _HealthSummer.HealthS.text = _HealthSummer.currentHealth.ToString();
                _HealthSummer.healthBar.SetHealth(_HealthSummer.currentHealth);
                yield return new WaitForSeconds(0.02f);
            }
            draining = false;
        }
        healedAmount = 0;
    }

    public void drainEffects()
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
}
