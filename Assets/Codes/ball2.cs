using UnityEngine;

public class ball2 : MonoBehaviour {
	public AudioSource audios;
	private int limit = 0;
	public float xforce;
	public float yforce;

	void OnCollisionEnter2D(Collision2D collide){
		audios.Play ();

	}

	void Update () {
		while (limit < 1) {

			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (xforce, yforce);
			limit = limit + 1;

		}

	}
}
