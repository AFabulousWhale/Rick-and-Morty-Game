using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WalkRInjured : MonoBehaviour
{
    GameObject Rick, Morty, CrossFade;
    Button MortyButt;

    public HealthRick _HealthRick;
    public WalkingR _WalkingR;
    public AppearDisappear _AorD;
    public RandomSounds _RandomSounds;
    public ChangingCharacter _ChangingCharacter;
    public WalkMInjured _WalkMInjured;

    public Image ChangeButton;

    public Camera camFirstR, camHandsR;

    public bool RDead;
    public bool BDeath;

    public bool RDying;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        Rick = GameObject.Find("Rick");
        Morty = GameObject.Find("Morty");
        MortyButt = gameObject.GetComponent<Button>();
        RDead = false;
        BDeath = false;

        RDying = false;

        setColliderState(false);
        setRigidbodyState(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K) && _ChangingCharacter.charSelect == 0)
        {
            _HealthRick.currentHealth = 0;
        }

        if ((_HealthRick.currentHealth < 50) && (_HealthRick.currentHealth > 0))
        {
            _WalkingR.walkSpeed = 40f;
            _WalkingR.runSpeed = 50f;

        }
        else if ((_HealthRick.currentHealth >= 50))
        {
            _WalkingR.walkSpeed = 80f;
            _WalkingR.runSpeed = 200f;
        }

        if ((_HealthRick.currentHealth == 0) && (RDead == false))
        {
            RDying = true;
            RickDie();
        }
    }

    void RickDie()
    {
        GameObject.Find("RickModel").gameObject.GetComponent<Renderer>().enabled = true;
        GameObject.Find("Rick").gameObject.transform.parent = GameObject.Find("RNMNewParents").transform;
        _AorD.thirdCam();
        RDead = true;
        GetComponent<WalkingR>().enabled = false;
        GetComponent<WalkingM>().enabled = false;
        anim = GameObject.Find("Rick").gameObject.GetComponent<Animator>();
        anim.enabled = false;
        setColliderState(true);
        setRigidbodyState(false);
        _RandomSounds.RickDeathSound();
        StartCoroutine(Death());
        IEnumerator Death()
        {
            yield return new WaitForSeconds(3);
            GetComponent<WalkingM>().enabled = true;
            GetComponent<WalkingR>().enabled = true;
            _ChangingCharacter.charSelect = 1;
            ChangeButton.GetComponent<Image>().color = new Color32(207, 056, 070, 255);
            if ((RDead == true) && (_WalkMInjured.MDead == true))
            {
                SceneManager.LoadScene("Game Over");
            }
            else
            {
                _AorD.mortyCam();
                RDying = false;
                camFirstR.enabled = false;
                camHandsR.enabled = false;
                setColliderState(false);
                setRigidbodyState(true);
            }
        }
    }

    void setRigidbodyState(bool state)
    {
        Rigidbody[] rigidbodies = GameObject.Find("Rick").gameObject.GetComponentsInChildren<Rigidbody>();
        foreach(Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }
    }

    void setColliderState(bool state)
    {
        Collider[] colliders = GameObject.Find("Rick").gameObject.GetComponentsInChildren<Collider>();
        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }
        GetComponent<Collider>().enabled = !state;
    }
}
