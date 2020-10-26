using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad3 : MonoBehaviour
{

    public float speed = 5.0f;
    public Transform rog1, rog2, rog3, rog4;
    Vector3 nast;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        {
            if (transform.position == rog1.position)
            {
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                nast = rog2.position;

            }
            if (transform.position == rog2.position)
            {
                transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
                nast = rog3.position;
            }
            if (transform.position == rog3.position)
            {
                transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
                nast = rog4.position;
            }
            if (transform.position == rog4.position)
            {
                transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
                nast = rog1.position;
            }

            transform.position = Vector3.MoveTowards(transform.position, nast, speed * Time.deltaTime);
        }

    }
}

