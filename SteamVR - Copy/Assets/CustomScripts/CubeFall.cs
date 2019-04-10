using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFall : MonoBehaviour
{
    private bool hit = false;

    public GameObject canvasManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "GroundHit")
        {
            if (hit == false)
            {
                hit = true;

                canvasManager.GetComponent<CanvasManager>().cubeDestroyed();
            }

            Destroy(gameObject, 5);

        }
    }

}
