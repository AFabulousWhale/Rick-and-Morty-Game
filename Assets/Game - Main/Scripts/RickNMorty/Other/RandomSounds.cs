using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSounds : MonoBehaviour
{

    public ChangingCharacter _ChangingCharacter;
    public WalkRInjured _WalkRinjured;
    public WalkMInjured _WalkMinjured;
    public EnemySummoning _EnemySummoning;
    public gunscriptS _gunscriptS;

    public AudioSource _as;
    public AudioSource _Other;
    public AudioSource Fire;

    public AudioClip[] RickChange;
    public AudioClip[] MortyChange1;
    public AudioClip[] MortyChange2;
    public AudioClip[] RickDeath;
    public AudioClip[] MortyDeath;
    public AudioClip[] MortyHurt;
    public AudioClip[] RickHurt;
    public AudioClip[] RGun;
    public AudioClip[] MGun;

    public AudioClip[] EnemyDeath;
    public AudioClip[] EnemyHit;
    public AudioClip[] EFriendDeath;
    public AudioClip[] EnemyRandom;

    public AudioClip[] MKill;
    public AudioClip[] MHurt;
    public AudioClip[] MCheckpoint;
    public AudioClip[] MAbilities;

    public AudioClip[] RKill;
    public AudioClip[] RHurt;
    public AudioClip[] RCheckpoint;
    public AudioClip[] RAbilities;

    public AudioClip[] JerryHurt;
    public AudioClip[] JerryKill;
    public AudioClip[] JerryAbility;
    public AudioClip[] JerryGun;
    public AudioClip[] JerryReloading;

    public AudioClip[] SummerHurt;
    public AudioClip[] SummerKill;
    public AudioClip[] SummerAbility;
    public AudioClip[] SummerGunsmall;
    public AudioClip[] SummerGunbig;

    public AudioClip[] BethHurt;
    public AudioClip[] BethHit;
    public AudioClip[] BethKill;

    public AudioClip[] otherSounds;

    public AudioClip[] Explosion;

    public int Rando, Rando2;
    public int Other;
    public float Timer;
    public bool Etalk;

    public bool soundDone;
    void Awake()
    {
        Timer = Random.Range(10, 30);
        soundDone = true;
        _as = GetComponent<AudioSource>();

        _Other = GetComponent<AudioSource>();

        StartCoroutine(waiter1());
        IEnumerator waiter1()
        {
            yield return new WaitForSeconds(Timer);
            ERandom();
        }

    }

    public void RickChangeSound()
    {
        _as.clip = RickChange[Random.Range(0, RickChange.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void MortyChange1Sound()
    {
        _as.clip = MortyChange1[Random.Range(0, MortyChange1.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void MortyChange2Sound()
    {
        _as.clip = MortyChange2[Random.Range(0, MortyChange2.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void MortyDeathSound()
    {
        _as.clip = MortyDeath[Random.Range(0, MortyDeath.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void RickDeathSound()
    {
        _as.clip = RickDeath[Random.Range(0, RickDeath.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void MortyHurtSound()
    {
        _as.clip = MortyHurt[Random.Range(0, MortyHurt.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void RickHurtSound()
    {
        _as.clip = RickHurt[Random.Range(0, RickHurt.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void RShoot()
    {
        _as.clip = RGun[Random.Range(0, RGun.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void MShoot()
    {
        _as.clip = MGun[Random.Range(0, MGun.Length)];
        _as.PlayOneShot(_as.clip);
    }
    public void Killing()
    {
        if (Rando == 3)
        {
            if (!_as.isPlaying)
            {
                if (Globals.Character == "Rick And Morty")
                {
                    if (_ChangingCharacter.charSelect == 0 && !_WalkMinjured.MDead)
                    {
                        _as.clip = RKill[Random.Range(0, RKill.Length)];
                        _as.PlayOneShot(_as.clip);
                    }
                    else if (_ChangingCharacter.charSelect == 1 && !_WalkRinjured.RDead)
                    {
                        _as.clip = MKill[Random.Range(0, MKill.Length)];
                        _as.PlayOneShot(_as.clip);
                    }
                }
                else if (Globals.Character == "Summer")
                {
                    _as.clip = SummerKill[Random.Range(0, SummerKill.Length)];
                    _as.PlayOneShot(_as.clip);
                }
                else if (Globals.Character == "Jerry")
                {
                    _as.clip = JerryKill[Random.Range(0, JerryKill.Length)];
                    _as.PlayOneShot(_as.clip);
                }
                else if (Globals.Character == "Beth")
                {
                    _as.clip = BethKill[Random.Range(0, BethKill.Length)];
                    _as.PlayOneShot(_as.clip);
                }
            }
        }
    }
    public void Hurting()
    {
        if (Rando == 1)
        {
            if (!_as.isPlaying)
            {
                if (Globals.Character == "Rick And Morty")
                {
                    if (_ChangingCharacter.charSelect == 0 && !_WalkMinjured.MDead)
                    {
                        _as.clip = RHurt[Random.Range(0, RHurt.Length)];
                        _as.PlayOneShot(_as.clip);
                    }
                    else if (_ChangingCharacter.charSelect == 1 && !_WalkRinjured.RDead)
                    {
                        _as.clip = MHurt[Random.Range(0, MHurt.Length)];
                        _as.PlayOneShot(_as.clip);
                    }
                }
                else if (Globals.Character == "Beth")
                {

                    _as.clip = BethHit[Random.Range(0, BethHit.Length)];
                    _as.PlayOneShot(_as.clip);

                }
            }
        }
    }
    public void Checkpoint()
    {
        if (Rando == 6)
        {
            if (!_as.isPlaying)
            {
                if (Globals.Character == "Rick And Morty")
                {
                    if (_ChangingCharacter.charSelect == 0 && !_WalkMinjured.MDead)
                    {
                        _as.clip = RCheckpoint[Random.Range(0, RCheckpoint.Length)];
                        _as.PlayOneShot(_as.clip);
                    }
                    else if (_ChangingCharacter.charSelect == 1 && !_WalkRinjured.RDead)
                    {
                        _as.clip = MCheckpoint[Random.Range(0, MCheckpoint.Length)];
                        _as.PlayOneShot(_as.clip);
                    }
                }
            }
        }
    }
    public void Abilities()
    {
        if (Rando == 2)
        {
            if (_as.isPlaying)
            {
                if (Globals.Character == "Rick And Morty")
                {
                    if (_ChangingCharacter.charSelect == 0 && !_WalkMinjured.MDead)
                    {
                        _as.clip = RAbilities[Random.Range(0, RAbilities.Length)];
                        _as.PlayOneShot(_as.clip);
                    }
                    else if (_ChangingCharacter.charSelect == 1 && !_WalkRinjured.RDead)
                    {
                        _as.clip = MAbilities[Random.Range(0, MAbilities.Length)];
                        _as.PlayOneShot(_as.clip);
                    }
                }
                else if (Globals.Character == "Summer")
                {
                    _as.clip = SummerAbility[Random.Range(0, SummerAbility.Length)];
                    _as.PlayOneShot(_as.clip);
                }
                else if (Globals.Character == "Jerry")
                {
                    _as.clip = JerryAbility[Random.Range(0, JerryAbility.Length)];
                    _as.PlayOneShot(_as.clip);
                }
            }
        }
    }

    public void JerryHurtSound()
    {
        _as.clip = JerryHurt[Random.Range(0, JerryHurt.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void JerryShoot()
    {
        _as.clip = JerryGun[Random.Range(0, JerryGun.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void JerryReload()
    {
        _as.clip = JerryReloading[Random.Range(0, JerryReloading.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void SummerHurtSound()
    {
        _as.clip = SummerHurt[Random.Range(0, SummerHurt.Length)];
        _as.PlayOneShot(_as.clip);
    }

    public void SummerShoot()
    {
        if (_gunscriptS.shotDamage <= 50)
        {
            _as.clip = SummerGunsmall[Random.Range(0, SummerGunsmall.Length)];
            _as.PlayOneShot(_as.clip);
        }
        else if (_gunscriptS.shotDamage > 50)
        {
            _as.clip = SummerGunbig[Random.Range(0, SummerGunbig.Length)];
            _as.PlayOneShot(_as.clip);
        }
    }

    public void BethHurtSound()
    {
        _as.clip = BethHurt[Random.Range(0, BethHurt.Length)];
        _as.PlayOneShot(_as.clip);
    }


    public void EDeath()
    {
        if (Rando2 == 3)
        {
            Etalk = true;
            _as.clip = EnemyDeath[Random.Range(0, EnemyDeath.Length)];
            _as.PlayOneShot(_as.clip);
            if (!_as.isPlaying)
            {
                Etalk = false;
            }
        }
    }

    public void EHit()
    {
        if (Rando2 == 5)
        {
            Etalk = true;
            _as.clip = EnemyHit[Random.Range(0, EnemyHit.Length)];
            _as.PlayOneShot(_as.clip);
            if (!_as.isPlaying)
            {
                Etalk = false;
            }
        }
    }

    public void EFriendHit()
    {
        if (Rando2 == 2)
        {
            Etalk = true;
            _as.clip = EFriendDeath[Random.Range(0, EFriendDeath.Length)];
            _as.PlayOneShot(_as.clip);
            if (!_as.isPlaying)
            {
                Etalk = false;
            }
        }
    }

    public void ERandom()
    {
        if (_EnemySummoning.enemiesSummoned >= 1 && !Etalk)
        {
            StartCoroutine(waiter1());
            IEnumerator waiter1()
            {
                yield return new WaitForSeconds(Timer);
                ERandom();
            }
            Timer = Random.Range(10, 30);
            _as.clip = EnemyRandom[Random.Range(0, EnemyRandom.Length)];
            _as.PlayOneShot(_as.clip);
        }
    }


    public void ExplosionSound()
    {
        _as.clip = Explosion[Random.Range(0, Explosion.Length)];
        _as.PlayOneShot(_as.clip);
    }
    void Update()
    {
        Rando2 = Random.Range(1, 25);
        Rando = Random.Range(1, 25);

        //other sounds
        //PortalOpen
        if (Other == 1)
        {
            soundDone = false;
            Other = 0;
            _Other.clip = otherSounds[0];
            _Other.PlayOneShot(_Other.clip);
            soundDone = true;
        }
        //PortalClose
        else if (Other == 2)
        {
            soundDone = false;
            Other = 0;
            _Other.clip = otherSounds[1];
            _Other.PlayOneShot(_Other.clip);
            soundDone = true;
        }
        //Button
        else if (Other == 3)
        {
            Other = 0;
            _Other.clip = otherSounds[2];
            _Other.PlayOneShot(_Other.clip);
        }
        //Healthpack
        else if (Other == 4)
        {
            Other = 0;
            _Other.clip = otherSounds[3];
            _Other.PlayOneShot(_Other.clip);
        }
        //RReload
        else if (Other == 5)
        {
            Other = 0;
            _Other.clip = otherSounds[4];
            _Other.PlayOneShot(_Other.clip); 
        }
        //MMreload
        else if (Other == 6)
        {
            Other = 0;
            _Other.clip = otherSounds[5];
            _Other.PlayOneShot(_Other.clip); 
        }
        //victory
        else if (Other == 7)
        {
            Other = 0;
            _Other.clip = otherSounds[6];
            _Other.PlayOneShot(_Other.clip);
        }
        //lose
        else if (Other == 8)
        {
            Other = 0;
            _Other.clip = otherSounds[7];
            _Other.PlayOneShot(_Other.clip);
        }
        //eat
        else if (Other == 9)
        {
            Other = 0;
            _Other.clip = otherSounds[8];
            _Other.PlayOneShot(_Other.clip);
        }
        //belt
        else if (Other == 10)
        {
            Other = 0;
            _Other.clip = otherSounds[9];
            _Other.PlayOneShot(_Other.clip);
        }
        //dash
        else if (Other == 11)
        {
            Other = 0;
            _Other.clip = otherSounds[10];
            _Other.PlayOneShot(_Other.clip);
        }
    }
}
