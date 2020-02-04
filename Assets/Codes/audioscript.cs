using UnityEngine;
using System.Collections;

public class audioscript : MonoBehaviour {
	static audioscript instance= null;

	void Start () {
		if (instance != null) {
			Destroy(gameObject);
			print("Detroyed gameobject");
		}

		else  {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}
}
