using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUiToggle : MonoBehaviour
{
    public GameObject pistolCanvas;

    public GameObject machineGunCanvas;

    private void Start()
    {
        pistolCanvas.SetActive(false);

        machineGunCanvas.SetActive(false);
    }

    public void TogglePistolUiOn()
    {
        pistolCanvas.SetActive(true);
    }

    public void ToggleMachineGunUiOn()
    {
        machineGunCanvas.SetActive(true);
    }

    public void TogglePistolUiOff()
    {
        pistolCanvas.SetActive(false);
    }

    public void ToggleMachineGunUiOff()
    {
        machineGunCanvas.SetActive(false);
    }
}
