using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTrue : MonoBehaviour {

	public GameObject objectToActivate;


 // with the "2D" at the end it makes it compatable in a 2d scene instead of 3d
	void OnTriggerEnter2D (Collider2D theCollider){
		if (theCollider.gameObject.tag == "Player") {
			objectToActivate.SetActive (true);
		}
	}
}