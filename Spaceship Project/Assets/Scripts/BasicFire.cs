using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFire : MonoBehaviour
{
    public GameObject projectile;


    private bool basicfire;
    private bool canshoot;
    public GameObject gun;
    public GameObject gun2;

    // Use this for initialization
    void Start()
    {
        canshoot = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Fire1") <= -0.1 && canshoot == false)
        {
            canshoot = true;
        }
        // rapid fire  
        if (Input.GetAxis("Fire1") > 0.5 && basicfire)
        {
            Instantiate(projectile, gun.transform.position, gun.transform.rotation);
            basicfire = false;
            Instantiate(projectile, gun2.transform.position, gun2.transform.rotation);
            basicfire = false;
        }

        if (Input.GetAxis("Fire1") <= 0.1 && basicfire == false)
        {
            basicfire = true;
        }
    }
}
