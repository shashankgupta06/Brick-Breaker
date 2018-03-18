using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Controller : MonoBehaviour {

	private int block_health = 1;	

	// Use this for initialization
	void Start () {
		GM.block_count++;

		switch (gameObject.tag) {

		case "RedBrick":
			block_health = 1;
			break;

		case "YellowBrick":
			block_health = 2;
			break;




		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D (Collision2D hit){

		if (hit.gameObject.name == "Ball")
			block_health--;


	}

	void OnCollisionExit2D (Collision2D hit){

		if(block_health <=0){
			GM.block_count--;
			Destroy (gameObject);
			GM.score += 5;
		}
	}
}
