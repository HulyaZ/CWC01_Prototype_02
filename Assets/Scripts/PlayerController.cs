using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
 
    public float playerSpeed;
    public float xRangePlayer = 10;

    public GameObject[] projectilePrefab;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerSpeed = 25.0f;
        }
        else playerSpeed = 15.0f;
   

        if (transform.position.x > xRangePlayer)
        {
            transform.position = new Vector3(xRangePlayer, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xRangePlayer)
        {
            transform.position = new Vector3(-xRangePlayer, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");

                transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);


        randomPrefabInstantiator();

    }


    void randomPrefabInstantiator()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            int foodIndex = Random.Range(0, projectilePrefab.Length);
            Instantiate(projectilePrefab[foodIndex], transform.position + new Vector3(0.0f, 0.5f, 0.0f), projectilePrefab[foodIndex].transform.rotation);
        }
    }
}
