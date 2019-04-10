using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MachineGunCanvas : MonoBehaviour
{
    private int machineGunAmmoCount;

    public TextMeshProUGUI machineGunAmmoCountText;

    private void Awake()
    {
        StartCoroutine("UpdateMachineGunCanvas");
    }

    private void OnEnable()
    {
        StartCoroutine("UpdateMachineGunCanvas");
    }

    private void FixedUpdate()
    {

    }

    IEnumerator UpdateMachineGunCanvas()
    {
        machineGunAmmoCountText.text = "Ammo: " + machineGunAmmoCount;

        yield return new WaitForSeconds(0.2f);

        StartCoroutine("UpdateMachineGunCanvas");
    }

    public void MachineGunAmmoCounter(int ammo)
    {
        machineGunAmmoCount = ammo;
    }

}
