using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Transform spawnPoint;

    public Rigidbody ball;


    public void SpawnBall()
    {
        Instantiate(ball, spawnPoint.position, spawnPoint.rotation);
    }

    public void ResetButtonPressed()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
}
