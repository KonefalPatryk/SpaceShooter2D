using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public float speed;
    public GameObject projectile;
    public GameObject gun;
    public GameObject gun2;


    private bool canshoot;
    private bool rapidfire;

    void Start()
    {
        canshoot = true;
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
        // control to activate shooting
        if (Input.GetAxis("Fire1") <= -0.1 && canshoot == false)
        {
            canshoot = true;
        }
          //regular shooting
        if (Input.GetAxis("Fire1") > 0.5 && rapidfire)
        {
            Instantiate(projectile, gun.transform.position, gun.transform.rotation);
            rapidfire = false;
            Instantiate(projectile, gun2.transform.position, gun2.transform.rotation);
            rapidfire = false;
        }

        if (Input.GetAxis("Fire1") <= 0.1 && rapidfire == false)
        {
            rapidfire = true;
        }
        

    }
    // the code from lines 66 - 72 is from the projectile script lines 21-33 and edited.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Power")
        {
            {
                if (collision.gameObject.GetComponent<Rapidfire>())
                    collision.gameObject.GetComponent<Rapidfire>();
            }
        }
    }
}