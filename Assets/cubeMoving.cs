using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMoving : MonoBehaviour {

    float counter = 0;
    bool down = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (counter < 100)
        {

            transform.Translate(Vector3.left * Time.deltaTime * 1.5f, Space.World);
            counter++;


        }

        if (counter == 100)
        {

            counter = counter + 1;

        }


        if (counter > 100 && counter < 200)
        {

            transform.Translate(Vector3.right * Time.deltaTime * 1.5f, Space.World);
            counter++;

        }

        if (counter == 200)
        {

            counter = 0;

        }







    }
}
