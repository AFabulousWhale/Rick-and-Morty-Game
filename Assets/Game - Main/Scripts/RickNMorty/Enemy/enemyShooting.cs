using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    public float speed;

    public Transform player, Target;
    public GameObject enemy;
    public Vector3 target;

    public int damage;

    public HealthMorty _HealthMorty;
    public RandomSounds _RandomSounds;
    public HealthRick _HealthRick;
    public HealthSummer _HealthSummer;
    public HealthJerry _HealthJerry;
    public HealthBeth _HealthBeth;
    public ChangingCharacter _ChangingCharacter;
    public WinLose _WinLose;
    public AbilitiesMain _AbilitiesMain;

    void Update()
    {
        player = GameObject.Find("Characters").transform;
        enemy = GameObject.Find("__Enemy(Clone)");
        target = new Vector3(player.position.x, player.position.y, player.position.z);

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 12)
        {
            Destroy(gameObject);
            if (Globals.Character == "Rick And Morty")
            {
                if (_ChangingCharacter.charSelect == 0 && _HealthRick.currentHealth > 0 && !_ChangingCharacter.Changing && !_WinLose.endGame && !_AbilitiesMain.Teleporting)
                {
                    _RandomSounds.RickHurtSound();
                    _RandomSounds.Hurting();
                    _HealthRick.TakeDamage(damage);
                }
                else if (_ChangingCharacter.charSelect == 1 && _HealthMorty.currentHealth > 0 && !_ChangingCharacter.Changing && !_WinLose.endGame)
                {
                    _RandomSounds.MortyHurtSound();
                    _RandomSounds.Hurting();
                    _HealthMorty.TakeDamage(damage);
                }
            }
        }
        if(other.gameObject.layer == 16)
        {
            if (Globals.Character == "Summer")
            {
                if (_HealthSummer.currentHealth > 0 && !_WinLose.endGame)
                {
                    _RandomSounds.SummerHurtSound();
                    _HealthSummer.TakeDamage(damage);
                }
            }
        }

        if (other.gameObject.layer == 20)
        {
            if (Globals.Character == "Jerry")
            {
                if (_HealthJerry.currentHealth > 0 && !_WinLose.endGame)
                {
                    _RandomSounds.JerryHurtSound();
                    _HealthJerry.TakeDamage(damage);
                }
            }
        }

        if (other.gameObject.layer == 23)
        {
            if (Globals.Character == "Beth")
            {
                if (_HealthBeth.currentHealth > 0 && !_WinLose.endGame)
                {
                    _RandomSounds.BethHurtSound();
                    _HealthBeth.TakeDamage(damage);
                }
            }
        }
    }
}
