using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.Rendering.PostProcessing;
using System;
public class AbilitiesMain : MonoBehaviour
{
    public Material Normal, frozen;

    public bool enemyContact;
    Transform trans = null;
    public GameObject[] Enemies;

    public AbilityCooldown _AbilityCooldown;
    public ChangingCharacter _ChangingCharacter;
    public HealthRick _HealthRick;
    public RandomSounds _RandomSounds;
    public AppearDisappear _AorD;
    public enemyhit _enemyhit;
    public EnemySummoning _EnemySummoning;
    public CrouchJumpMelee _CrouchJumpMelee;
    public SceneChange1 _SceneChange1;
    public WalkRInjured _WalkRInjured;
    public WalkMInjured _WalkMInjured;

    public Image RDrinkButton, RTButton, MmagicButton;

    public Animator anim;

    public Transform Player, PortalTP, RGun, closestEnemy;

    public GameObject Portalgun, MortyMagic, MGun, SnowParticle, Fireball, Fireballs, Fireballspawn, grenade, grenades;

    public int MMint;

    private int healthChange;
    private int healedAmount;
    private int fireballSpeed;
    public int fireballLifeTime;

    public bool Drinking;
    public bool Teleporting;
    public bool Teleported;
    public bool DecidingT;
    public bool Magic;
    public bool ShootingFireball, throwingGrenade;

    public float lookRadius;

    public int FBDamage, GrenadeDamage;
    float Enemydistance;

    public float throwForce = 40f;
    // Start is called before the first frame update
    void Start()
    {
        _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
        _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
        _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);
        if (Globals.Character == "Rick And Morty")
        {
            MMint = UnityEngine.Random.Range(1, 3);
            FBDamage = UnityEngine.Random.Range(75, 100);
            GrenadeDamage = UnityEngine.Random.Range(275, 300);
            throwingGrenade = false;
            ShootingFireball = false;
            fireballSpeed = 200;
            fireballLifeTime = 3;
            SnowParticle.SetActive(false);
            MortyMagic.gameObject.GetComponent<Renderer>().enabled = false;
            Teleported = true;
            Portalgun.SetActive(false);
            RDrinkButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            Magic = false;
        }
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


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    // Update is called once per frame
    void Update()
    {

        closestEnemy = getClosestEnemy();

        if (_SceneChange1.Scene == 1)
        {
            _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
        }
        else if (_SceneChange1.Scene == 2)
        {
            _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
        }
        else if (_SceneChange1.Scene == 3)
        {
            _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);
        }

        Enemydistance = Vector3.Distance(trans.transform.position, transform.position);

