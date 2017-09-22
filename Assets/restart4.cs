using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class restart4 : MonoBehaviour
{

    float currentY;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        currentY = transform.position.y;

        if (currentY < -5)
        {
            SceneManager.LoadScene("scene4", LoadSceneMode.Single);
        }

    }





}

