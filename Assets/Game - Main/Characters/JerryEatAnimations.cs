using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerryEatAnimations : MonoBehaviour
{
    public AbilitiesMainJ _AbilitiesMainJ;

    public void oneJ()
    {
        _AbilitiesMainJ.JHealing1();
    }

    public void twoJ()
    {
        _AbilitiesMainJ.JHealing2();
    }
}
