using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed = 5.0f;

   

    public float xRange = 10;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
         
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            
        }

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

    }
}
