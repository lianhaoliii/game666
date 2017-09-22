using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene1 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("scene2", LoadSceneMode.Single);

    }


}
