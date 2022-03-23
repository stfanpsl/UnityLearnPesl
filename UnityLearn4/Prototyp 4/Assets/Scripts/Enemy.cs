using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    private int bound = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        if (CompareTag("HardEnemy"))
        {
            enemyRb.AddForce(lookDirection * speed * 2);
        }
        else
        {
            enemyRb.AddForce(lookDirection * speed);
        }
        

        if(transform.position.y < -bound)
        {
            Destroy(gameObject);
        }
    }
}
