using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mortyanimations : MonoBehaviour
{
    public ChangingCharacter _ChangingCharacter;
    public WalkMInjured _WalkMInjured;

    public void fiveR()
    {
        _ChangingCharacter.Rickchange5();
    }

    public void sixR()
    {
        _ChangingCharacter.Rickchange6();
    }

    public void oneM()
    {
        _ChangingCharacter.Mortychange1();
    }

    public void fourM()
    {
        _ChangingCharacter.Mortychange4();
    }
}
