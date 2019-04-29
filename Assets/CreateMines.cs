using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMines : MonoBehaviour {

	public GameObject mine;
	public Material number;

	// Use this for initialization
	void Start () {

		GameObject[,,] mines = new GameObject[10,10,10];
		
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				for (int k = 0; k < 10; k++) {
					Debug.Log ("Creating Mine");
					mines[i,j,k] = Instantiate (mine, new Vector3 (i * 2, j * 2, k * 2), Quaternion.identity);
					mines [i, j, k].GetComponent<Renderer>().material = number;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