        if (!PauseMenu.GameIsPaused)
        {
            if (Globals.Character == "Rick And Morty")
            {
                if (_CrouchJumpMelee.isJumping || _AbilityCooldown.coolDownTimerRT != -1)
                {
                    RTButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
                }
                else if (!Teleporting && _AbilityCooldown.coolDownTimerRT == -1)
                {
                    RTButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }

                if (_HealthRick.currentHealth == _HealthRick.maxHealth || _AbilityCooldown.coolDownTimerRD != -1)
                {
                    RDrinkButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
                }
                else if (_AbilityCooldown.coolDownTimerRD == -1 && !Drinking)
                {
                    RDrinkButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }

                if (_AbilityCooldown.coolDownTimerMM != -1)
                {
                    MmagicButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
                }
                else if (_AbilityCooldown.coolDownTimerMM == -1 && !Magic)
                {
                    MmagicButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }

                if (Input.GetButtonDown("RDrink") && (_AbilityCooldown.coolDownTimerRD == -1) && (_ChangingCharacter.charSelect == 0) && (_ChangingCharacter.Changing == false) && (Teleported) && (!Drinking) && _HealthRick.currentHealth != _HealthRick.maxHealth && !_WalkRInjured.RDead)
                {
                    _RandomSounds.Abilities();
                    RHealing();
                }

                if (Input.GetButtonDown("RTeleport") && (_AbilityCooldown.coolDownTimerRT == -1) && (_ChangingCharacter.charSelect == 0) && (_ChangingCharacter.Changing == false) && (!Drinking) && !_CrouchJumpMelee.isJumping && !_WalkRInjured.RDead)
                {
                    Teleporting = true;
                    _RandomSounds.Other = 3;
                    _RandomSounds.Abilities();
                    _ChangingCharacter.ChangeButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
                    RDrinkButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
                    RTButton.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
                    Debug.Log("Teleporting");
                    _AorD.TeleportingA();
                }

                if (Input.GetButtonDown("MMagic") && (_AbilityCooldown.coolDownTimerMM == -1) && (_ChangingCharacter.charSelect == 1) && (_ChangingCharacter.Changing == false) && !_WalkMInjured.MDead)
                {
                   MmagicButton.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
                    _RandomSounds.Other = 3;
                    _RandomSounds.Abilities();
                    MMagicStart();
                }


                if (Teleporting)
                {
                    anim = GameObject.Find("Rick").gameObject.GetComponent<Animator>();
                    Teleported = false;
                    _AorD.RGun.gameObject.GetComponent<Renderer>().enabled = false;
                    GameObject.Find("GunSlide").gameObject.GetComponent<Renderer>().enabled = false;
                    Portalgun.SetActive(true);
                    anim = GameObject.Find("Rick").gameObject.GetComponent<Animator>();
                    DecidingT = true;
                    if (Input.GetButtonDown("Confirm"))
                    {
                        Teleporting = false;
                        _AorD.RGun.gameObject.GetComponent<Renderer>().enabled = true;
                        GameObject.Find("GunSlide").gameObject.GetComponent<Renderer>().enabled = true;
                        Portalgun.SetActive(false);
                        RTeleportingStart();
                    }
                    else if (Input.GetButtonDown("Cancel"))
                    {
                        _AorD.RGun.gameObject.GetComponent<Renderer>().enabled = true;
                        GameObject.Find("GunSlide").gameObject.GetComponent<Renderer>().enabled = true;
                        Portalgun.SetActive(false);
                        Teleporting = false;
                        Teleported = true;
                        DecidingT = false;
                        _AorD.TeleportingD();
                        RDrinkButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                        _ChangingCharacter.ChangeButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                        RTButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);

                    }
                }
            }
        }
    }

    public void RTeleportingStart()
    {
        anim.speed = 2.5f;
        DecidingT = false;
        _AorD.thirdCam();
        GameObject.Find("RickModel").gameObject.GetComponent<Renderer>().enabled = true;
        anim.Play("Armature|ShootPortalFW");
        _AorD.PGunA();
    }

    public void RTeleporting1()
    {
        _AorD.PortalADeath();
    }

    public void RTeleporting2()
    {
        anim.SetInteger("AnimPortalR1", 1);
        _AorD.PGunD();
    }

    public void RTeleporting3()
    {
        _RandomSounds.Other = 1;
    }

    public void RTeleporting4()
    {
        _AorD.PortalDDeath();
        Player.position = PortalTP.position;
    }

    public void RTeleporting5()
    {
        anim.Play("Armature|Flipping (Portal)");
    }

    public void RTeleporting6()
    {
        _AorD.TeleportingD();
    }

    public void RTeleporting7()
    {
        _AorD.rickCam();
        _AbilityCooldown.CooldownRTeleport();
        GameObject.Find("RickModel").gameObject.GetComponent<Renderer>().enabled = false;
        RDrinkButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        _ChangingCharacter.ChangeButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        RTButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        anim.speed = 1f;
        anim.Play("Armature|Idle Main");
        if (!Globals.isGameFinished)
        {
            _AorD.actualScore = UnityEngine.Random.Range(40, 50);
            _AorD.displayScore.text = _AorD.actualScore.ToString();
            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
            _AorD.ScoreA();
        }
        Teleported = true;
    }

    void RHealing()
    {
        if (_SceneChange1.Scene == 1)
        {
            _AorD.volume1.profile.TryGetSettings(out _AorD.vignetteLayer1);
            if (_HealthRick.currentHealth != _HealthRick.maxHealth)
            {
                _AorD.vignetteLayer1.color.value = Color.green;
                _AorD.vignetteLayer1.intensity.value = 0.5f;
            }
        }
        else if (_SceneChange1.Scene == 2)
        {
            _AorD.volume2.profile.TryGetSettings(out _AorD.vignetteLayer2);
            if (_HealthRick.currentHealth != _HealthRick.maxHealth)
            {
                _AorD.vignetteLayer2.color.value = Color.green;
                _AorD.vignetteLayer2.intensity.value = 0.5f;
            }
        }
        else if (_SceneChange1.Scene == 3)
        {
            _AorD.volume3.profile.TryGetSettings(out _AorD.vignetteLayer3);
            if (_HealthRick.currentHealth != _HealthRick.maxHealth)
            {
                _AorD.vignetteLayer3.color.value = Color.green;
                _AorD.vignetteLayer3.intensity.value = 0.5f;
            }
        }

            anim = GameObject.Find("RickGunMainModel").gameObject.GetComponent<Animator>();
            Drinking = true;
            _ChangingCharacter.ChangeButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
            RTButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
            RDrinkButton.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
            _RandomSounds.Other = 3;
            healthChange = UnityEngine.Random.Range(30, 75);
            _AorD.RDrinkingA();
            anim.Play("Drinking");
            StartCoroutine(Healing());
            IEnumerator Healing()
            {
                while ((healedAmount != healthChange) && (_HealthRick.currentHealth != _HealthRick.maxHealth) && (_HealthRick.currentHealth != 0))
                {
                    healedAmount++;
                    _HealthRick.currentHealth += 1;
                    _HealthRick.HealthR.text = _HealthRick.currentHealth.ToString();
                    _HealthRick.healthBar.SetHealth(_HealthRick.currentHealth);
                    yield return new WaitForSeconds(0.02f);
                }
            }
            healedAmount = 0;
        
    }

    public void RHealing1()
    {
        if (!Globals.isGameFinished)
        {
            _AorD.actualScore = UnityEngine.Random.Range(30, 40);
            _AorD.displayScore.text = _AorD.actualScore.ToString();
            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
            _AorD.ScoreA();
        }
        _AbilityCooldown.CooldownRDrink();
        RDrinkButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        _ChangingCharacter.ChangeButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        RTButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        _AorD.RDrinkingD();
        Drinking = false;
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



    void MMagicStart()
    {
        Magic = true;
        MortyMagic.gameObject.GetComponent<Renderer>().enabled = true;
        MGun.gameObject.GetComponent<gunscriptM>().enabled = false;
        GameObject.Find("rdmobj00").gameObject.GetComponent<Renderer>().enabled = false;
        MGun.gameObject.GetComponent<Renderer>().enabled = false;
        anim = GameObject.Find("MortyMagicMain").gameObject.GetComponent<Animator>();
        anim.SetInteger("Magic", MMint);
    }

    public void MMagic1()
    {
        ShootingFireball = false;
        throwingGrenade = false;
        if (!Globals.isGameFinished)
        {
            _AorD.actualScore = UnityEngine.Random.Range(50, 70);
            _AorD.displayScore.text = _AorD.actualScore.ToString();
            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
            _AorD.ScoreA();
        }
        Magic = false;
        anim.SetInteger("Magic", 0);
        MortyMagic.gameObject.GetComponent<Renderer>().enabled = false;
        GameObject.Find("rdmobj00").gameObject.GetComponent<Renderer>().enabled = true;
        MGun.gameObject.GetComponent<Renderer>().enabled = true;
        MGun.gameObject.GetComponent<gunscriptM>().enabled = true;
        _AbilityCooldown.CooldownMMagic();
        MMint = UnityEngine.Random.Range(1, 3);
    }

    public void MFireBall()
    {
        ShootingFireball = true;
        Fireballs = Instantiate(Fireball);
        Fireballs.transform.position = Fireballspawn.transform.position;
        Fireballs.GetComponent<Rigidbody>().AddForce(Fireballspawn.transform.forward * fireballSpeed, ForceMode.Impulse);
        StartCoroutine(DestroyFireball(Fireballs, fireballLifeTime));
        Magic = false;
    }

    public void MGrenade()
    {
        throwingGrenade = true;
        grenades = Instantiate(grenade);
        grenades.SetActive(true);
        grenades.transform.position = Fireballspawn.transform.position;
        grenades.GetComponent<Rigidbody>().AddForce(Fireballspawn.transform.forward * throwForce, ForceMode.Impulse);
        Magic = false;
    }
    

    private IEnumerator DestroyFireball(GameObject Fireballs, float delay)
    {
        yield return new WaitForSeconds(delay);
        DFireball(Fireballs);
    }

    public void DFireball(GameObject Fireballs)
    {
        Destroy(Fireballs);
    }

}
