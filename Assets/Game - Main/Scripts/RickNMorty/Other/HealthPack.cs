using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public ChangingCharacter _ChangingCharacter;
    public HealthRick _HealthRick;
    public HealthMorty _HealthMorty;
    public HealthSummer _HealthSummer;
    public HealthJerry _HealthJerry;
    public HealthBeth _HealthBeth;
    public RandomSounds _RandomSounds;
    public HPSpawn _HPSpawn;
    public AppearDisappear _AorD;

    public HealthBar healthBarRick;
    public HealthBar healthBarMorty;
    public HealthBar healthBarSummer;
    public HealthBar healthBarJerry;
    public HealthBar healthBarBeth;
    public GameObject HealthPacks;

    public bool HPack;

    void Start()
    {
        HPack = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!HPack)
            {
                if (Globals.Character == "Rick And Morty")
                {
                    if ((_ChangingCharacter.charSelect == 0) && (_HealthRick.currentHealth < 200))
                    {
                        if (!Globals.isGameFinished)
                        {
                            _AorD.actualScore = UnityEngine.Random.Range(30, 40);
                            _AorD.displayScore.text = _AorD.actualScore.ToString();
                            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                            _AorD.ScoreA();
                        }
                        HPack = true;
                        _HPSpawn.HPackSummoned--;
                        GainHealthR(Random.Range(20, 40));
                        _RandomSounds.Other = 4;
                        Destroy(this.gameObject);
                        HPack = false;

                    }
                    else if ((_ChangingCharacter.charSelect == 1) && (_HealthMorty.currentHealth < 150))
                    {
                        if (!Globals.isGameFinished)
                        {
                            _AorD.actualScore = UnityEngine.Random.Range(30, 40);
                            _AorD.displayScore.text = _AorD.actualScore.ToString();
                            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                            _AorD.ScoreA();
                        }
                        HPack = true;
                        _HPSpawn.HPackSummoned--;
                        GainHealthM(Random.Range(20, 40));
                        _RandomSounds.Other = 4;
                        Destroy(this.gameObject);
                        HPack = false;
                    }
                }else if (Globals.Character == "Summer")
                {
                    if (_HealthSummer.currentHealth < 175)
                    {
                        if (!Globals.isGameFinished)
                        {
                            _AorD.actualScore = UnityEngine.Random.Range(30, 40);
                            _AorD.displayScore.text = _AorD.actualScore.ToString();
                            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                            _AorD.ScoreA();
                        }
                        HPack = true;
                        _HPSpawn.HPackSummoned--;
                        GainHealthS(Random.Range(20, 40));
                        _RandomSounds.Other = 4;
                        Destroy(this.gameObject);
                        HPack = false;

                    }
                }
                else if (Globals.Character == "Jerry")
                {
                    if (_HealthJerry.currentHealth < 150)
                    {
                        if (!Globals.isGameFinished)
                        {
                            _AorD.actualScore = UnityEngine.Random.Range(30, 40);
                            _AorD.displayScore.text = _AorD.actualScore.ToString();
                            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                            _AorD.ScoreA();
                        }
                        HPack = true;
                        _HPSpawn.HPackSummoned--;
                        GainHealthJ(Random.Range(20, 40));
                        _RandomSounds.Other = 4;
                        Destroy(this.gameObject);
                        HPack = false;

                    }
                }

                else if (Globals.Character == "Beth")
                {
                    if (_HealthBeth.currentHealth < 200)
                    {
                        if (!Globals.isGameFinished)
                        {
                            _AorD.actualScore = UnityEngine.Random.Range(30, 40);
                            _AorD.displayScore.text = _AorD.actualScore.ToString();
                            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
                            _AorD.ScoreA();
                        }
                        HPack = true;
                        _HPSpawn.HPackSummoned--;
                        GainHealthB(Random.Range(20, 40));
                        _RandomSounds.Other = 4;
                        Destroy(this.gameObject);
                        HPack = false;

                    }
                }
            }
        }
    }

    void GainHealthR(int health)
    {
        _HealthRick.currentHealth += health;
        _HealthRick.HealthR.text = _HealthRick.currentHealth.ToString();

        healthBarRick.SetHealth(_HealthRick.currentHealth);
    }
    void GainHealthM(int health)
    {
        _HealthMorty.currentHealth += health;
        _HealthMorty.HealthM.text = _HealthMorty.currentHealth.ToString();

        healthBarMorty.SetHealth(_HealthMorty.currentHealth);
    }

    void GainHealthS(int health)
    {
        _HealthSummer.currentHealth += health;
        _HealthSummer.HealthS.text = _HealthSummer.currentHealth.ToString();

        healthBarSummer.SetHealth(_HealthSummer.currentHealth);
    }

    void GainHealthJ(int health)
    {
        _HealthJerry.currentHealth += health;
        _HealthJerry.HealthJ.text = _HealthJerry.currentHealth.ToString();

        healthBarJerry.SetHealth(_HealthJerry.currentHealth);
    }

    void GainHealthB(int health)
    {
        _HealthBeth.currentHealth += health;
        _HealthBeth.HealthB.text = _HealthBeth.currentHealth.ToString();

        healthBarBeth.SetHealth(_HealthBeth.currentHealth);
    }
}
