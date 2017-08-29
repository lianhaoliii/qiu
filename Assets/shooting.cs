using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {


    public GameObject bullet;
    public GameObject bulletSpawn;


    float countdown = -1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        countdown = countdown - Time.deltaTime;

        if (countdown<0) {
            countdown = 0.7f;

            GameObject obj = (GameObject)Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            obj.GetComponent<Rigidbody>().velocity = Vector3.left * 20;
            Destroy(obj, 7.0f);

        }
		
	}
}
