using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMines : MonoBehaviour {

	public GameObject mine;

	public int xSize = 6;
	public int ySize = 6;
	public int zSize = 6;
	public GameObject[,,] mines;

	public int numMines = 100;

	// Use this for initialization
	void Start () {

		mines = new GameObject[xSize,ySize,zSize];

		for (int i = 0; i < xSize; i++){ // change this back to 12
			for (int j = 0; j < ySize; j++){
				for (int k = 0; k < zSize; k++){
					mines[i,j,k] = Instantiate (mine, new Vector3 (i * 2, j * 2, k * 2), Quaternion.identity);
					mines [i, j, k].transform.parent = this.transform;
					int[] loc = { i, j, k };
					mines [i, j, k].GetComponent<MineController> ().loc = loc;
					//mines [i, j, k].GetComponent<MineController> ().checkd = true;
				}
			}
		}

		for (int i = 0; i < numMines; i++) {
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
		int x = Random.Range(0, xSize);
		int y = Random.Range(0, ySize);
		int z = Random.Range(0, zSize);

		int[] ret = { x, y, z };
		return ret;
	}
}
