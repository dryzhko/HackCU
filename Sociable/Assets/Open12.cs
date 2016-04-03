using UnityEngine;
using System.Collections;

public class Open12 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey("2"))
			Application.LoadLevel("say1");
	
	}
}
