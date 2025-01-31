using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public float vertical = 2f;  // Límit vertical
    public float horizontal = 6f;  // Límit horitzontal

    void Update()
    {
        // Teletransport vertical
        if (transform.position.y > vertical)
        {
            transform.position = new Vector3(transform.position.x, -vertical, transform.position.z);
        }
        else if (transform.position.y < -vertical)
        {
            transform.position = new Vector3(transform.position.x, vertical, transform.position.z);
        }

        // Teletransport horitzontal
        if (transform.position.x > horizontal)
        {
            transform.position = new Vector3(-horizontal, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -horizontal)
        {
            transform.position = new Vector3(horizontal, transform.position.y, transform.position.z);
        }
    }
}
