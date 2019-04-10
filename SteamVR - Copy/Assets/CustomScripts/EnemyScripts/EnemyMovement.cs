using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;

    [SerializeField] private float moveSpeed = 4;

    [SerializeField] private float maxDis = 10;

    [SerializeField] private float minDis = 5;

    private void Start()
    {
    }


    private void Update()
    {
        Vector3 targetPosition = player.transform.position;

        targetPosition.y = transform.position.y;
        transform.LookAt(targetPosition);

        float distance = Vector3.Distance(player.transform.position, this.transform.position);

        if(distance > minDis)
        {
            transform.Translate(Vector3.forward * moveSpeed);
        }
    }


}
