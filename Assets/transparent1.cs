using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparent1 : MonoBehaviour {



    IEnumerator ChangeColor()
    {
        gameObject.GetComponent<Renderer>().material.SetFloat("_Mode", 3);
        yield return null;
        Color a = Color.blue;
        a.a = 0f;
        gameObject.GetComponent<Renderer>().material.color = a;
    }


}
