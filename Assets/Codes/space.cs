using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class space : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			Application.LoadLevel("Menu");
		}
	}
}
