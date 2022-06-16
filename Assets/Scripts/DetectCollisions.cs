using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    [SerializeField] GameObject happyParticles;
    [SerializeField] int hitPoints;
    
    ScoreBoard scoreBoard;

    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            GameObject vFX = Instantiate(happyParticles, transform.position + new Vector3(0,5,0), Quaternion.identity);
  

            scoreBoard.IncreaseScore(hitPoints); 
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }


}
