using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    float timeMin = 1.0f;
    float time = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && time > timeMin)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            time = 0;
        }
    }
}