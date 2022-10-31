using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") > 0.5)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
        }
        else if (Input.GetAxis("Horizontal") < -0.5)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.right * speed);
        }


        if (Input.GetAxis("Vertical") > 0.5)
        {                                   // (.AddForce) forces the movement which enables diagonal movement. (.velocity =) makes it go one way
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
        }
        else if (Input.GetAxis("Vertical") < -0.5)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.up * speed);
        }
    }
}