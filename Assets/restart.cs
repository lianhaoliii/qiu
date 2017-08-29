using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{

    float currentY ;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentY = transform.position.y;
        if (currentY < -4.2 )
        {
            SceneManager.LoadScene("scene1", LoadSceneMode.Single);



        }





    }
}