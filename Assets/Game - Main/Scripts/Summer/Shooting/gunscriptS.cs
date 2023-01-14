using UnityEngine;
using System.Collections;

public class gunscriptS : MonoBehaviour
{
    public RandomSounds _RandomSounds;

    public float damage;
    public float range = 500f;
    public float fireRate = 1f;

    public int maxAmmo = 6;
    public int currentAmmo;
    public float reloadtime = 1f;
    private bool isReloading = false;
    public Animator anim;

    public ParticleSystem Flash;
    public GameObject hitEffect, Bullet, Bullets, Bullets2, Bullets3, BulletSpawn1, BulletSpawn2, BulletSpawn3, fpsCamX, fpsCamY, Crosshair, bowArrow;
    public TMPro.TextMeshProUGUI AmmoLeft;

    private float nextTimeToFire = 0f;

    public float bulletSpeed;
    public bool shoot;

    public Quaternion originalRotation;
    float rotationResetSpeed = 2.0f;

    public Camera fpsCam;

    public float FireDamage;
    public Transform RightHand;

    public bool isShootingIdle = false;
    public float Timer;
    public bool timerCountdown = true;

    public float damageMultiplier;

    public float shotDamage;

    public AbilitiesMainS _AbilitiesMainS;
    public GameObject fireEffect1, fireEffect2, fireEffect3;

    public HealthBar bowCharge;
    public float BowCharge;


    void Start()
    {
        currentAmmo = maxAmmo;
        bowCharge.SetMaxHealth(100);
        BowCharge = damageMultiplier;
        bowCharge.SetHealth(BowCharge);

    }

    void Update()
    {
        bulletSpeed = 1000 * damageMultiplier;
        damage = 100 * damageMultiplier;

        if (damageMultiplier >= 1)
        {
            damageMultiplier = 1;
        }

        if (Input.GetButton("Fire1"))
        {
            damageMultiplier += Time.deltaTime;
            BowCharge = damageMultiplier * 100;
            bowCharge.SetHealth(BowCharge);
            timerCountdown = false;
            bowArrow.SetActive(true);
            anim.SetBool("Shooting", true);
            isShootingIdle = true;
        }
           
        
        if (Input.GetButtonUp("Fire1") && (Time.time >= nextTimeToFire) && !timerCountdown)
            {
            shotDamage = damage;
            damageMultiplier = 0;
            BowCharge = damageMultiplier;
            bowCharge.SetHealth(BowCharge);
            isShootingIdle = false;
            timerCountdown = true;
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
            }
            else 
            {
            shoot = false;
            }

        if(Timer >= 1)
        {
            anim.SetBool("Shooting", false);
        }

        if(timerCountdown)
        {
            Timer += Time.deltaTime;
        }
        else
        {
            Timer = 0;
        }
    }

    void Shoot()
    {
        if (_AbilitiesMainS.Multiple)
        {
            _RandomSounds.SummerShoot();
            FireBulletsMultiple();
            shoot = true;
        }
        else
        {

            shoot = true;

            _RandomSounds.SummerShoot();

            FireBullets();
        }

    }

    public void FireBullets()
    {
        Bullets = Instantiate(Bullet);
        if(_AbilitiesMainS.isUsingarrowType && _AbilitiesMainS.ArrowType == 2)
        {
            fireEffect1 = Bullets.transform.GetChild(0).gameObject;
            fireEffect1.SetActive(true);
        }
        else
        {
            fireEffect1 = null;
        }
        Physics.IgnoreCollision(Bullets.GetComponent<Collider>(), BulletSpawn1.transform.parent.GetComponent<Collider>());

        Bullets.transform.position = BulletSpawn1.transform.position;

        Vector3 rotation = Crosshair.transform.rotation.eulerAngles;

        Bullets.transform.rotation = BulletSpawn1.transform.rotation;

        Bullets.GetComponent<Rigidbody>().AddForce(BulletSpawn1.transform.forward * bulletSpeed, ForceMode.Impulse);

        bowArrow.SetActive(false);

        StartCoroutine(DestoryBullet(Bullets.gameObject, 3f));
    }

    private IEnumerator DestoryBullet(GameObject Bullets, float delay)
    {
        _AbilitiesMainS.pierce = false;
        yield return new WaitForSeconds(delay);
        Destroy(Bullets);
    }

    public void FireBulletsMultiple()
    {
        Bullets = Instantiate(Bullet);

        Physics.IgnoreCollision(Bullets.GetComponent<Collider>(), BulletSpawn1.transform.parent.GetComponent<Collider>());

        Bullets.transform.position = BulletSpawn1.transform.position;

        Vector3 rotation = Crosshair.transform.rotation.eulerAngles;

        Bullets.transform.rotation = BulletSpawn1.transform.rotation;

        Bullets.GetComponent<Rigidbody>().AddForce(BulletSpawn1.transform.forward * bulletSpeed, ForceMode.Impulse);

        Bullets2 = Instantiate(Bullet);

        Physics.IgnoreCollision(Bullets2.GetComponent<Collider>(), BulletSpawn2.transform.parent.GetComponent<Collider>());

        Bullets2.transform.position = BulletSpawn2.transform.position;

        Bullets2.transform.rotation = BulletSpawn2.transform.rotation;

        Bullets2.GetComponent<Rigidbody>().AddForce(BulletSpawn2.transform.forward * bulletSpeed, ForceMode.Impulse);

        Bullets3 = Instantiate(Bullet);

        Physics.IgnoreCollision(Bullets3.GetComponent<Collider>(), BulletSpawn3.transform.parent.GetComponent<Collider>());

        Bullets3.transform.position = BulletSpawn3.transform.position;

        Bullets3.transform.rotation = BulletSpawn3.transform.rotation;

        Bullets3.GetComponent<Rigidbody>().AddForce(BulletSpawn3.transform.forward * bulletSpeed, ForceMode.Impulse);

        if (_AbilitiesMainS.isUsingarrowType && _AbilitiesMainS.ArrowType == 2)
        {
            fireEffect1 = Bullets.transform.GetChild(0).gameObject;
            fireEffect1.SetActive(true);
            fireEffect2 = Bullets2.transform.GetChild(0).gameObject;
            fireEffect2.SetActive(true);
            fireEffect3 = Bullets3.transform.GetChild(0).gameObject;
            fireEffect3.SetActive(true);
        }
        else
        {
            fireEffect1 = null;
            fireEffect2 = null;
            fireEffect3 = null;
        }

        bowArrow.SetActive(false);
        StartCoroutine(DestoryBullets());
    }

    private IEnumerator DestoryBullets()
    {
        _AbilitiesMainS.pierce = false;
        yield return new WaitForSeconds(3f);
        Destroy(Bullets);
        Destroy(Bullets2);
        Destroy(Bullets3);
    }

}
