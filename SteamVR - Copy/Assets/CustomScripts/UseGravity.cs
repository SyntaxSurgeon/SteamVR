using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseGravity : MonoBehaviour
{
    private Rigidbody rb;


    private void OnCollisionEnter(Collision collision)
    {
        rb = gameObject.GetComponent<Rigidbody>();

        rb.useGravity = true;
    }
}
