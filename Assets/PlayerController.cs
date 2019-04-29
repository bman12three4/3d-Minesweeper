using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	float MoveSpeed = 30f;
	public GameObject ray;
	public int[] loc;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		//w-s is x axis
		//q-e is z axis
		//a-d is y axis

		if (Input.GetKey(KeyCode.W))
			transform.eulerAngles = transform.eulerAngles + Vector3.right * MoveSpeed * Time.deltaTime;
		else if (Input.GetKey(KeyCode.S))
			transform.eulerAngles = transform.eulerAngles + -Vector3.right * MoveSpeed * Time.deltaTime;

		/*
		if (Input.GetKey(KeyCode.W))
			transform.Translate(Vector3.forward * MoveSpeed/10 * Time.deltaTime);
		else if (Input.GetKey(KeyCode.S))
			transform.Translate(-Vector3.forward * MoveSpeed/10 * Time.deltaTime);

		*/

		if (Input.GetKey(KeyCode.A))
			transform.eulerAngles = transform.eulerAngles + -Vector3.up * MoveSpeed * Time.deltaTime;
		else if (Input.GetKey(KeyCode.D))
			transform.eulerAngles = transform.eulerAngles + Vector3.up * MoveSpeed * Time.deltaTime;

		if (Input.GetMouseButtonDown (0)) {
			Instantiate (ray, this.transform.position, this.transform.rotation);
		}

		transform.Translate(Vector3.forward * Input.mouseScrollDelta.y * MoveSpeed * Time.deltaTime);


	}
}