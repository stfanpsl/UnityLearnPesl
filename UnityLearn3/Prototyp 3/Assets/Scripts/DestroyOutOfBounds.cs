using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float leftLimit = -10.0f;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Destroy Barrels if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
    }
}
