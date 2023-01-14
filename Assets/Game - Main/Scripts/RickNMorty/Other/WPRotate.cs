using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPRotate : MonoBehaviour
{
    public GameObject ship;
    public bool Rotated;

    public ShipMovement _ShipMovement;

    void Start()
    {
        Rotated = false;
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ship")
        {
            ship.transform.Rotate(0, 0, 90);
            Rotated = true;
        }
    }

}

