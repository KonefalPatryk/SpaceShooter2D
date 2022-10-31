using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rapidfire : MonoBehaviour
{
    public GameObject projectile;


    private bool rapidfire;
    private bool canshoot;
    public GameObject rapidfiregun;
    public GameObject rapidfiregungun2;

    // Use this for initialization
    void Start()
    {
        canshoot = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Fire1") >= -0.1 && canshoot == false)
        {
            canshoot = true;
        }
        // rapid fire  
        if (Input.GetAxis("Fire1") > 0.5 && rapidfire)
        {
            Instantiate(projectile, rapidfiregun.transform.position, rapidfiregun.transform.rotation);
            rapidfire = false;
            Instantiate(projectile, rapidfiregungun2.transform.position, rapidfiregungun2.transform.rotation);
            rapidfire = false;

        }

        if (Input.GetAxis("Fire1") >= 0.1 && rapidfire == false)
        {
            rapidfire = true;
        }
    }
}
