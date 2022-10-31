using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public int damage;
    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (collision.gameObject.GetComponent<Health>())
            {
                collision.gameObject.GetComponent<Health>().DecreaseHealth(damage);
                Destroy(gameObject);
            }

            else
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
}
