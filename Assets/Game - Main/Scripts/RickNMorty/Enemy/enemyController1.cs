using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController1 : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public float bulletLifeTime = 10f;

    public GameObject Bullet, Bullets;
    public Transform ship, Player;

    public float timeBtwShots;
    public float startTimeBtwShots;

    public float lookRadius = 100f;

   public GameObject[] closest;
    float shortestDistance = Mathf.Infinity;
    GameObject nearestObject = null;

    public Animator anim;

    public Vector3 shipPos, playerPos;

    public EnemySummoning _EnemySummoning;
    void Start()
    {
        Bullet.SetActive(false);
    }

    void findTarget()
    {
        foreach (GameObject thing in closest)
        {
            float distanceToObject = Vector3.Distance(transform.position, thing.transform.position);
            if (distanceToObject < shortestDistance)
            {
                shortestDistance = distanceToObject;
                nearestObject = thing;
            }
        }
    }
    void Update()
    {
        anim = this.gameObject.GetComponent<Animator>();
        findTarget();
        playerPos = new Vector3(Player.position.x, transform.position.y, Player.position.z);
        shipPos = new Vector3(ship.position.x, transform.position.y, ship.position.z);
        Vector3 direction = (Player.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);

        if (nearestObject == GameObject.Find("Characters"))
            {
            if (Vector3.Distance(transform.position, playerPos) > stoppingDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
            }
            else if (Vector3.Distance(transform.position, playerPos) < stoppingDistance && Vector3.Distance(transform.position, playerPos) > retreatDistance)
            {
                transform.position = this.transform.position;
            }
            else if (Vector3.Distance(transform.position, playerPos) < retreatDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, playerPos, -speed * Time.deltaTime);
            }
        }
        
        else if (nearestObject == GameObject.Find("__Ship"))
        {
            if (Vector3.Distance(transform.position, shipPos) > stoppingDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, shipPos, speed * Time.deltaTime);
            }
            else if (Vector3.Distance(transform.position, shipPos) < stoppingDistance && Vector3.Distance(transform.position, shipPos) > retreatDistance)
            {
                transform.position = this.transform.position;
            }
        }

            if (timeBtwShots <= 0)
        {
            anim.SetBool("Shooting", true);
            Bullets = Instantiate(Bullet, transform.position, transform.rotation);
            Vector3 directionofBullet = Player.transform.position - Bullets.transform.position;
            Quaternion rotation = Quaternion.LookRotation(directionofBullet);
            Bullets.transform.rotation = rotation;
            Bullets.SetActive(true);
            StartCoroutine(DestoryBullet(Bullets, bulletLifeTime));
            timeBtwShots = startTimeBtwShots;
            anim.SetBool("Shooting", false);
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }


    private IEnumerator DestoryBullet(GameObject Bullets, float delay)
    {
        yield return new WaitForSeconds(10);
        DBullets(Bullets);
    }

    public void DBullets(GameObject Bullets)
    {
        Destroy(Bullets);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
