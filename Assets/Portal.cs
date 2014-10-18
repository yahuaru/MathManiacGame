﻿using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponentInChildren<TextMesh>().renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D c)
    {

            GetComponentInChildren<TextMesh>().renderer.enabled = true;
    }
}
