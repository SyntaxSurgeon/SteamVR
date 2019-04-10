using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public Transform spawnPoint;

    public Rigidbody ball;

    private bool isOut;

    private bool isCreated;

    private int ballCount = 20;

    public int BallCount
    {
        get
        {
            return ballCount;
        }
        set
        {
            ballCount = value;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other, 10);

            isCreated = false;

            ballCount -= 1;

            if(isCreated == false)
            {
                isCreated = true;

                Instantiate(ball, spawnPoint.position, spawnPoint.rotation);
            }
        }
    }
}
