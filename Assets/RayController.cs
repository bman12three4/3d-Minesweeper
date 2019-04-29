using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * 50f * Time.deltaTime);

		if (Vector3.Distance (transform.position, new Vector3 (0, 0, 0)) > 300)
			Destroy (this.gameObject);
	}

	void OnTriggerEnter(Collider col){
		Destroy (this.gameObject);
	}
}
