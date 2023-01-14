using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletForce : MonoBehaviour
{
    public enemyhit _enemyhit;
    public Collider[] colliders;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _enemyhit = collision.gameObject.GetComponent<enemyhit>();
            if (_enemyhit.Dead)
            {
                colliders = Physics.OverlapSphere(transform.position, 1000f);

                foreach (Collider closeObjects in colliders)
                {
                    Rigidbody rb = closeObjects.GetComponent<Rigidbody>();

                    if (rb != null)
                    {
                        rb.AddExplosionForce(500f, gameObject.transform.position, 100f);
                    }
                }
            }
        }
      
    }
}
