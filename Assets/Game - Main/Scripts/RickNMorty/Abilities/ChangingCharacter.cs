using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ChangingCharacter : MonoBehaviour
{
    public GameObject Morty, Rick;
    public Image ChangeButton, RDrinkButton;

    public int charSelect;
    public Animator anim;
    float speed = 50.0f;
 
    public RandomSounds _RandomSounds;
    public WalkRInjured _WalkRInjured;
    public WalkMInjured _WalkMInjured;
    public AppearDisappear _AorD;
    public gunscriptR _gunscriptR;
    public gunscriptM _gunscriptM;
    public AbilityCooldown _AbilityCooldown;
    public AbilitiesMain _AbilitiesMain;
    public CrouchJumpMelee _CrouchJumpMelee;

    public bool Changing;
    // Start is called before the first frame update
    void Start()
    {

        Morty = GameObject.Find("Morty");
        Rick = GameObject.Find("Rick");
        

        anim = GameObject.Find("Rick").gameObject.GetComponent<Animator>();
        anim.speed = 1.0f;
        GameObject.Find("RickModel").gameObject.GetComponent<Renderer>().enabled = false;
        GameObject.Find("MortyModel").gameObject.GetComponent<Renderer>().enabled = false;

        ChangeButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }
    void FixedUpdate()
    {
        if (!PauseMenu.GameIsPaused)
        {

            if (_CrouchJumpMelee.isJumping || _AbilityCooldown.coolDownTimerC != -1)
            {
                ChangeButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
            }
            else if (!Changing && _AbilityCooldown.coolDownTimerC == -1)
            {
                ChangeButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }

            if (_WalkMInjured.MDead || _WalkRInjured.RDead)
            {
                ChangeButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
            }

            //ChangingCharacter
            if (Input.GetButtonDown("Change") && (!Changing) && (_AbilitiesMain.Drinking == false) && (_AbilityCooldown.coolDownTimerC == -1) && _AbilitiesMain.Teleporting == false && _AbilitiesMain.Teleported == true && _AbilitiesMain.Magic == false && !_CrouchJumpMelee.isJumping)

            {

                    if ((_WalkRInjured.RDead == false) && (_WalkMInjured.MDead == false))
                    {
                    _RandomSounds.Abilities();
                    Changing = true;
                    ChangeButton.GetComponent<Image>().color = new Color32(0, 255, 1, 225);
                    _RandomSounds.Other = 3;

                        //if you are rick
                        if (charSelect == 0)
                        {
                        RickchangeStart();

                        }

                        //if you are morty
                        else if (charSelect == 1)
                        {
                        MortychangeStart();
                        }

                    }
                
            }

        }
    }

    public void RickchangeStart()
    {
        RDrinkButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
        _AbilitiesMain.RTButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
        GameObject.Find("RickModel").gameObject.GetComponent<Renderer>().enabled = true;
        _AorD.thirdCam();
        _AorD.PGunA();
        anim = GameObject.Find("Rick").gameObject.GetComponent<Animator>();
        anim.SetInteger("AnimChangeR1", 1);
        anim.speed = 2.5f;
    }

    //Portal appearing
    public void Rickchange1()
    {
        _AorD.PortalAChange();
    }

    //Gun disappearing
    public void Rickchange2()
    {
        _AorD.PGunD();
    }
        
    //Jumping into portal
    public void Rickchange3()
    {
        _RandomSounds.Other = 1;
    }
        
    //Morty appearing
    public void Rickchange4()
    {
        StartCoroutine(MortyAppear());
        IEnumerator MortyAppear()
        {
            _RandomSounds.Other = 1;
            anim.SetInteger("AnimChangeR1", 0);
            GameObject.Find("RickModel").gameObject.GetComponent<Renderer>().enabled = false;
            _AorD.HealthBarRick.SetActive(false);
            _AorD.RAmmo.SetActive(false);
            _AorD.HealthBarMorty.SetActive(true);
            _AorD.MAmmo.SetActive(true);
            _AorD.ChangeButton.sprite = _AorD.RickFace;
            _AorD.RDrinkButton.SetActive(false);
            _AorD.RTButton.SetActive(false);
            _AorD.MPotionButton.SetActive(true);
            charSelect = 1;
            anim = GameObject.Find("Morty").gameObject.GetComponent<Animator>();
            anim.speed = 2f;
            anim.Play("ChangeM");
            yield return new WaitForSeconds(0.1f);
            GameObject.Find("MortyModel").gameObject.GetComponent<Renderer>().enabled = true;
            _RandomSounds.MortyChange1Sound();
        }
    }

    //Portal disappearing
    public void Rickchange5()
    {
        _AorD.PortalDChange();
        anim.SetInteger("AnimChangeM1", 0);
    }

    //Back to morty view
    public void Rickchange6()
    {
        if (!Globals.isGameFinished)
        {
            _AorD.actualScore = UnityEngine.Random.Range(10, 25);
            _AorD.displayScore.text = _AorD.actualScore.ToString();
            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
            _AorD.ScoreA();
        }
        Changing = false;
        _AorD.mortyCam();
        _gunscriptM.currentAmmo = _gunscriptM.maxAmmo;
        _gunscriptM.AmmoLeft.text = _gunscriptM.currentAmmo.ToString();
        _AbilityCooldown.CooldownChange();
        GameObject.Find("MortyModel").gameObject.GetComponent<Renderer>().enabled = false;
        GameObject.Find("RickModel").gameObject.GetComponent<Renderer>().enabled = false;
        RDrinkButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        _AbilitiesMain.RTButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        ChangeButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }

    //Morty angry
    public void MortychangeStart()
    {
        Changing = true;
        RDrinkButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
        GameObject.Find("MortyModel").gameObject.GetComponent<Renderer>().enabled = true;
        _AorD.thirdCam();
        anim = GameObject.Find("Morty").gameObject.GetComponent<Animator>();
        anim.SetInteger("AnimChangeM2", 1);
    }

    //Rick jumping out of portal
    public void Mortychange1()
    {
        charSelect = 0;
        _RandomSounds.RickChangeSound();
        _AorD.PortalAChange();
        _AorD.HealthBarRick.SetActive(true);
        _AorD.RAmmo.SetActive(true);
        _AorD.HealthBarMorty.SetActive(false);
        _AorD.MAmmo.SetActive(false);
        ChangeButton.sprite = _AorD.MortyFace;
        _AorD.RDrinkButton.SetActive(true);
        _AorD.RTButton.SetActive(true);
        _AorD.MPotionButton.SetActive(false);
        charSelect = 0;
        GameObject.Find("RickModel").gameObject.GetComponent<Renderer>().enabled = true;
        anim = GameObject.Find("Rick").gameObject.GetComponent<Animator>();
        anim.Play("Kick Morty");
    }

    //rick aniamtions
    public void Mortychange2()
    {
        anim.SetInteger("AnimChangeR2", 1);
    }

    //Morty being kicked
    public void Mortychange3()
    {
        anim = GameObject.Find("Morty").gameObject.GetComponent<Animator>();
        anim.SetInteger("AnimChangeM2", 2);
        _RandomSounds.MortyChange2Sound();
    }

    //Morty falling into portal
    public void Mortychange4()
    {
        _RandomSounds.Other = 1;
        anim = GameObject.Find("Rick").gameObject.GetComponent<Animator>();
        anim.Play("Movement");
        _AorD.PortalDChange();
    }

    public void Mortychange5()
    {
        if (!Globals.isGameFinished)
        {
            _AorD.actualScore = UnityEngine.Random.Range(10, 25);
            _AorD.displayScore.text = _AorD.actualScore.ToString();
            Globals.overallScore = Globals.overallScore + _AorD.actualScore;
            _AorD.ScoreA();
        }
        anim.speed = 1f;
        GameObject.Find("MortyModel").gameObject.GetComponent<Renderer>().enabled = false;
        anim.SetInteger("AnimChangeR2", 2);
        Changing = false;
        _AorD.rickCam();
        _gunscriptR.currentAmmo = _gunscriptR.maxAmmo;
        _gunscriptR.AmmoLeft.text = _gunscriptR.currentAmmo.ToString();
        _AbilityCooldown.CooldownChange();
        GameObject.Find("RickModel").gameObject.GetComponent<Renderer>().enabled = false;
        GameObject.Find("MortyModel").gameObject.GetComponent<Renderer>().enabled = false;
        RDrinkButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        ChangeButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }
 
    
} 

   

