using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortalToMouse : MonoBehaviour
{
    public float TargetDistance;
    public GameObject PortalTP;

    public AbilitiesMain _AbilitiesMain;

    public Camera RCamera;
    private void Update()
    {
        if (_AbilitiesMain.DecidingT == true)
        {
            RaycastHit hit;
            Ray ray = RCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                PortalTP.transform.position = hit.point;
                PortalTP.transform.position = new Vector3(PortalTP.transform.position.x, Terrain.activeTerrain.SampleHeight(PortalTP.transform.position) + 3, PortalTP.transform.position.z);
            }
        }
    }
}

