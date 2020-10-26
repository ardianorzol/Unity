using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public float speed = 10.0f;
    public Vector3 start;
    public Vector3 stop;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // składowa y wektora prędkości
        if (transform.position.x <= start.x)
        {
            // działamy siłą na ciało A :)
            rb.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }
        if (transform.position.x >= stop.x)
        {
            // działamy siłą na ciało A :)
            rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }
    }
}