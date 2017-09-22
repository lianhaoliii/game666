using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class close : MonoBehaviour {

    public Transform playerTransform;
    public float dist;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        dist = Vector3.Distance(playerTransform.position, gameObject.transform.position);

        if (dist < 0.8) {
            SceneManager.LoadScene("scene2", LoadSceneMode.Single);
        }

	}
}
