using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowStop : MonoBehaviour
{
   public Rigidbody RigidBody;
    public float lifeTimer = 8f;
    public float timer;
    public bool hasHitTarget = false;

    public float bulletLifeTime = 3f;

    public gunscriptS _gunscriptS;
    public AbilitiesMainS _AbilitiesMainS;

    void Start()
    {
        RigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!hasHitTarget)
        {
            transform.rotation = Quaternion.LookRotation(RigidBody.velocity);
        }
    }
     public void OnTriggerEnter(Collider collision)
     {
        StartCoroutine(DestoryBullet(this.gameObject, bulletLifeTime));
        _gunscriptS.damage = 0;
        if (collision.gameObject.layer != 16 && collision.gameObject.layer != 19 && collision.gameObject.layer != 17 && collision.gameObject.layer != 21 && collision.gameObject.layer != 11)
        {
            Stick();
            hasHitTarget = true;
        }
     }
    private void Stick()
    {
        RigidBody.constraints = RigidbodyConstraints.FreezeAll;
        StartCoroutine(DestoryBullet(this.gameObject, bulletLifeTime));
    }

    private IEnumerator DestoryBullet(GameObject Bullets, float delay)
    {
        _AbilitiesMainS.pierce = false;
        yield return new WaitForSeconds(delay);
        DBullets(Bullets);
    }

    public void DBullets(GameObject Bullets)
    {
        Destroy(Bullets);
    }
}