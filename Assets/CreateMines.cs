using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMines : MonoBehaviour {

	public GameObject mine;
	public GameObject[,,] mines = new GameObject[10,10,10];

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 10; i++){ // change this back to 12
			for (int j = 0; j < 10; j++){
				for (int k = 0; k < 10; k++){
					mines[i,j,k] = Instantiate (mine, new Vector3 (i * 2, j * 2, k * 2), Quaternion.identity);
					mines [i, j, k].transform.parent = this.transform;
					int[] loc = { i, j, k };
					mines [i, j, k].GetComponent<MineController> ().loc = loc;
				}
			}
		}

		for (int i = 0; i < 500; i++) {
			int[] coords = rand ();
			bool cont = false;
			while (!cont) {
				if (mines [coords [0], coords [1], coords [2]].GetComponent<MineController> ().isMine) {
					cont = false;
					coords = rand ();
				} else {
					cont = true;
				}
			}
			mines [coords [0], coords [1], coords [2]].GetComponent<MineController> ().isMine = true;
			//Debug.Log("Debug");
			//Debug.Log(coords [0] + " " + coords [1] + " " + coords [2]);
		}
		//mines [0, 0, 0].GetComponent<MineController> ().getNumber ();
			


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	int[] rand(){
		int x = Random.Range(0, 10);
		int y = Random.Range(0, 10);
		int z = Random.Range(0, 10);

		int[] ret = { x, y, z };
		return ret;
	}
}
