using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class AppearDisappear : MonoBehaviour
{

    public AbilitiesMain _AbilitiesMain;
    public RandomSounds _RandomSounds;
    public HealthMorty _HealthMorty;
    public HealthRick _HealthRick;
    public HealthSummer _HealthSummer;
    public HealthJerry _HealthJerry;
    public HealthBeth _HealthBeth;
    public AbilitiesMainJ _AbilitiesMainJ;
    public AbilitiesMainB _AbilitiesMainB;
    public AbilitiesMainS _AbilitiesMainS;
    public SceneChange1 _SceneChange1;
    public ChangingCharacter _ChangingCharacter;

    public GameObject ChangePortal, DeathPortal, HealthBarRick, HealthBarMorty, MAmmo, RAmmo, Crosshair, RDrinkButton, RTButton, LMC, RMC, PortalT, PGun,
        MPotionButton, Flask, RGun, GSlide, MGun, Scores, SGun, JGun, BGun;

    public TMPro.TextMeshProUGUI displayScore;
    public int actualScore;

    public Camera camFirstR, camHandsR, camThird, camFirstM, camHandsM, camFirstS, camHandsS, camFirstJ, camHandsJ, camFirstB, camHandsB;
    public Image ChangeButton;
    public Sprite MortyFace, RickFace;

    public Vignette vignetteLayer1, vignetteLayer2, vignetteLayer3;
    public PostProcessVolume volume1, volume2, volume3;

    void Start()
    {
        Scores.SetActive(false);
        Time.timeScale = 1;
        volume1.profile.TryGetSettings(out vignetteLayer1);
        Crosshair.SetActive(true);

        if (Globals.Character == "Rick And Morty")
        {
            camFirstR.enabled = true;
            camHandsR.enabled = true;

            ChangePortal.SetActive(false);
            DeathPortal.SetActive(false);
            HealthBarRick.SetActive(true);
            HealthBarMorty.SetActive(false);
            Flask.gameObject.GetComponent<Renderer>().enabled = false;

            camThird.enabled = false;

            GameObject.Find("Body.001").gameObject.GetComponent<Renderer>().enabled = true;
            RGun.gameObject.GetComponent<Renderer>().enabled = true;
            RGun.gameObject.GetComponent<gunscriptR>().enabled = true;

            camFirstM.enabled = false;
            camHandsM.enabled = false;
            GameObject.Find("rdmobj00").gameObject.GetComponent<Renderer>().enabled = false;
            MGun.gameObject.GetComponent<Renderer>().enabled = false;
            MGun.gameObject.GetComponent<gunscriptM>().enabled = false;

            GameObject.Find("FirstPersonRick Camera").gameObject.GetComponent<MouseLook>().enabled = true;
            GameObject.Find("FirstPersonMorty Camera").gameObject.GetComponent<MouseLook>().enabled = false;

            GameObject.Find("Characters").GetComponent<WalkingM>().enabled = true;
            GameObject.Find("Characters").GetComponent<WalkingR>().enabled = true;
            GameObject.Find("Characters").GetComponent<HealthMorty>().enabled = true;
            GameObject.Find("Characters").GetComponent<HealthRick>().enabled = true;

            MAmmo.SetActive(false);
            RDrinkButton.SetActive(true);
            RTButton.SetActive(true);
            LMC.SetActive(false);
            RMC.SetActive(false);
            PortalT.SetActive(false);
            PGun.SetActive(false);
            MPotionButton.SetActive(false);

            ChangeButton.sprite = MortyFace;
        }else if (Globals.Character == "Summer")
        {
            
            GameObject.Find("Characters").GetComponent<WalkingS>().enabled = true;
            GameObject.Find("Characters").GetComponent<HealthSummer>().enabled = true;
        }
    }

    void Update()
    {
        if (_SceneChange1.Scene == 1)
        {
            volume1.profile.TryGetSettings(out vignetteLayer1);
            if (Globals.Character == "Rick And Morty")
            {
                if (_ChangingCharacter.charSelect == 0)
                {
                    if (_HealthRick.currentHealth <= 66)
                    {
                        vignetteLayer1.color.value = Color.red;
                        vignetteLayer1.intensity.value = 0.5f;
                    }
                    else if (_HealthRick.currentHealth > 66 && !_AbilitiesMain.Drinking)
                    {
                        vignetteLayer1.color.value = Color.black;
                        vignetteLayer1.intensity.value = 0.339f;
                    }
                }
                else if (_ChangingCharacter.charSelect == 1)
                {
                    if (_HealthMorty.currentHealth <= 50)
                    {
                        vignetteLayer1.color.value = Color.red;
                        vignetteLayer1.intensity.value = 0.5f;
                    }
                    else if (_HealthMorty.currentHealth > 50 && !_AbilitiesMain.Drinking)
                    {
                        vignetteLayer1.color.value = Color.black;
                        vignetteLayer1.intensity.value = 0.339f;
                    }
                }
            }
            else if (Globals.Character == "Summer")
            {
                if (_HealthSummer.currentHealth <= 50)
                {
                    vignetteLayer1.color.value = Color.red;
                    vignetteLayer1.intensity.value = 0.5f;
                }
                else if (_HealthSummer.currentHealth > 50 && !_AbilitiesMainS.draining)
                {
                    vignetteLayer1.color.value = Color.black;
                    vignetteLayer1.intensity.value = 0.339f;
                }
            }
            else if (Globals.Character == "Jerry")
            {
                if (_HealthJerry.currentHealth <= 50)
                {
                    vignetteLayer1.color.value = Color.red;
                    vignetteLayer1.intensity.value = 0.5f;
                }
                else if (_HealthJerry.currentHealth > 50 && !_AbilitiesMainJ.Healing && !_AbilitiesMainJ.invis)
                {
                    vignetteLayer1.color.value = Color.black;
                    vignetteLayer1.intensity.value = 0.339f;
                }
            }
            else if (Globals.Character == "Beth")
            {
                if (_HealthBeth.currentHealth <= 50)
                {
                    vignetteLayer1.color.value = Color.red;
                    vignetteLayer1.intensity.value = 0.5f;
                }
                else if (_HealthBeth.currentHealth > 50 && !_AbilitiesMainB.Healing && !_AbilitiesMainB.Dash)
                {
                    vignetteLayer1.color.value = Color.black;
                    vignetteLayer1.intensity.value = 0.339f;
                }
            }
        }
        else if (_SceneChange1.Scene == 2)
        {
            volume2.profile.TryGetSettings(out vignetteLayer2);
            if (Globals.Character == "Rick And Morty")
            {
                if (_ChangingCharacter.charSelect == 0)
                {
                    if (_HealthRick.currentHealth <= 66)
                    {
                        vignetteLayer2.color.value = Color.red;
                        vignetteLayer2.intensity.value = 0.5f;
                    }
                    else if (_HealthRick.currentHealth > 66 && !_AbilitiesMain.Drinking)
                    {
                        vignetteLayer2.color.value = Color.black;
                        vignetteLayer2.intensity.value = 0.339f;
                    }
                }

                if (_ChangingCharacter.charSelect == 1)
                {
                    if (_HealthMorty.currentHealth <= 50)
                    {
                        vignetteLayer2.color.value = Color.red;
                        vignetteLayer2.intensity.value = 0.5f;
                    }
                    else if (_HealthMorty.currentHealth > 50 && !_AbilitiesMain.Drinking)
                    {
                        vignetteLayer2.color.value = Color.black;
                        vignetteLayer2.intensity.value = 0.339f;
                    }
                }
            }else if (Globals.Character == "Summer")
            {
                if (_HealthSummer.currentHealth <= 50)
                {
                    vignetteLayer2.color.value = Color.red;
                    vignetteLayer2.intensity.value = 0.5f;
                }
                else if (_HealthSummer.currentHealth > 50 && !_AbilitiesMainS.draining)
                {
                    vignetteLayer2.color.value = Color.black;
                    vignetteLayer2.intensity.value = 0.339f;
                }
            }
            else if (Globals.Character == "Jerry")
            {
                if (_HealthJerry.currentHealth <= 50)
                {
                    vignetteLayer2.color.value = Color.red;
                    vignetteLayer2.intensity.value = 0.5f;
                }
                else if (_HealthJerry.currentHealth > 50 && !_AbilitiesMainJ.Healing && !_AbilitiesMainJ.invis)
                {
                    vignetteLayer2.color.value = Color.black;
                    vignetteLayer2.intensity.value = 0.339f;
                }
            }
            else if (Globals.Character == "Beth")
            {
                if (_HealthBeth.currentHealth <= 50)
                {
                    vignetteLayer2.color.value = Color.red;
                    vignetteLayer2.intensity.value = 0.5f;
                }
                else if (_HealthBeth.currentHealth > 50 && !_AbilitiesMainB.Healing && !_AbilitiesMainB.Dash)
                {
                    vignetteLayer2.color.value = Color.black;
                    vignetteLayer2.intensity.value = 0.339f;
                }
            }
        }
        else if (_SceneChange1.Scene == 3)
        {
            volume3.profile.TryGetSettings(out vignetteLayer3);
            if (Globals.Character == "Rick And Morty")
            {
                if (_ChangingCharacter.charSelect == 0)
                {
                    if (_HealthRick.currentHealth <= 66)
                    {
                        vignetteLayer3.color.value = Color.red;
                        vignetteLayer3.intensity.value = 0.5f;
                    }
                    else if (_HealthRick.currentHealth > 66 && !_AbilitiesMain.Drinking)
                    {
                        vignetteLayer3.color.value = Color.black;
                        vignetteLayer3.intensity.value = 0.339f;
                    }
                }

                if (_ChangingCharacter.charSelect == 1)
                {
                    if (_HealthMorty.currentHealth <= 50)
                    {
                        vignetteLayer3.color.value = Color.red;
                        vignetteLayer3.intensity.value = 0.5f;
                    }
                    else if (_HealthMorty.currentHealth > 50 && !_AbilitiesMain.Drinking)
                    {
                        vignetteLayer3.color.value = Color.black;
                        vignetteLayer3.intensity.value = 0.339f;
                    }
                }
            }
            else if (Globals.Character == "Summer")
            {
                if (_HealthSummer.currentHealth <= 50)
                {
                    vignetteLayer3.color.value = Color.red;
                    vignetteLayer3.intensity.value = 0.5f;
                }
                else if (_HealthSummer.currentHealth > 50 && !_AbilitiesMainS.draining)
                {
                    vignetteLayer3.color.value = Color.black;
                    vignetteLayer3.intensity.value = 0.339f;
                }
            }
            else if (Globals.Character == "Jerry")
            {
                if (_HealthJerry.currentHealth <= 50)
                {
                    vignetteLayer3.color.value = Color.red;
                    vignetteLayer3.intensity.value = 0.5f;
                }
                else if (_HealthJerry.currentHealth > 50 && !_AbilitiesMainJ.Healing && !_AbilitiesMainJ.invis)
                {
                    vignetteLayer3.color.value = Color.black;
                    vignetteLayer3.intensity.value = 0.339f;
                }
            }
            else if (Globals.Character == "Beth")
            {
                if (_HealthBeth.currentHealth <= 50)
                {
                    vignetteLayer3.color.value = Color.red;
                    vignetteLayer3.intensity.value = 0.5f;
                }
                else if (_HealthBeth.currentHealth > 50 && !_AbilitiesMainB.Healing && !_AbilitiesMainB.Dash)
                {
                    vignetteLayer3.color.value = Color.black;
                    vignetteLayer3.intensity.value = 0.339f;
                }
            }
        }
      
    }

    public void ScoreA()
    {
        StartCoroutine(Appear());
        IEnumerator Appear()
        {
            Scores.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            Scores.SetActive(false);
        }

    }
    //Portal Disappearing Change
    public void PortalDChange()
    {
        _RandomSounds.Other = 2;
        ChangePortal.SetActive(false);
    }

    //Portal Appearing Change
    public void PortalAChange()
    {

        ChangePortal.SetActive(true);
        _RandomSounds.Other = 1;
    }

    //Portal Disappearing Death
    public void PortalDDeath()
    {
        _RandomSounds.Other = 2;
        DeathPortal.SetActive(false);
    }

    //Portal Appearing Death
    public void PortalADeath()
    {

        _RandomSounds.Other = 1;
        DeathPortal.SetActive(true);
        
    }

    public void PGunA()
    {
        PGun.SetActive(true);
    }

    public void PGunD()
    {
        PGun.SetActive(false);
    }

    public void mortyCam()
    {
        camThird.enabled = false;

        camFirstR.enabled = false;
        camHandsR.enabled = false;
        GameObject.Find("Body.001").gameObject.GetComponent<Renderer>().enabled = false;
        RGun.gameObject.GetComponent<Renderer>().enabled = false;

        camFirstM.enabled = true;
        camHandsM.enabled = true;
        GameObject.Find("rdmobj00").gameObject.GetComponent<Renderer>().enabled = true;
        MGun.gameObject.GetComponent<Renderer>().enabled = true;

        RGun.gameObject.GetComponent<gunscriptR>().enabled = false;
        MGun.gameObject.GetComponent<gunscriptM>().enabled = true;
        camFirstR.gameObject.GetComponent<MouseLook>().enabled = false;
        camFirstM.gameObject.GetComponent<MouseLook>().enabled = true;

        GameObject.Find("Characters").GetComponent<WalkingR>().enabled = true;
        GameObject.Find("Characters").GetComponent<WalkingM>().enabled = true;
        GameObject.Find("Characters").GetComponent<HealthMorty>().enabled = true;
        GameObject.Find("Characters").GetComponent<HealthRick>().enabled = true;

        Crosshair.SetActive(true);
        HealthBarRick.SetActive(false);
        RAmmo.SetActive(false);
        HealthBarMorty.SetActive(true);
        MAmmo.SetActive(true);
        ChangeButton.sprite = RickFace;
        RDrinkButton.SetActive(false);
        RTButton.SetActive(false);
        MPotionButton.SetActive(true);
    }

    public void rickCam()
    {
        camThird.enabled = false;

        camFirstM.enabled = false;
        camHandsM.enabled = false;
        GameObject.Find("rdmobj00").gameObject.GetComponent<Renderer>().enabled = false;
        MGun.gameObject.GetComponent<Renderer>().enabled = false;

        camFirstR.enabled = true;
        camHandsR.enabled = true;
        GameObject.Find("Body.001").gameObject.GetComponent<Renderer>().enabled = true;
        RGun.gameObject.GetComponent<Renderer>().enabled = true;

        RGun.gameObject.GetComponent<gunscriptR>().enabled = true;
        MGun.gameObject.GetComponent<gunscriptM>().enabled = false;
        camFirstR.gameObject.GetComponent<MouseLook>().enabled = true;
        camFirstM.gameObject.GetComponent<MouseLook>().enabled = false;

        GameObject.Find("Characters").GetComponent<WalkingR>().enabled = true;
        GameObject.Find("Characters").GetComponent<WalkingM>().enabled = true;
        GameObject.Find("Characters").GetComponent<HealthMorty>().enabled = true;
        GameObject.Find("Characters").GetComponent<HealthRick>().enabled = true;

        Crosshair.SetActive(true);
        HealthBarRick.SetActive(true);
        RAmmo.SetActive(true);
        HealthBarMorty.SetActive(false);
        MAmmo.SetActive(false);
        ChangeButton.sprite = MortyFace;
        RDrinkButton.SetActive(true);
        RTButton.SetActive(true);
        MPotionButton.SetActive(false);
    }

    public void thirdCam()
    {
        volume1.profile.TryGetSettings(out vignetteLayer1);
        vignetteLayer1.color.value = Color.black;
        vignetteLayer1.intensity.value = 0.339f;
        volume2.profile.TryGetSettings(out vignetteLayer2);
        vignetteLayer2.color.value = Color.black;
        vignetteLayer2.intensity.value = 0.339f;
        volume3.profile.TryGetSettings(out vignetteLayer3);
        vignetteLayer3.color.value = Color.black;
        vignetteLayer3.intensity.value = 0.339f;
        if (Globals.Character == "Rick And Morty")
        {
            camThird.enabled = true;
            camFirstR.enabled = false;
            camHandsR.enabled = false;
            camHandsM.enabled = false;
            camFirstM.enabled = false;
            Crosshair.SetActive(false);

            RGun.gameObject.GetComponent<gunscriptR>().enabled = false;
            MGun.gameObject.GetComponent<gunscriptM>().enabled = false;
            camFirstR.gameObject.GetComponent<MouseLook>().enabled = false;
            camFirstM.gameObject.GetComponent<MouseLook>().enabled = false;

            GameObject.Find("Characters").GetComponent<WalkingM>().enabled = false;
            GameObject.Find("Characters").GetComponent<WalkingR>().enabled = false;
            GameObject.Find("Characters").GetComponent<HealthMorty>().enabled = false;
            GameObject.Find("Characters").GetComponent<HealthRick>().enabled = false;
        }else if (Globals.Character == "Summer")
        {
            camThird.enabled = true;
            camFirstS.enabled = false;
            camHandsS.enabled = false;
            Crosshair.SetActive(false);

            GameObject.Find("SummerGunMain").gameObject.GetComponent<gunscriptS>().enabled = false;
            camFirstS.gameObject.GetComponent<MouseLook>().enabled = false;

            GameObject.Find("Characters").GetComponent<WalkingS>().enabled = false;
            GameObject.Find("Characters").GetComponent<HealthSummer>().enabled = false;
        }
        else if (Globals.Character == "Jerry")
        {
            camThird.enabled = true;
            camFirstJ.enabled = false;
            camHandsJ.enabled = false;
            Crosshair.SetActive(false);

            JGun.gameObject.GetComponent<gunscriptJ>().enabled = false;
            camFirstJ.gameObject.GetComponent<MouseLook>().enabled = false;

            GameObject.Find("Characters").GetComponent<WalkingJ>().enabled = false;
            GameObject.Find("Characters").GetComponent<HealthJerry>().enabled = false;
        }
        else if (Globals.Character == "Beth")
        {
            camThird.enabled = true;
            camFirstB.enabled = false;
            camHandsB.enabled = false;
            Crosshair.SetActive(false);

            BGun.gameObject.GetComponent<gunscriptB>().enabled = false;
            camFirstB.gameObject.GetComponent<MouseLook>().enabled = false;

            GameObject.Find("Characters").GetComponent<WalkingB>().enabled = false;
            GameObject.Find("Characters").GetComponent<HealthBeth>().enabled = false;
        }

    }

    public void TeleportingA()
    {
        RMC.SetActive(true);
        LMC.SetActive(true);
        PortalT.SetActive(true);
    }

    public void TeleportingD()
    {
        RMC.SetActive(false);
        LMC.SetActive(false);
        PortalT.SetActive(false);
        }

    public void RDrinkingA()
    {
        Flask.gameObject.GetComponent<Renderer>().enabled = true;
        RGun.gameObject.GetComponent<Renderer>().enabled = false;
        GSlide.gameObject.GetComponent<Renderer>().enabled = false;
        RGun.gameObject.GetComponent<gunscriptR>().enabled = false;
    }

    public void RDrinkingD()
    {
        Flask.gameObject.GetComponent<Renderer>().enabled = false;
        RGun.gameObject.GetComponent<Renderer>().enabled = true;
        GSlide.gameObject.GetComponent<Renderer>().enabled = true;
        RGun.gameObject.GetComponent<gunscriptR>().enabled = true;
    }
}
