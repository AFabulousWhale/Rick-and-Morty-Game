using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WalkJInjured : MonoBehaviour
{
    GameObject Summer;

    public HealthJerry _HealthJerry;
    public WalkingJ _WalkingJ;
    public AppearDisappear _AorD;
    public RandomSounds _RandomSounds;

    public Camera camFirstJ;

    public bool JDead;

    public bool JDying;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("JerryModel").gameObject.GetComponent<Renderer>().enabled = false;
        JDead = false;
        JDying = false;

        setColliderState(false);
        setRigidbodyState(true);
    }

    // Update is called once per frame
    void Update()
    {
        if ((_HealthJerry.currentHealth < 50) && (_HealthJerry.currentHealth > 0) && !Input.GetKey(KeyCode.LeftShift))
        {
            _WalkingJ.walkSpeed = 160f;
            _WalkingJ.runSpeed = 50f;

        }
        else if ((_HealthJerry.currentHealth >= 50) && !Input.GetKey(KeyCode.LeftShift))
        {
            _WalkingJ.walkSpeed = 160f;
            _WalkingJ.runSpeed = 200f;
        }

            if ((_HealthJerry.currentHealth == 0) && (JDead == false))
            {
            JDying = true;
            JerryDie();
            }
    }

    void JerryDie()
    {
        GameObject.Find("JerryModel").gameObject.GetComponent<Renderer>().enabled = true;
        _AorD.thirdCam();
        JDead = true;
        GetComponent<WalkingJ>().enabled = false;
        anim = GameObject.Find("Jerry Main").gameObject.GetComponent<Animator>();
        anim.enabled = false;
        setColliderState(true);
        setRigidbodyState(false);
        StartCoroutine(Death());
        IEnumerator Death()
        {
            yield return new WaitForSeconds(3);
            Destroy(GameObject.Find("JerryModel"));
            GetComponent<WalkingJ>().enabled = true;
            SceneManager.LoadScene("Game Over");
        }
    }

    void setRigidbodyState(bool state)
    {
        Rigidbody[] rigidbodies = GameObject.Find("Jerry Main").gameObject.GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }
    }

    void setColliderState(bool state)
    {
        Collider[] colliders = GameObject.Find("Jerry Main").gameObject.GetComponentsInChildren<Collider>();
        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }
        GetComponent<Collider>().enabled = !state;
    }
}
