using UnityEngine;

public class destroyScript : MonoBehaviour {

	public static int brickcount = 0;
	private LevelManage levelmanager;
	private int Timeshit;
	public int hitlimit;
	private bool isbreakable;

	void Start(){
		isbreakable = (this.tag == "Breakable");
		if (isbreakable) {
			brickcount++;
			print (brickcount);
		}
		Timeshit = 0;
		levelmanager = GameObject.FindObjectOfType<LevelManage> ();
	}

	void OnCollisionEnter2D(Collision2D Collide){
		if (isbreakable) {
			handlehits ();

	}
}

	void handlehits(){
		Timeshit++;

		if (Timeshit >= hitlimit) {
			brickcount--;
			print (brickcount);
			levelmanager.brickdestroyed();
			Destroy (gameObject);
		}
	}


	void Update(){
		
		}
	}
	