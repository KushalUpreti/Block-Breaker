using UnityEngine.Audio;
using UnityEngine;

public class ball : MonoBehaviour {
	public paddlescript paddle;
	private Vector3 PaddleToBallVector;
	private bool start = false;
	private int limit = 0;
	public float xforce;
	public float yforce;
	public AudioSource audio;





	void Start () {
		PaddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (start != true) {
			this.transform.position = paddle.transform.position + PaddleToBallVector;
		} 

		if (Input.GetMouseButtonDown(0)) {
			start = true;
			float apple = Random.Range (1, 3);

			while (limit < 1) {
				if (apple == 1) {
					this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (xforce, yforce);
					limit = limit + 1;
				} 

				else if (apple == 2) {
					this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-xforce, yforce);
					limit = limit + 1;
				}


				}
				
			}
		}

	 void OnCollisionEnter2D(Collision2D collide){
		if (start) {
			audio.Play ();
		}
	}
}