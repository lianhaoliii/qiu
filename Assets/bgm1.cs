using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm1 : MonoBehaviour {

    private GameObject[] music;

    // Use this for initialization
    void Start()

    {
        music = GameObject.FindGameObjectsWithTag("gameMusic");
        Destroy(music[0]);
    }

    // Update is called once per frame
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
