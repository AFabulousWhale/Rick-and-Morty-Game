using UnityEngine;
using System.Collections;

public class gunscriptM : MonoBehaviour
{
    public RandomSounds _RandomSounds;

    public int damage;
    public float range = 500f;
    public float fireRate = 1f;

    public int maxAmmo = 6;
    public int currentAmmo;
    public float reloadtime = 1f;
    private bool isReloading = false;
    public Animator anim;

    public ParticleSystem Flash;
    public GameObject hitEffect, Bullet, Bullets, BulletSpawn, fpsCamX, fpsCamY, Crosshair;
    public TMPro.TextMeshProUGUI AmmoLeft;
    public ChangingCharacter _ChangingCharacter;
    public AbilitiesMain _AbilitiesMain;

    private float nextTimeToFire = 0f;

    public Transform bulletSpawn;
    public float bulletSpeed;
    public float bulletLifeTime = 0.5f;
    private bool shoot;

    public Quaternion originalRotation;
    float rotationResetSpeed = 2.0f;

    public Camera fpsCam;
    void Start()
    {
        currentAmmo = maxAmmo;
        GameObject.Find("BulletM").gameObject.GetComponent<Renderer>().enabled = true;
    }

    void Update()
    {
        Vector3 rotation = Crosshair.transform.rotation.eulerAngles;

        Vector3 CamX = (fpsCamX.transform.rotation.eulerAngles);

        Vector3 CamY = (fpsCamY.transform.rotation.eulerAngles);

        BulletSpawn.transform.rotation = Quaternion.Euler(rotation.x + Random.Range(CamX.x - 0.3f, CamX.x + 0.3f), rotation.y + Random.Range(CamY.y - 0.5f, CamY.y + 0.5f), rotation.z);

        Bullet.transform.rotation = BulletSpawn.transform.rotation;

        if (_ChangingCharacter.charSelect == 1)
        {
            GameObject.Find("BulletM").gameObject.GetComponent<Renderer>().enabled = true;
            if (currentAmmo == 0 && isReloading == false)
            {
                Reload();
                return;
            }

            if (Input.GetButtonDown("Reload") && currentAmmo != maxAmmo)
            {
                Reload();
            }

            if (isReloading)
                return;


            if (Input.GetButton("Fire1") && (Time.time >= nextTimeToFire))
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
            }
            else
            {
                shoot = false;
            }
        }
        else
        {
            GameObject.Find("BulletM").gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    void Shoot()
    {
        shoot = true;

        _RandomSounds.MShoot();

        FireBullets();

        RaycastShoot();

        Flash.Play();

        currentAmmo--;

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
        Bullets = Instantiate(Bullet);

        Physics.IgnoreCollision(Bullets.GetComponent<Collider>(), bulletSpawn.parent.GetComponent<Collider>());

        Bullets.transform.position = bulletSpawn.position;

        Bullets.GetComponent<Rigidbody>().AddForce(BulletSpawn.transform.forward * bulletSpeed, ForceMode.Impulse);

        StartCoroutine(DestoryBullet(Bullets, bulletLifeTime));
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



    public void Reload()
    {
        StartCoroutine(waiter());
        IEnumerator waiter()
        {
            isReloading = true;
            Debug.Log("Reloading");
            _RandomSounds.Other = 5;
            yield return new WaitForSeconds(reloadtime);
            currentAmmo = maxAmmo;
            AmmoLeft.text = currentAmmo.ToString();
            yield return new WaitForSeconds(0.5f);
            isReloading = false;
        }
    }

    public void ammoRemaining()
    {
        AmmoLeft.text = currentAmmo.ToString();
    }
}
