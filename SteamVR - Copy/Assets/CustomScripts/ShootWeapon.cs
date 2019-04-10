using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ShootWeapon : MonoBehaviour
{

    public GameObject pistolBullet;

    public GameObject machineGunBullet;


    public Transform pistolBulletPos;

    public Transform machineGunBulletPos;


    public int pistolAmmo;

    private int machineGunAmmo;


    public bool pistolEnabled;

    public bool machineGunEnabled;


    private void Start()
    {
        SetAmmoPistol(12);

        UpdatePistolCanvas();

        UpdateMachineGunCanvas();
    }

    private void Update()
    {
		
	}

    public void ShootPistol()
    {
        if (pistolAmmo > 0 && pistolEnabled == true)
        {
            pistolAmmo -= 1;

            UpdatePistolCanvas();

            GameObject bulletInstance;

            bulletInstance = Instantiate(pistolBullet, pistolBulletPos.position, pistolBulletPos.rotation);
            bulletInstance.GetComponent<Rigidbody>().AddForce(pistolBulletPos.forward * 4000);

            Destroy(bulletInstance, 3);
        }
    }

    private void UpdatePistolCanvas()
    {
        GameObject pistolCanvas = GameObject.Find("PistolCanvas");

        PistolCanvas other = (PistolCanvas)pistolCanvas.GetComponent(typeof(PistolCanvas));

        other.PistolAmmoCounter(pistolAmmo);
    }

    public void ShootMachineGun()
    {
        if (machineGunAmmo > 0 && machineGunEnabled == true)
        {

            machineGunAmmo -= 1;
                    
            GameObject bulletInstance;

            Magazine mag = GetComponentInChildren<Magazine>();

            mag.ShootAmmo(machineGunAmmo);        

            bulletInstance = Instantiate(machineGunBullet, machineGunBulletPos.position, machineGunBulletPos.rotation);
            bulletInstance.GetComponent<Rigidbody>().AddForce(machineGunBulletPos.forward * 8000);

            Destroy(bulletInstance, 3);
        }
    }

    public void GetMachineGunAmmo(int ammo)
    {
        machineGunAmmo = ammo;
    }

    IEnumerator ShootMachineGunAuto()
    {
        ShootMachineGun();

        UpdateMachineGunCanvas();

        yield return new WaitForSeconds(0.1f);

        StartCoroutine("ShootMachineGunAuto");
    }

    public void MachineGunStart()
    {
        StartCoroutine("ShootMachineGunAuto");
    }

    public void MachineGunStop()
    {
        StopCoroutine("ShootMachineGunAuto");
    }

    public void UpdateMachineGunCanvas()
    {
        GameObject machineGunCanvas = GameObject.Find("MachineGunCanvas");

        MachineGunCanvas other = (MachineGunCanvas)machineGunCanvas.GetComponent(typeof(MachineGunCanvas));

        other.MachineGunAmmoCounter(machineGunAmmo);
    }
    
    public void PistolEnable()
    {
        pistolEnabled = true;
        Debug.Log("pistol Enabled");
    }

    public void PistolDisable()
    {
        pistolEnabled = false;
        Debug.Log("Pistol Disabled");
    }

    public void MachineGunEnable()
    {
        machineGunEnabled = true;
        Debug.Log("MachineGun Enabled");
    }

    public void MachineGunDisable()
    {
        machineGunEnabled = false;
        Debug.Log("MachineGun Disabled");
    }

    void SetAmmoPistol(int ammoAmount)
    {
        pistolAmmo = ammoAmount;
        Debug.Log(pistolAmmo);
    }

    void SetAmmoMachineGun(int ammoAmount)
    {
        machineGunAmmo = ammoAmount;
        Debug.Log(machineGunAmmo);
    }

    
}
