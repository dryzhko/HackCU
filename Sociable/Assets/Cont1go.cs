﻿using UnityEngine;
using System.Collections;

public class Cont1go : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey("4"))
			Application.LoadLevel("Cont1");
	
	}
}
