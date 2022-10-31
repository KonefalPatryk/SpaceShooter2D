using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int maxHP;
    private int currentHP;
    public GameObject explosion;

    // Use this for initialization
    void Start ()
    {
        currentHP = maxHP;
	}
	
	// Update is called once per frame
	private void Update ()
    {
		if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void DecreaseHealth(int damage)
    {
        currentHP -= damage;
    }

    public void IncreaseHealth(int health)
    {
        currentHP += health;
    }
}
