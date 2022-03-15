using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInBounds : MonoBehaviour
{
    private int upperBound = 14;
    private int lowerBound = 3;

    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < lowerBound)
        {
            playerRb.AddForce(Vector3.up * 1, ForceMode.Impulse);

        }
        else if(transform.position.y > upperBound)
        {
            transform.position = new Vector3(-3, upperBound, 0);
        }
    }
}
