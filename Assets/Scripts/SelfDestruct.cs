using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitFor(3f));
   
    }


    IEnumerator waitFor(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        Destroy(gameObject);
    }
}
