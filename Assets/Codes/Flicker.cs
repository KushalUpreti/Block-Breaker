using UnityEngine.UI;
using UnityEngine;

public class Flicker : MonoBehaviour {
	public Text text;
	private float lol;
	private int lmao;

	void Update () {
		timeelapsed ();
		if (lmao % 2 == 0) {
			text.text = "Press Any Key To Continue";
		}
		else{
			text.text = ".";
		}
	}

	void timeelapsed(){
		lol = Time.timeSinceLevelLoad;
		lmao=Mathf.RoundToInt (lol);
	}
}
