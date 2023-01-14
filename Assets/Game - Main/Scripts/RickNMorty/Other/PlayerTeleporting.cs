using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporting : MonoBehaviour
{
    public Transform Player, playerpos1, playerpos2;
    public CharacterController cc;

   public void TP1()
    {
        cc.enabled = false;
        Player.position = playerpos1.position;
        cc.enabled = true;
    }

    public void TP2()
    {
        cc.enabled = false;
        Player.position = playerpos2.position;
        cc.enabled = true;
    }
}
