using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Script : MonoBehaviour {

    public float speed;
    Vector3 startPos;


    void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((new Vector3(0, 1, 0)) * speed * Time.deltaTime);
        if (transform.position.x <= -11.28) transform.position = startPos;
	}
}
