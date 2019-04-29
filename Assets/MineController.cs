using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineController : MonoBehaviour {

	public bool isMine = false;
	public int number;

	public Material one; 

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnTriggerEnter(Collider col){
		if (isMine) {
			this.GetComponent<Renderer> ().material = Resources.Load<Material> ("numbers/Materials/mine");
		} else {
			switchr
		}
	}

	int getNumber(){

		int number = 0;

		for (int i = transform.position.x / 2 - 1; i < transform.position.x / 2 + 1; i++) {
			if (i > 0 && i < 10) {
				for (int j = transform.position.y / 2 - 1; j < transform.position.y / 2 + 1; j++) {
					if (j > 0 && j < 10) {
						for (int k = transform.position.z / 2 - 1; i < transform.position.z / 2 + 1; k++) {
							if (k > 0 && k < 10) {
								if (transform.parent.GetComponent<CreateMines> ().mines [i, j, k].GetComponent<MineController> ().isMine)
									number++;
							}
						}
					}
				}
			}
		}
	}
}
