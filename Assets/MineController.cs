using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineController : MonoBehaviour
{

    public bool isMine = false;
    public int number = 0;

    public bool invisible = false;
	public bool checkd = false;

    public int[] loc;

    // Use this for initialization
    void Start()
    {
        if (isMine)
        {
            this.GetComponent<Renderer>().material = Resources.Load<Material>("numbers/Materials/mine");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //number = getNumber ();
        if (number == 0)
        {
            //Destroy (this.gameObject);	
        }

        if (invisible)
        {
            this.GetComponent<Renderer> ().enabled = false;
			this.GetComponent<Collider> ().enabled = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {

        getNumber();

        UnityEngine.Debug.Log(number);

    }

    public void getNumber()
    {
		if (!checkd) {
			Debug.Log (loc [0] + " " + loc [1] + " " + loc [2]);
			
			checkd = true;

			try {
				if (!transform.parent.GetComponent<CreateMines> ().mines [loc [0] + 1, loc [1], loc [2]].GetComponent<MineController> ().checkd)
				if (transform.parent.GetComponent<CreateMines> ().mines [loc [0] + 1, loc [1], loc [2]].GetComponent<MineController> ().check ())
					number++;
			} catch {
				Debug.Log ("error");
			}

			try {
				if (!transform.parent.GetComponent<CreateMines> ().mines [loc [0] - 1, loc [1], loc [2]].GetComponent<MineController> ().checkd)
				if (transform.parent.GetComponent<CreateMines> ().mines [loc [0] - 1, loc [1], loc [2]].GetComponent<MineController> ().check ())
					number++;
			} catch {
				Debug.Log ("error");
			}
			



			if (isMine) {
				this.GetComponent<Renderer> ().material = Resources.Load<Material> ("numbers/Materials/mine");
			} else {
				if (number == 0) {
					Debug.Log (" destroy me");
					invisible = true;
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

    public bool check()
    {
		if (!isMine) {
			Debug.Log ("Checking");
			if (!checkd) {
				getNumber ();
				checkd = true;
			}
			if (number == 0)
				invisible = true;
		}
        return isMine;
    }
}
