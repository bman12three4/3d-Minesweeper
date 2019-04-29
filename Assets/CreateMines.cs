﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMines : MonoBehaviour {

	public GameObject mine;
	public GameObject invisibleMine;
	public GameObject[,,] mines = new GameObject[12,12,12];

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 12; i++){
			for (int j = 0; j < 12; j+=){
				if ((i == 0 || i == 11) || (j == 0 || j == 11)){
					mines[i,j,k] = Instantiate (invisibleMine, new Vector3 (i * 2, j * 2, k * 2), Quaternion.identity);
				} else {
					mines[i,j,k] = Instantiate (mine, new Vector3 (i * 2, j * 2, k * 2), Quaternion.identity);
				}
				mines [i, j, k].transform.parent = this.transform;
				int[] loc = { i, j, k };
				mines [i, j, k].GetComponent<MineController> ().loc = loc;
			}
		}

		for (int i = 1; i < 11; i++) {
			int[] coords = rand ();
			bool cont = false;
			while (!cont) {
				if (mines [coords [0], coords [1], coords [2]].GetComponent<MineController> ().isMine) {
					cont = false;
				} else {
					cont = true;
				}
			}
			mines [coords [0], coords [1], coords [2]].GetComponent<MineController> ().isMine = true;
		}
		//mines [0, 0, 0].GetComponent<MineController> ().getNumber ();



		foreach (GameObject mine in mines) {
			
			mine.GetComponent<MineController> ().getNumber ();

			/*
			if (mine.GetComponent<MineController> ().getNumber() == 0) {
				Debug.Log ("Destroying empty mine");
				Destroy (mine);
			}
			*/
		}
			


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	int[] rand(){
		int x = Random.Range(1, 11);
		int y = Random.Range(1, 11);
		int z = Random.Range(1, 11);

		int[] ret = { x, y, z };
		return ret;
	}
}
