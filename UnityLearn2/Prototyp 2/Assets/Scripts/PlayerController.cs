using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public int border = 10;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.x < -border)
        {
            transform.position = new Vector3(-border, transform.position.y, transform.position.z);
        }

        if (transform.position.x > border)
        {
            transform.position = new Vector3(border, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        
        }

            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        
    }
}
