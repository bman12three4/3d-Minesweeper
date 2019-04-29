using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineController : MonoBehaviour
{

    public bool isMine = false;
    public int number = 0;

    public bool invisible = false;

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
            this.GetComponent<Renderer>().enabled = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {

        getNumber();

        UnityEngine.Debug.Log(number);


        if (isMine)
        {
            this.GetComponent<Renderer>().material = Resources.Load<Material>("numbers/Materials/mine");
        }
        else
        {
            if (number == 0)
            {
                //Destroy (this.gameObject);	
                GetComponent<Renderer>().enabled = false;
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
                this.GetComponent<Renderer>().material = Resources.Load<Material>("numbers/Materials/flag");
            }
        }

    }

    public void getNumber()
    {

		Debug.Log(loc[0] + " " + loc[1] + " " + loc[2]);

        try
        {
            if (transform.parent.GetComponent<CreateMines>().mines[loc[0] + 1, loc[1], loc[2]].GetComponent<MineController>().check())
                number++;
        }
        catch (Exception e)
        {
            Debug.Log("error");
        }

        /* if (!invisible){
            for (int z = -1; z != 1; z++){
                for (int x = -1; x != 1; z++){
                    for (int y = -1; y != 1; y++){
                        try {
                            if (transform.parent.GetComponent<CreateMines> ().mines [loc[0]+x, loc[1]+y, loc[2]+z].GetComponent<MineController> ().isMine)
                                number++;
                            }
                            catch (Exception e) {
                                Debug.Log("error");
                            }  

                        }
                    }
                }
            }
        }*/

    }

    public bool check()
    {
        if (!isMine)
        {
            getNumber();

            if (number == 0)
            {
                invisible = true;
            }
        }

        Debug.Log("Checking...");

        return isMine;
    }
}
