using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WalkSInjured : MonoBehaviour
{
    GameObject Summer;

    public HealthSummer _HealthSummer;
    public WalkingS _WalkingS;
    public AppearDisappear _AorD;
    public RandomSounds _RandomSounds;

    public GameObject Summermain;

    public Camera camFirstS, camHandsS;

    public bool SDead;

    public bool SDying;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("SummerModel").gameObject.GetComponent<Renderer>().enabled = false;
        SDead = false;
        SDying = false;

        setColliderState(false);
        setRigidbodyState(true);
    }

    // Update is called once per frame
    void Update()
    {
        if ((_HealthSummer.currentHealth < 50) && (_HealthSummer.currentHealth > 0))
        {
            _WalkingS.walkSpeed = 160f;
            _WalkingS.runSpeed = 50f;

        }
        else if ((_HealthSummer.currentHealth >= 50))
        {
            _WalkingS.walkSpeed = 160f;
            _WalkingS.runSpeed = 200f;
        }

            if ((_HealthSummer.currentHealth == 0) && (SDead == false))
            {
            SDying = true;
            SummerDie();
            }
    }

    void SummerDie()
    {
        GameObject.Find("SummerModel").gameObject.GetComponent<Renderer>().enabled = true;
        _AorD.thirdCam();
        SDead = true;
        GetComponent<WalkingS>().enabled = false;
        anim = GameObject.Find("Summer Main").gameObject.GetComponent<Animator>();
        anim.enabled = false;
        setColliderState(true);
        setRigidbodyState(false);
        StartCoroutine(Death());
        IEnumerator Death()
        {
            yield return new WaitForSeconds(3);
            Destroy(GameObject.Find("SummerModel"));
            GetComponent<WalkingS>().enabled = true;
            SceneManager.LoadScene("Game Over");
        }
    }

    void setRigidbodyState(bool state)
    {
        Rigidbody[] rigidbodies = GameObject.Find("Summer Main").gameObject.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }
    }

    void setColliderState(bool state)
    {
        Collider[] colliders = GameObject.Find("Summer Main").gameObject.GetComponentsInChildren<Collider>();
        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }
        GetComponent<Collider>().enabled = !state;
    }
}
