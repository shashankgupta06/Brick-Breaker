using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLogic : MonoBehaviour {
	private Rigidbody2D rb;
	public float ballSpeed;
	public static bool canMoveFreely = false;
	public static bool moveLeft = true;

	void Start(){
	
		rb = GetComponent<Rigidbody2D> ();
		rb.isKinematic = true;



	}
	
	// Update is called once per frame
	void Update () {

		Vector2 speed;
		speed.x = 0f;
		speed.y = 0f;

		if (canMoveFreely) {

			rb.isKinematic = false;

			if (moveLeft) {
				speed.x = -5f;
				speed.y = 5f;
			} 

			if (!moveLeft) {
				speed.x = 5f;
				speed.y = 5f;
			}

		

			rb.velocity = new Vector2 (speed.x, speed.y);


		
		}	

		canMoveFreely = false;

		if (MovePaddle.launched_Ball) {                                               //this makes sure ball bounces at desired angles!

			if (rb.velocity.x > 0f && rb.velocity.x != ballSpeed) {
				speed.x = ballSpeed;
				rb.velocity = new Vector2 (speed.x, rb.velocity.y);
			}

			if (rb.velocity.x < 0f && rb.velocity.x != -ballSpeed) {
				speed.x = -ballSpeed;
				rb.velocity = new Vector2 (speed.x, rb.velocity.y);
			}

			if (rb.velocity.y > 0f && rb.velocity.y != ballSpeed) {
				speed.y = ballSpeed;
				rb.velocity = new Vector2 (rb.velocity.x, speed.y);
			}

			if (rb.velocity.y < 0f && rb.velocity.y != -ballSpeed) {
				speed.y = -ballSpeed;
				rb.velocity = new Vector2 (rb.velocity.x, speed.y);
			}
		}

	}



	void OnTriggerEnter2D(Collider2D hit){
		
		if (hit.gameObject.name == "Bottom") {
			
			if(GM.block_count!=0)
			GM.lives--;	

			switch (GM.lives) {

			case 4:
				Destroy (GameObject.Find("lives (4)"));
					break;

			case 3:
				Destroy(GameObject.Find("lives (3)"));
						break;

			case 2:
				Destroy(GameObject.Find("lives (2)"));
						break;

			case 1:
				Destroy(GameObject.Find("lives (1)"));
				break;

			case 0:
				Destroy (GameObject.Find ("lives (0)"));
				Debug.Log ("GAME OVER");
				break;
			}


			rb.isKinematic = true;
			rb.velocity = new Vector2 (0f, 0f);
			transform.localPosition = new Vector3 (-40f, 0f, 0f);

			MovePaddle.launched_Ball = false;
		
		}

	}

}
