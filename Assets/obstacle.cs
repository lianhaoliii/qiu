using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour {
    float counter = 0;
    bool go = false;

    public GameObject ground;

    // Use this for initialization
    void Start()
    {

        if (counter < 300 && go)
        {

            ground.transform.Translate(Vector3.up * Time.deltaTime * 1.3f, Space.World);
            counter++;

        }

    }



void OnTriggerEnter(Collider other)
    {
        go = true;

    }





}
