using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaimen : MonoBehaviour
{
    float counter = 0;
    bool down = false;


    public Transform player;

    public GameObject men;

    bool kai = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (kai)
        {

            if (counter < 300)
            {

                men.transform.Translate(Vector3.up * Time.deltaTime * 1.3f, Space.World);
                counter++;


            }

         



        }


    }



    void OnTriggerEnter(Collider other)
    {
        kai = true;

    }





}
