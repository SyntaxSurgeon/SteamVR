using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    public TextMeshProUGUI cubeCountText;
    public TextMeshProUGUI ballCountText;

    public Transform cubes;
    
    private int cubeCount;
    private int ballCount;

    private void Start()
    {
        cubeCount = cubes.childCount;

        StartCoroutine("UpdateCanvas");

        BallSpawn ball = new BallSpawn();

        ballCount = ball.BallCount;
    }

    private void Update()
    {
        
    }

    public void cubeDestroyed()
    {
        cubeCount -= 1;
    } 

    private void UpdateText()
    {
        BallSpawn ball = new BallSpawn();

        cubeCountText.text = "Cubes Left: " + cubeCount;
        ballCountText.text = "Balls Left: " + ballCount;
    }

    IEnumerator UpdateCanvas()
    {
        UpdateText();

        yield return new WaitForSeconds(1);

        StartCoroutine("UpdateCanvas");
    }
}
