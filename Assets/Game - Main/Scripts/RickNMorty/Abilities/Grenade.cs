using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float delay = 3;

    float coundown;
    bool hasExploded = false;
    public RandomSounds _RandomSounds;

    public GameObject explosionEffect;
    // Start is called before the first frame update
    void Start()
    {
        coundown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        coundown -= Time.deltaTime;
        if(coundown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    public void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        _RandomSounds.ExplosionSound();
        Destroy(gameObject);
    }
}
