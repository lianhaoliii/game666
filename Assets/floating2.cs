using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating2 : MonoBehaviour
{

    public GameObject level;
    float currentY;
    float counter = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //     level.GetComponent<Rigidbody>().velocity = Vector3.up ;

        currentY = transform.position.y;

        if (currentY < 0 && counter < 200)
        {
            level.transform.Translate(Vector3.up * Time.deltaTime * 0.30f, Space.World);
            counter++;
        }



    }



}
