using UnityEngine;
using System.Collections;

public class pregame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("2")) {
			Application.LoadLevel ("pregame");
		}
		if (Input.GetKey("escape")){
			Application.Quit();}
	
	}
}
