using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BethAnimations : MonoBehaviour
{
    public AbilitiesMainB _AbilitiesMainB;
    public void dartone()
    {
        _AbilitiesMainB.FireDarts();
    }

    public void darttwo()
    {
        _AbilitiesMainB.Dart1();
    }

    public void healone()
    {
        _AbilitiesMainB.Heal1();
    }
}
