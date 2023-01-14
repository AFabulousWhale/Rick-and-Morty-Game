using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MortyMagicAnimations : MonoBehaviour
{
    public AbilitiesMain _AbilitiesMain;

    public void oneMM()
    {
        _AbilitiesMain.MMagic1();
    }

    public void twoMM()
    {
        _AbilitiesMain.MFireBall();
    }

    public void threeMM()
    {
        _AbilitiesMain.MGrenade();
    }
}
