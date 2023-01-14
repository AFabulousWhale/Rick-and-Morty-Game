using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gunscriptJ : MonoBehaviour
{
    public RandomSounds _RandomSounds;

    public int damage = 50;
    public float range = 500f;
    public float fireRate = 1f;

    public int maxAmmo = 6;
    public int currentAmmo;
    public float reloadtime = 1f;
    private bool isReloading = false;
    public Animator anim;

    public ParticleSystem Flash;
    public GameObject hitEffect, Bullet, Bullets, BulletSpawn, fpsCamX, fpsCamY, Crosshair, hands;
    public TMPro.TextMeshProUGUI AmmoLeft;
    public enemyhit _enemyhit;

    private float nextTimeToFire = 0f;

    public Transform bulletSpawn;
    public float bulletSpeed;
    public float bulletLifeTime = 0.5f;
    private bool shoot;

    public Quaternion originalRotation;
    float rotationResetSpeed = 2.0f;

    public Camera fpsCam;

    public int bulletCount;
    public float spreadAngle;
    List<Quaternion> pellets;
    public bool canReload = false;
    void Start()
    {
        pellets = new List<Quaternion>(bulletCount);
        currentAmmo = maxAmmo;
    }

    void Update()
    {


            if (currentAmmo == 0 && isReloading == false && currentAmmo != maxAmmo)
            {
                Reload();
                return;
            }

            if (Input.GetButtonDown("Reload") && currentAmmo != maxAmmo)
            {
                Reload();
            }


        if (Input.GetButton("Fire1") && (Time.time >= nextTimeToFire))
        {
            canReload = false;
            currentAmmo--;
            bulletCount = 4;
            for (int i = 0; i < bulletCount; i++)
            {
                pellets.Add(Quaternion.Euler(Vector3.zero));
            }

            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
        else if (Input.GetButton("Fire2") && (Time.time >= nextTimeToFire) && currentAmmo >= 2)
        {
            canReload = false;
            currentAmmo = currentAmmo - 2;
            bulletCount = 6;
            for (int i = 0; i < bulletCount; i++)
            {
                pellets.Add(Quaternion.Euler(Vector3.zero));
            }

            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
        else
            {
                shoot = false;
            }
    }

    void Shoot()
    {
        anim.SetBool("Shooting", true);
        shoot = true;

        _RandomSounds.JerryShoot();

        FireBullets();

        RaycastShoot();

        Flash.Play();

        ammoRemaining();

    }

    public void RaycastShoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
        {
            if (hit.collider.gameObject.tag == "Terrain")
            {
                GameObject hitEffectGO = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
                hitEffectGO.SetActive(true);
                Destroy(hitEffectGO, 3);
            }
        }
    }

    public void FireBullets()
    {
        for(int i = 0; i < bulletCount; i++)
        {
            pellets[i] = Random.rotation;
            Bullets = Instantiate(Bullet, bulletSpawn.position, bulletSpawn.rotation);
            Bullets.transform.rotation = Quaternion.RotateTowards(Bullets.transform.rotation, pellets[i], spreadAngle);
            Bullets.GetComponent<Rigidbody>().AddForce(Bullets.transform.forward * bulletSpeed, ForceMode.Impulse);
            StartCoroutine(DestoryBullet(Bullets, 3f));
        }

        anim.SetBool("Shooting", false);
    }

    public void Reload()
    {
        canReload = true;
        StartCoroutine(waiter());
        IEnumerator waiter()
        {
                for (int i = currentAmmo; i < maxAmmo; i++)
                {
                if (canReload)
                {
                    isReloading = true;
                    Debug.Log("Reloading");
                    _RandomSounds.JerryReload();
                    yield return new WaitForSeconds(0.25f);
                    currentAmmo++;
                    AmmoLeft.text = currentAmmo.ToString();
                    yield return new WaitForSeconds(0.5f);
                    isReloading = false;
                }
                }
                canReload = false;
        }
    }


    private IEnumerator DestoryBullet(GameObject Bullets, float delay)
    {
        yield return new WaitForSeconds(delay);
        DBullets(Bullets);
    }

    public void DBullets(GameObject Bullets)
    {
        Destroy(Bullets);
    }
    public void ammoRemaining()
    {
        AmmoLeft.text = currentAmmo.ToString();
    }
}
