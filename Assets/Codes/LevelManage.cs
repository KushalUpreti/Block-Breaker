using UnityEngine;
using System.Collections;

public class LevelManage : MonoBehaviour {
	public LevelManage levelmanager;

	public void menu(string x){
		Application.LoadLevel (x);
	}

	public void game(string y){
		Application.LoadLevel (y);
	}

	public void quit(string z){
		Application.Quit ();

	}

	public void credit(string c){
		Application.LoadLevel (c);
	}

	public void backfromc(string b){
		Application.LoadLevel (b);
	}

	public void SelectLevel(string s){
		Application.LoadLevel (s);
	}

	public void two (string t){
		Application.LoadLevel (t);
	}

	public void three(string th){
		Application.LoadLevel (th);
	}
		
	public void brickdestroyed(){
		if (destroyScript.brickcount <=0 ) {
			Application.LoadLevel (Application.loadedLevel + 1);

		}
	}
}
