using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject bullet;

    public Transform bulletStartPos;

    private int ammo;

    private void Start()
    {
        SetAmmo(100);
    }


    public void ShootPistol()
    {
        if (ammo > 0)
        {        
            ammo -= 1;

            Debug.Log("Shot");

            Debug.Log(ammo);

            GameObject bulletInstance;

            bulletInstance = Instantiate(bullet, bulletStartPos.position, bulletStartPos.rotation);
            bulletInstance.GetComponent<Rigidbody>().AddForce(bulletStartPos.forward * 4000);

            Debug.Log("bullet");
            Destroy(bulletInstance, 1);
        }
    }


    void SetAmmo(int ammoAmount)
    {
        ammo = ammoAmount;
    }
}
