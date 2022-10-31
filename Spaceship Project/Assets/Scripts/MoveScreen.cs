using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScreen : MonoBehaviour
{

    public float speed;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
