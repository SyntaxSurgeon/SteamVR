using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PistolCanvas : MonoBehaviour
{
    private int pistolAmmoCount;

    public TextMeshProUGUI pistolAmmoCountText;

    private void Start()
    {
        StartCoroutine("UpdatePistolCanvas");
    }

    private void FixedUpdate()
    {

    }

    IEnumerator UpdatePistolCanvas()
    {
        pistolAmmoCountText.text = "" + pistolAmmoCount;

        yield return new WaitForSeconds(0.2f);

        StartCoroutine("UpdatePistolCanvas");
    }

    public void PistolAmmoCounter(int ammo)
    {
        pistolAmmoCount = ammo;
    }
}
