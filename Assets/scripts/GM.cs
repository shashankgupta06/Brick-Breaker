using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {
	public Text score_count;
	public GameObject life;
	public Text level_count;
	public GameObject level2LoadingScreen;
	public GameObject level3LoadingSCreen;
	public GameObject paddle;
	public GameObject ball;
	public static int nextLife = 100;
	public static int score;
	public static int lives = 3;
	public static int level = 1;
	public static int block_count=0;
	private float seconds = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {                          
		

		if (block_count == 0) {                                     //level switch

			seconds += Time.deltaTime;

			if (level == 1) {
				level2LoadingScreen.SetActive (true);
			}

			if (level == 2) {

				level3LoadingSCreen.SetActive (true);
				paddle.SetActive (false);
				ball.SetActive (false);
			}
			if (seconds >= 4) {
				level++;
				MovePaddle.launched_Ball = false;
				SceneManager.LoadScene (level);
			}
		} else
			seconds = 0f;




		if (score >= nextLife) {
			lives++;
			nextLife = score + 100;
			switch (lives) {

			case 6:
				lives = 5;
				break;

			case 5:

				GameObject newLife5 = Instantiate (life);
				newLife5.transform.parent = (GameObject.Find ("LifeBar")).transform;
				newLife5.name = "lives (4)";
				break;

			case 4:
				
				GameObject newLife4 = Instantiate (life);
				newLife4.transform.parent = (GameObject.Find ("LifeBar")).transform;
				newLife4.name = "lives (3)";
				break;

			case 3:
				GameObject newLife3 = Instantiate (life);
				newLife3.transform.parent = (GameObject.Find ("LifeBar")).transform;
				newLife3.name = "lives (2)";
				break;

			case 2:
				GameObject newLife2 = Instantiate (life);
				newLife2.transform.parent = (GameObject.Find ("LifeBar")).transform;
				newLife2.name = "lives (1)";
				break;

			case 1:
				GameObject newLife1 = Instantiate (life);
				newLife1.transform.parent = (GameObject.Find ("LifeBar")).transform;
				newLife1.name = "lives (0)";
				break;
			}
		}

		score_count.text = score.ToString ();
		level_count.text = level.ToString ();
	


   }
}
