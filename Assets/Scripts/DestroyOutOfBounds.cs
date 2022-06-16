using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    float topBound = 30;
    float lowerBound = -15;


    ScoreBoard scoreBoard;

    void Start()
    {

        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {

            scoreBoard.DecreaseScore(1);
            Destroy(gameObject);
        }
    }
}
