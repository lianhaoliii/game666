using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class restart2 : MonoBehaviour {

    float currentY;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        currentY = transform.position.y;

        if (currentY < -4.5)
        {
            SceneManager.LoadScene("scene2", LoadSceneMode.Single);
        }

    }




        
    }

