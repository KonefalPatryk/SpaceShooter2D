using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour {


    public Animator animationTree;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animationTree.SetTrigger("Play");
        }
    }
}