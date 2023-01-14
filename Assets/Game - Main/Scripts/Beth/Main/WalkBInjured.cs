using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WalkBInjured : MonoBehaviour
{
    GameObject Summer;

    public HealthBeth _HealthBeth;
    public WalkingB _WalkingB;
    public AppearDisappear _AorD;
    public RandomSounds _RandomSounds;
    public AbilitiesMainB _AbilitiesMainB;

    public Camera camFirstB;

    public bool BDead;

    public bool BDying;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("BethModel").gameObject.GetComponent<Renderer>().enabled = false;
        BDead = false;
        BDying = false;

        setColliderState(false);
        setRigidbodyState(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            _HealthBeth.currentHealth = 0;
        }

        if ((_HealthBeth.currentHealth < 50) && (_HealthBeth.currentHealth > 0) && !_AbilitiesMainB.Dash)
        {
            _WalkingB.walkSpeed = 160f;
            _WalkingB.runSpeed = 50f;

        }
        else if ((_HealthBeth.currentHealth >= 50) && !_AbilitiesMainB.Dash)
        {
            _WalkingB.walkSpeed = 160f;
            _WalkingB.runSpeed = 200f;
        }

            if ((_HealthBeth.currentHealth == 0) && (BDead == false))
            {
            BDying = true;
            BethDie();
            }
    }

    void BethDie()
    {
        _AorD.thirdCam();
        GameObject.Find("BethModel").gameObject.GetComponent<Renderer>().enabled = true;
        BDead = true;
        GetComponent<WalkingB>().enabled = false;
        anim = GameObject.Find("BethMain").gameObject.GetComponent<Animator>();
        anim.enabled = false;
        setColliderState(true);
        setRigidbodyState(false);
        StartCoroutine(Death());
        IEnumerator Death()
        {
            yield return new WaitForSeconds(3);
            Destroy(GameObject.Find("BethModel"));
            GetComponent<WalkingB>().enabled = true;
            SceneManager.LoadScene("Game Over");
        }
    }

    void setRigidbodyState(bool state)
    {
        Rigidbody[] rigidbodies = GameObject.Find("BethMain").gameObject.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }
    }

    void setColliderState(bool state)
    {
        Collider[] colliders = GameObject.Find("BethMain").gameObject.GetComponentsInChildren<Collider>();
        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }
        GetComponent<Collider>().enabled = !state;
    }
}
