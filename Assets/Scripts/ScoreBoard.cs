using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    public int score =0;
    TMP_Text scoreText;

    void Start()
    { 
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Score: ";
    }


    public void IncreaseScore(int amountToIncrease)
    {
        
        score += amountToIncrease;
        scoreText.text = "Score: " + score.ToString();
    }

    public void DecreaseScore(int amountToIncrease)
    {
        
        score -= amountToIncrease;
        scoreText.text = "Score: " + score.ToString();
    }
}
