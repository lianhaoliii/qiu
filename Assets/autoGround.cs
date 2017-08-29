using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoGround : MonoBehaviour {

    float counter = 0;
    bool down = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (counter < 300  )
        {
          
            transform.Translate(Vector3.up * Time.deltaTime*1.3f, Space.World);
            counter++;


        }

        if (counter == 300) {

            counter=counter + 1;

        }


        if (counter > 300 && counter <600)
        {

            transform.Translate(Vector3.down * Time.deltaTime*1.3f, Space.World);
            counter++;

        }

          if (counter == 600)
            {

            counter = 0;

            }







    }
}
