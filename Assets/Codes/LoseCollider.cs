using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
	
	
	void OnTriggerEnter2D (Collider2D trigger){
		Application.LoadLevel ("Lose");
		destroyScript.brickcount = 0;
	}
}