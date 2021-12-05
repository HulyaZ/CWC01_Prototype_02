using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float playerSpeed = 10.0f;
    public float xRangePlayer = 10;

    public GameObject projectilePrefab;
    
    void Start()
    {
        
    }

    
    void Update()
    {
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

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
