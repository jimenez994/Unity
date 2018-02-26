using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {
	int health = 100;
	bool gameOver = false;

	// Use this for initialization
	void Start () {
		if (health <= 0) {
			gameOver = true;
		}

		if(gameOver == true ){
			Debug.Log ("The game is Over!");
		}else{
			Debug.Log ("You're still alive buddy!");
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
