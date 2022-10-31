using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFalse : MonoBehaviour {

	public GameObject objectToActivate;

	void OnTriggerEnter2D (Collider2D theCollider){
		if (theCollider.gameObject.tag == "Player") {
			objectToActivate.SetActive (false);
		}
	}
}