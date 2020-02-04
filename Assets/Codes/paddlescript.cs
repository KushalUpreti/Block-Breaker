using UnityEngine;

public class paddlescript : MonoBehaviour {
	public float speed;
	public float minX;
	public float maxX;

	void Update () {
		

		if (Input.GetKey (KeyCode.A)) {
			transform.position = transform.position - new Vector3 (speed*Time.deltaTime, 0, 0);
		}

		else if (Input.GetKey (KeyCode.D)) {
			transform.position = transform.position - new Vector3 (-speed*Time.deltaTime, 0, 0);
		}

		float newX = Mathf.Clamp (transform.position.x, minX, maxX);
		transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
	}
}
 