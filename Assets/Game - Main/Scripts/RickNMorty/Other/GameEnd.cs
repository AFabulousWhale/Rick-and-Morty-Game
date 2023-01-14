using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public RandomSounds _RandomSounds;
    public bool triggerGameEnd = false;

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Ship")
        {
            triggerGameEnd = true;
            Debug.Log("ship collision");
            _RandomSounds.Other = 7;
        }
    }
}
