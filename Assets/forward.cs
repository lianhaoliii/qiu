using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forward : MonoBehaviour {
    float counter = 0;
    bool down = false;

    public GameObject ground;

    bool getKey=false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (getKey)
        {

            if (counter < 300)
            {

                ground.transform.Translate(Vector3.right * Time.deltaTime * 1.3f, Space.World);
                counter++;


            }

            if (counter == 300)
            {

                counter = counter + 1;

            }


            if (counter > 300 && counter < 600)
            {

                ground.transform.Translate(Vector3.left * Time.deltaTime * 1.3f, Space.World);
                counter++;

            }

            if (counter == 600)
            {

                counter = 0;

            }

        }


    }



    void OnTriggerEnter(Collider other) {
        getKey = true;

    }





}
