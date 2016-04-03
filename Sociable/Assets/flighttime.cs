using UnityEngine;
using System.Collections;

public class flighttime : MonoBehaviour {

	// Use this for initialization
	IEnumerator MyMethod() {
		
		yield return new WaitForSeconds(30);
		Application.LoadLevel ("classroom");
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine ("MyMethod");
	
	}
}
