using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGame : MonoBehaviour
{
    [SerializeField] TMP_Text[] gameStarters;
    [SerializeField] TMP_Text inGame;

    [SerializeField] PlayerController playerController;


    void Start()
    {
        GameStart();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
         
            playerController.enabled = true;
            Time.timeScale = 1f;
            
            foreach (var startText in gameStarters)
            {
                startText.gameObject.SetActive(false);
            }

            inGame.gameObject.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GameStart();
        }
    }

    void GameStart()
    {
       
        playerController.enabled = false;
        Time.timeScale = 0f;
     
        foreach (var startText in gameStarters)
        {
            startText.gameObject.SetActive(true);
        }

        inGame.gameObject.SetActive(false);    

    }
}
