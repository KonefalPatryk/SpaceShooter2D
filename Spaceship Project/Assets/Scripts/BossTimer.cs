using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTimer : MonoBehaviour {

    public float targetTime = 3.0f;
    public GameObject enemygun;
    public GameObject enemygun2;
    public GameObject projectile;
    private bool canshoot;



    //public Text display;


    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;

        // display.text = Mathf.RoundToInt(targetTime) + "";

        if (targetTime <= 0.0f)
        {
            timerEnd();
        }
    }

    void timerEnd()
    {
        targetTime = 3.0f;
        Instantiate(projectile, enemygun.transform.position, enemygun.transform.rotation);
        Instantiate(projectile, enemygun2.transform.position, enemygun2.transform.rotation);
    }
}
