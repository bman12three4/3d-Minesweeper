using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Debug.Log ("Ray Created");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * 50f * Time.deltaTime);
		Debug.Log (this.transform.position);
	}

	void OnTriggerEnter(Collider col){
		Debug.Log ("Hitting something (ray)");
		Destroy (this.gameObject);
	}
}
