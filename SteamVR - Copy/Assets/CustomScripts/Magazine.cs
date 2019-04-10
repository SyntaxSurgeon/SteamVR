using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Magazine : MonoBehaviour
{
    public TextMeshProUGUI ammoText1;

    public TextMeshProUGUI ammoText2;


    private int maxAmmo = 60;

    private int currentAmmo;

    private void Start()
    {
        currentAmmo = 60;

        ammoText1.text = "" + currentAmmo;

        ammoText2.text = "" + currentAmmo;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("MagCollider"))
        {
            GameObject machineGun = GameObject.Find("MachineGun");
            ShootWeapon shootScript = (ShootWeapon)machineGun.GetComponent<ShootWeapon>();
            shootScript.GetMachineGunAmmo(currentAmmo);
            shootScript.UpdateMachineGunCanvas();
            Debug.Log("MagIn");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == ("MagCollider"))
        {
            GameObject machineGun = GameObject.Find("MachineGun");
            ShootWeapon shootScript = (ShootWeapon)machineGun.GetComponent<ShootWeapon>();
            shootScript.GetMachineGunAmmo(0);
            shootScript.UpdateMachineGunCanvas();
            Debug.Log("MagOut");
        }
    }

    public void ShootAmmo(int ammo)
    {
        currentAmmo = ammo;

        Debug.Log(currentAmmo);

        ammoText1.text = "" + currentAmmo;

        ammoText2.text = "" + currentAmmo;
    }
}
