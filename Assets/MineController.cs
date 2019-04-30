using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineController : MonoBehaviour
{

	public Material blank;
    public bool isMine = false;
    public int number = 0;

    public bool invisible = false;
    public bool checkd = false;

	public bool flagged = false;

    public int[] loc;

    // Use this for initialization
    void Start()
    {

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
            this.GetComponent<Renderer>().enabled = false;
            this.GetComponent<Collider>().enabled = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ray(Clone)")
        {

            if (isMine)
            {
                this.GetComponent<Renderer>().material = Resources.Load<Material>("numbers/Materials/mine");
				
            }
            else
            {
                getNumber();
            }

        } else if (col.gameObject.name == "flagray(Clone)"){
			if (!flagged){
				checkd = true;
				flagged = true;
				this.GetComponent<Renderer>().material = Resources.Load<Material>("numbers/Materials/flag");
			} else {
				checkd = false;
				flagged = false;
				this.GetComponent<Renderer>().material = blank;
			}
		}

    }

    public void getNumber()
    {
        if (!checkd)
        {

            checkd = true;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    for (int k = -1; k <= 1; k++)
                    {
                        if (!(i == 0 && j == 0 && k == 0))
                        {
                            try
                            {
                                if (!transform.parent.GetComponent<CreateMines>().mines[loc[0] + i, loc[1] + j, loc[2] + k].GetComponent<MineController>().checkd)
                                    if (transform.parent.GetComponent<CreateMines>().mines[loc[0] + i, loc[1] + j, loc[2] + k].GetComponent<MineController>().check())
                                    {
                                        number++;
                                        Debug.Log("Adding mine...");
                                    }
                            }
                            catch
                            {
                                //Debug.Log("error");
                            }
                        }
                    }
                }
            }

            if (isMine)
            {
                this.GetComponent<Renderer>().material = Resources.Load<Material>("numbers/Materials/mine");
            }
            else
            {
                if (number == 0)
                {
                    Debug.Log(" destroy me");
                    invisible = true;
                }
                else if (number == 1)
                {
                    this.GetComponent<Renderer>().material = Resources.Load<Material>("numbers/Materials/1");
                }
                else if (number == 2)
                {
                    this.GetComponent<Renderer>().material = Resources.Load<Material>("numbers/Materials/2");
                }
                else if (number == 3)
                {
                    this.GetComponent<Renderer>().material = Resources.Load<Material>("numbers/Materials/3");
                }
                else if (number > 3)
                {
                    //this.GetComponent<Renderer>().material = Resources.Load<Material>("numbers/Materials/flag");
                }
            }
        }

    }

    public bool check()
    {

        /*

		if (!isMine) {
			if (!checkd) {
				Debug.Log("Getting Number... " + loc [0] + " " + loc [1] + " " + loc [2]);
				getNumber ();
			}
			if (number == 0){
				invisible = true;
				return false;
			}
		}

		*/
        return isMine;
    }
}
