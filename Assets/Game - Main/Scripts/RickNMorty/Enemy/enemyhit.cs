using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhit : MonoBehaviour
{
    public float enemyHealth = 200;
    public HealthBar healthBar;

    public GameObject bullet, Bullets, Fireballs;
    public gunscriptR _gunscriptR;
    public gunscriptM _gunscriptM;
    public gunscriptS _gunscriptS;
    public gunscriptJ _gunscriptJ;
    public gunscriptB _gunscriptB;
    public ChangingCharacter _ChangingCharacter;
    public AbilitiesMain _AbilitiesMain;
    public AppearDisappear _AorD;
    public EnemySummoning _EnemySummoning;
    public enemyController1 _enemyController1;
    public RandomSounds _RandomSounds;
    public AbilitiesMainS _AbilitesMainS;
    public Grenade _Grenade;

    public bool burnt, frozen, drained;
    public int amount, amount2;
    public GameObject fireEffect, FireEffectMain, iceblock, sleepParticles, Player;

    public Animator anim;
    public Rigidbody rb;

    public bool Dead = false;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        anim = this.gameObject.GetComponent<Animator>();
        setColliderState(false);
        setRigidbodyState(true);
        if (Globals.Character == "Summer")
        {
            fireEffect = this.gameObject.transform.GetChild(2).gameObject;
            iceblock = this.transform.GetChild(3).gameObject;
            InvokeRepeating("burning", 1f, 1f);
        }else if(Globals.Character == "Rick And Morty")
        {
            fireEffect = this.gameObject.transform.GetChild(2).gameObject;
            InvokeRepeating("burning", 1f, 1f);
        }
        healthBar.SetHealth(enemyHealth);
    }

    void Update()
    {
        if (Globals.Character == "Rick And Morty")
        {
            if ((_ChangingCharacter.charSelect == 0) && (!_AbilitiesMain.Teleporting))
            {
                bullet = GameObject.Find("BulletR");
                _gunscriptR = _AorD.RGun.gameObject.GetComponent<gunscriptR>();
            }
            else if (_ChangingCharacter.charSelect == 1)
            {
                bullet = GameObject.Find("BulletM");
                _gunscriptM = _AorD.MGun.gameObject.GetComponent<gunscriptM>();
            }

            if (amount == 5)
            {
                _RandomSounds.Fire.Stop();
                burnt = false;
                amount = 0;
                fireEffect.SetActive(false);
            }

            if (burnt)
            { 
                fireEffect.SetActive(true);
            }
        }

        if (enemyHealth <= 0)
        {
            Dead = true;
            Die();
        }

        if (Globals.Character == "Summer")
        {
            if (amount == 5)
            {
                _RandomSounds.Fire.Stop();
                burnt = false;
                amount = 0;
                fireEffect.SetActive(false);
            }

            if (burnt)
            {
                fireEffect.SetActive(true);
            }

            if (frozen)
            {
                StartCoroutine(freeze());
                IEnumerator freeze()
                {
                    iceblock.SetActive(true);
                    this.gameObject.GetComponent<enemyController1>().enabled = false;
                    anim.enabled = false;
                    yield return new WaitForSeconds(3);
                    if (!Dead)
                    {
                        this.gameObject.GetComponent<enemyController1>().enabled = true;
                        anim.enabled = true;
                    }
                    iceblock.SetActive(false);
                    frozen = false;
                }
            }
        }
    }
    public void burning()
    {
        if (burnt)
        {
            amount++;
            TakeDamage(Random.Range(10, 30));
            Debug.LogError("Took Damage");
        }
    }

    public void TakeDamage(float amount)
    {
        enemyHealth -= amount;
        healthBar.SetHealth(enemyHealth);
    }

    void Die()
    {
        _RandomSounds.Killing();
        _RandomSounds.EDeath();
        if (_EnemySummoning.enemiesSummoned >= 1)
        {
            _RandomSounds.EFriendHit();
        }
        setColliderState(true);
        setRigidbodyState(false);
        if (Globals.Character == "Summer")
        {
            burnt = false;
            amount = 0;
            fireEffect.SetActive(false);
            iceblock.SetActive(false);
            frozen = false;
            _RandomSounds.Fire.Stop();

        }
        else if (Globals.Character == "Rick And Morty")
        {
            burnt = false;
            amount = 0;
            fireEffect.SetActive(false);
            _RandomSounds.Fire.Stop();
        }
        Dead = true;
        StartCoroutine(Death());
        IEnumerator Death()
        {
            if (!Globals.isGameFinished)
            {
                _AorD.actualScore = UnityEngine.Random.Range(60, 80);
                _AorD.displayScore.text = _AorD.actualScore.ToString();
                Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                _AorD.ScoreA();
            }
            yield return new WaitForSeconds(3);
            _EnemySummoning.Timer = 1;
            _EnemySummoning.enemiesSummoned--;
        }
        gameObject.transform.tag = "EnemyTwo";
        this.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.GetComponent<enemyController1>().enabled = false;
        this.enabled = false;
        StartCoroutine(Despawn());
        IEnumerator Despawn()
        {
            yield return new WaitForSeconds(10f);
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Bullets")
        {
            _RandomSounds.EHit();
            if (Globals.Character == "Rick And Morty")
            {
                if (_ChangingCharacter.charSelect == 0)
                {
                    Bullets = _gunscriptR.Bullets;
                    Destroy(Bullets);
                    TakeDamage(_gunscriptR.damage);
                }
                else if (_ChangingCharacter.charSelect == 1)
                {
                    Bullets = _gunscriptM.Bullets;
                    Destroy(Bullets);
                    TakeDamage(_gunscriptM.damage);
                }
            }
            else if (Globals.Character == "Jerry")
            {
                Bullets = _gunscriptJ.Bullets;
                TakeDamage(_gunscriptJ.damage);
                Destroy(Bullets);
            }
            else if (Globals.Character == "Beth")
            {
                Bullets = _gunscriptB.Bullets;
                TakeDamage(_gunscriptB.damage);
                Destroy(Bullets);
            }
        }

            if (Globals.Character == "Summer")
            {
            if (collision.gameObject.layer == 21)
            {
                if (collision.gameObject.tag == "IceArrow")
                {
                    frozen = true;
                }
                if (collision.gameObject.tag == "FireArrow")
                {
                    _RandomSounds.Fire.Play();
                    _enemyController1.timeBtwShots = 5;
                    burnt = true;
                }
                if (collision.gameObject.tag == "DrainArrow")
                {
                   _AbilitesMainS.drained();
                   _AbilitesMainS.drainEffects();
                }
                Bullets = _gunscriptS.Bullets;
                TakeDamage(_gunscriptS.shotDamage);
                if (!_AbilitesMainS.pierce)
                {
                    StartCoroutine(Destroy1());
                    IEnumerator Destroy1()
                    {
                        yield return new WaitForSeconds(2f);
                        Destroy(Bullets);
                    }
                }
                _gunscriptS.damage = 0;
            }
            }
           
            if (collision.gameObject.tag == "FireBall")
        {
            _RandomSounds.Fire.Play();
            _enemyController1.timeBtwShots = 5;
            burnt = true;
            StartCoroutine(FBWait());
            IEnumerator FBWait()
            {
                _RandomSounds.EHit();
                Fireballs = _AbilitiesMain.Fireballs;
                yield return new WaitForSeconds(1);
                Destroy(Fireballs);
                TakeDamage(_AbilitiesMain.FBDamage);
            }
        }

        if (collision.gameObject.tag == "Grenade")
        {
            _Grenade = _AbilitiesMain.grenades.GetComponent<Grenade>();
           _RandomSounds.EHit();
            _Grenade.Explode();
            TakeDamage(_AbilitiesMain.GrenadeDamage);
        }

        if(collision.gameObject.tag == "Dart")
        {
            StartCoroutine(sleep());
            IEnumerator sleep()
            {
                this.gameObject.GetComponent<enemyController1>().enabled = false;
                anim.enabled = false;
                yield return new WaitForSeconds(3);
                if (!Dead)
                {
                    this.gameObject.GetComponent<enemyController1>().enabled = true;
                    anim.enabled = true;
                }
            }
        }
    }

    public void setRigidbodyState(bool state)
    {
        Rigidbody[] rigidbodies = this.gameObject.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }
    }

    public void setColliderState(bool state)
    {
        Collider[] colliders = this.gameObject.GetComponentsInChildren<Collider>();
        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }
        GetComponent<Collider>().enabled = !state;
        anim.enabled = !state;
    }
}
