﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparent : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<MeshRenderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
