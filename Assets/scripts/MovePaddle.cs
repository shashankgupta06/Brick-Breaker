using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour {


	private Rigidbody2D rb;
	public int speed = 10;
	public static bool launched_Ball = false;
	
	void Start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {	
			
			if(!BallLogic.canMoveFreely )
				BallLogic.moveLeft = true;
			
			rb.velocity = new Vector2 (-speed, 0);

		} else if (Input.GetKey (KeyCode.RightArrow)) {

			if(!BallLogic.canMoveFreely)
				BallLogic.moveLeft = false;
			
			rb.velocity = new Vector2 (speed, 0);

		} else {
			rb.velocity = new Vector2 (0f, 0);
		}

		if (Input.GetKeyDown (KeyCode.Space) && launched_Ball==false) {
			BallLogic.canMoveFreely = true;
			launched_Ball = true;
		}
	}
}
