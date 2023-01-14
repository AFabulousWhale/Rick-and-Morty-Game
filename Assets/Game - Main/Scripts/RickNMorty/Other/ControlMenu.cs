using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenu : MonoBehaviour
{
    public GameObject Menu;

    public void Back()
    {
        Menu.SetActive(true);
        gameObject.SetActive(false);
    }
}
