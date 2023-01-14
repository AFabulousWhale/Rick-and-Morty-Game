using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rickanimations : MonoBehaviour
{
    public ChangingCharacter _ChangingCharacter;
    public WalkRInjured _WalkRInjured;
    public AbilitiesMain _AbilitiesMain;

    public void oneR()
    {
        _ChangingCharacter.Rickchange1();
        }

    public void twoR()
    {
        _ChangingCharacter.Rickchange2();
    }

    public void threeR()
    {
        _ChangingCharacter.Rickchange3();
    }

    public void fourR()
    {
        _ChangingCharacter.Rickchange4();
    }

    public void twoM()
    {
        _ChangingCharacter.Mortychange2();
    }

    public void threeM()
    {
        _ChangingCharacter.Mortychange3();
    }

    public void fiveM()
    {
        _ChangingCharacter.Mortychange5();
    }


    public void oneRT()
    {
        _AbilitiesMain.RTeleporting1();
    }

    public void twoRT()
    {
        _AbilitiesMain.RTeleporting2();
    }

    public void threeRT()
    {
        _AbilitiesMain.RTeleporting3();
    }

    public void fourRT()
    {
        _AbilitiesMain.RTeleporting4();
    }

    public void fiveRT()
    {
        _AbilitiesMain.RTeleporting5();
    }

    public void sixRT()
    {
        _AbilitiesMain.RTeleporting6();
    }

    public void sevenRT()
    {
        _AbilitiesMain.RTeleporting7();
    }
}
