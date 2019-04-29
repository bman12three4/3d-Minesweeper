using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineController : MonoBehaviour {

	public bool isMine = false;
	public int number = 0;

	public int[] loc;

	public GameObject ray;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//number = getNumber ();
		if (number == 0){
			//Destroy (this.gameObject);	
		}
	}
		
	void OnTriggerEnter(Collider col){

		//number = getNumber ();


		if (col.gameObject.name != "number-ray(Clone)") {

			if (isMine) {
				this.GetComponent<Renderer> ().material = Resources.Load<Material> ("numbers/Materials/mine");
			} else {
				if (number == 0) {
					Destroy (this.gameObject);	
				} else if (number == 1) {
					this.GetComponent<Renderer> ().material = Resources.Load<Material> ("numbers/Materials/1");
				} else if (number == 2) {
					this.GetComponent<Renderer> ().material = Resources.Load<Material> ("numbers/Materials/2");
				} else if (number == 3) {
					this.GetComponent<Renderer> ().material = Resources.Load<Material> ("numbers/Materials/3");
				} else if (number > 3) {
					this.GetComponent<Renderer> ().material = Resources.Load<Material> ("numbers/Materials/flag");
				}
			}
		}
	}

	public void getNumber(){
		if (loc [0] > 0 && loc [0] < 10) {
			if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]-1, loc[1], loc[2]].GetComponent<MineController> ().isMine)
				number++;
			if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]+1, loc[1], loc[2]].GetComponent<MineController> ().isMine)
				number++;
			if (loc [1] > 0 && loc [1] < 10) {
				if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]-1, loc[1]-1, loc[2]].GetComponent<MineController> ().isMine)
					number++;
				if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]-1, loc[1]+1, loc[2]].GetComponent<MineController> ().isMine)
					number++;
				if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]+1, loc[1]-1, loc[2]].GetComponent<MineController> ().isMine)
					number++;
				if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]+1, loc[1]+1, loc[2]].GetComponent<MineController> ().isMine)
					number++;
				if (transform.parent.GetComponent<CreateMines> ().mines [loc[0], loc[1]-1, loc[2]].GetComponent<MineController> ().isMine)
					number++;
				if (transform.parent.GetComponent<CreateMines> ().mines [loc[0], loc[1]+1, loc[2]].GetComponent<MineController> ().isMine)
					number++;
				if (loc [2] > 0 && loc [2] < 10) {
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]-1, loc[1]-1, loc[2]-1].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]-1, loc[1], loc[2]-1].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]-1, loc[1]+1, loc[2]-1].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0], loc[1]-1, loc[2]-1].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0], loc[1], loc[2]-1].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0], loc[1]+1, loc[2]-1].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]+1, loc[1]-1, loc[2]-1].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]+1, loc[1], loc[2]-1].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]+1, loc[1]+1, loc[2]-1].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]-1, loc[1]-1, loc[2]].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]-1, loc[1], loc[2]].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]-1, loc[1]+1, loc[2]].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0], loc[1]-1, loc[2]].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0], loc[1], loc[2]].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0], loc[1]+1, loc[2]].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]+1, loc[1]-1, loc[2]].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]+1, loc[1], loc[2]].GetComponent<MineController> ().isMine)
						number++;
					if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]+1, loc[1]+1, loc[2]].GetComponent<MineController> ().isMine)
						number++;
				}
			}
		}

		if (number == 0)
			Destroy (this.gameObject);


			
	}
}
