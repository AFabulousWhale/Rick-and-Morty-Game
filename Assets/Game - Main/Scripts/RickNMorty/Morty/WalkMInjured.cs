using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WalkMInjured : MonoBehaviour
{
    GameObject Morty, MortyButt;

    public HealthMorty _HealthMorty;
    public WalkingM _WalkingM;
    public AppearDisappear _AorD;
    public ChangingCharacter _ChangingCharacter;
    public RandomSounds _RandomSounds;
    public WalkRInjured _WalkRInjured;

    public Image ChangeButton;

    public Camera camFirstM, camHandsM;

    public bool MDead;

    public Animator anim;

    public bool MDying;

    // Start is called before the first frame update
    void Start()
    {
        Morty = GameObject.Find("Morty");
        MortyButt = GameObject.Find("MortyButt");
        MDead = false;
        MDying = false;

        setColliderState(false);
        setRigidbodyState(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && _ChangingCharacter.charSelect == 1)
        {
            _HealthMorty.currentHealth = 0;
        }

        if ((_HealthMorty.currentHealth < 35) && (_HealthMorty.currentHealth > 0))
        {
            _WalkingM.walkSpeed = 40f;
            _WalkingM.runSpeed = 50f;
        }
        else if ((_HealthMorty.currentHealth >= 35))
        {
            _WalkingM.walkSpeed = 80f;
            _WalkingM.runSpeed = 200f;
        }

        if ((_HealthMorty.currentHealth == 0) && (MDead == false))
        {
            MDying = true;
            MortyDie();
        }
    }

    void MortyDie()
    {
        GameObject.Find("MortyModel").gameObject.GetComponent<Renderer>().enabled = true;
        GameObject.Find("Morty").gameObject.transform.parent = GameObject.Find("RNMNewParents").transform;
        _AorD.thirdCam();
        MDead = true;
        GetComponent<WalkingR>().enabled = false;
        GetComponent<WalkingM>().enabled = false;
        anim = GameObject.Find("Morty").gameObject.GetComponent<Animator>();
        anim.enabled = false;
        setColliderState(true);
        setRigidbodyState(false);
        _RandomSounds.MortyDeathSound();
        StartCoroutine(Death());
        IEnumerator Death()
        {
            yield return new WaitForSeconds(3);
            GetComponent<WalkingM>().enabled = true;
            GetComponent<WalkingR>().enabled = true;
            _ChangingCharacter.charSelect = 0;
            ChangeButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
            if ((MDead == true) && (_WalkRInjured.RDead == true))
            {
                SceneManager.LoadScene("Game Over");
            }
            else
            {
                _AorD.rickCam();
                MDying = false;
                camFirstM.enabled = false;
                camHandsM.enabled = false;
                setColliderState(false);
                setRigidbodyState(true);
            }
        }
    }

    void setRigidbodyState(bool state)
    {
        Rigidbody[] rigidbodies = GameObject.Find("Morty").gameObject.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }
    }

    void setColliderState(bool state)
    {
        Collider[] colliders = GameObject.Find("Morty").gameObject.GetComponentsInChildren<Collider>();
        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }
        GetComponent<Collider>().enabled = !state;
    }
}
