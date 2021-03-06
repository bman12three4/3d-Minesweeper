﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float MoveSpeed = 75f;
	public GameObject ray;
	public GameObject flag;
	public int[] loc;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		if (Input.GetKey(KeyCode.W))
			transform.eulerAngles = transform.eulerAngles + Vector3.right * MoveSpeed * Time.deltaTime;
		else if (Input.GetKey(KeyCode.S))
			transform.eulerAngles = transform.eulerAngles + -Vector3.right * MoveSpeed * Time.deltaTime;

		if (Input.GetKey(KeyCode.A))
			transform.eulerAngles = transform.eulerAngles + -Vector3.up * MoveSpeed * Time.deltaTime;
		else if (Input.GetKey(KeyCode.D))
			transform.eulerAngles = transform.eulerAngles + Vector3.up * MoveSpeed * Time.deltaTime;

		if (Input.GetMouseButtonDown(0)) {
			Instantiate (ray, this.transform.position, this.transform.rotation);
		}

		if (Input.GetKey(KeyCode.F))
			Instantiate (flag, this.transform.position, this.transform.rotation);

		transform.Translate(Vector3.forward * Input.mouseScrollDelta.y * MoveSpeed * Time.deltaTime);


	}
}