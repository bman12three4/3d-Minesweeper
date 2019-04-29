using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineController : MonoBehaviour {

	public bool isMine = false;
	public int number;

	public Material one; 

	// Use this for initialization
	void Start () {
		if (isMine) {
			this.GetComponent<Renderer>().material = Resources.Load<Material> ("numbers/Materials/mine");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnTriggerEntry(Collider col){
		
	}
}
