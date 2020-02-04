using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingpong : MonoBehaviour {
	private bool isright = true;
	public float speed;
	public float xmin;
	public float xmax;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isright) {
			transform.position = transform.position + new Vector3 (speed * Time.deltaTime, 0, 0);
		}

		else {
			transform.position = transform.position + new Vector3 (-speed* Time.deltaTime, 0, 0);
		}

		if (transform.position.x <= xmin || transform.position.x >= xmax) {
			isright = !isright;
			Debug.Log (isright);
		}
	}
}
