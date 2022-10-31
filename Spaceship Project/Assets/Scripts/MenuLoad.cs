using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoad : MonoBehaviour
{
    void Start () {

    }

    void Update () {

    }

    public void LoadTheLevel(string levelName) {
        SceneManager.LoadScene(levelName);
    }
}