using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class noDestroy2 : MonoBehaviour
{
    string sceneName;
    Scene currentScene;


    public void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }


    }



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        currentScene = SceneManager.GetActiveScene();

        sceneName = currentScene.name;

        if (sceneName == "scene4")
        {
            Destroy(gameObject);
        }




    }
}
