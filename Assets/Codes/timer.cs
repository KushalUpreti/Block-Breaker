using UnityEngine.UI;
using UnityEngine;

public class timer : MonoBehaviour {
	public Text texts;
	private float lol;
	private int lmao;
	public int timelimit;


	void Update () {
		abc ();
		whileloop ();
		rip ();
	}

	void whileloop(){
		if (lmao != timelimit) {
			texts.text = lmao + "/" + timelimit;
		}
	}

		void abc(){
		lol = Time.timeSinceLevelLoad;
			lmao=Mathf.RoundToInt (lol);
	}


	void rip(){
		if (lmao == timelimit) {
			texts.text = "time up ";
			Application.LoadLevel(Application.loadedLevel + 1);
		}
	}
}
