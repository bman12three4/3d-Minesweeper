using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Ray created");
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * 5f * Time.deltaTime);
	}

	void OnTriggerEnter(){
		Destroy (this.gameObject);
	}


}
