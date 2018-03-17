using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lives : MonoBehaviour {
	public GameObject life;
	// Use this for initialization
	void Start () {
		switch (GM.lives) {

		case 6:
			GM.lives = 5;
			break;

		case 5:                                                                            //code needs a clean up!
			GameObject newLife5 = Instantiate (life);
			newLife5.transform.parent = (GameObject.Find ("LifeBar")).transform;            //chunk of code makes sure live sprites are passed over 
			newLife5.name = "lives (4)";        											//when level switches!
			GameObject newLife4 = Instantiate (life);
			newLife4.transform.parent = (GameObject.Find ("LifeBar")).transform;
			newLife4.name = "lives (3)";
			GameObject newLife3 = Instantiate (life);
			newLife3.transform.parent = (GameObject.Find ("LifeBar")).transform;
			newLife3.name = "lives (2)";
			GameObject newLife2 = Instantiate (life);
			newLife2.transform.parent = (GameObject.Find ("LifeBar")).transform;
			newLife2.name = "lives (1)";
			GameObject newLife1 = Instantiate (life);
			newLife1.transform.parent = (GameObject.Find ("LifeBar")).transform;
			newLife1.name = "lives (0)";
			break;

		case 4:
			GameObject C4newLife4 = Instantiate (life);
			C4newLife4.transform.parent = (GameObject.Find ("LifeBar")).transform;
			C4newLife4.name = "lives (3)";
			GameObject C4newLife3 = Instantiate (life);
			C4newLife3.transform.parent = (GameObject.Find ("LifeBar")).transform;
			C4newLife3.name = "lives (2)";
			GameObject C4newLife2 = Instantiate (life);
			C4newLife2.transform.parent = (GameObject.Find ("LifeBar")).transform;
			C4newLife2.name = "lives (1)";
			GameObject C4newLife1 = Instantiate (life);
			C4newLife1.transform.parent = (GameObject.Find ("LifeBar")).transform;
			C4newLife1.name = "lives (0)";
			break;

		case 3:
			GameObject C3newLife3 = Instantiate (life);
			C3newLife3.transform.parent = (GameObject.Find ("LifeBar")).transform;
			C3newLife3.name = "lives (2)";
			GameObject C3newLife2 = Instantiate (life);
			C3newLife2.transform.parent = (GameObject.Find ("LifeBar")).transform;
			C3newLife2.name = "lives (1)";
			GameObject C3newLife1 = Instantiate (life);
			C3newLife1.transform.parent = (GameObject.Find ("LifeBar")).transform;
			C3newLife1.name = "lives (0)";
			break;

		

		case 2:
		GameObject C2newLife2 = Instantiate (life);
		C2newLife2.transform.parent = (GameObject.Find ("LifeBar")).transform;
		C2newLife2.name = "lives (1)";
		GameObject C2newLife1 = Instantiate (life);
		C2newLife1.transform.parent = (GameObject.Find ("LifeBar")).transform;
		C2newLife1.name = "lives (0)";
		break;

		case 1:
			GameObject C1newLife1 = Instantiate (life);
			C1newLife1.transform.parent = (GameObject.Find ("LifeBar")).transform;
			C1newLife1.name = "lives (0)";
			break;
	
	}
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
