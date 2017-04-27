using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDriver : MonoBehaviour {

    public GameObject[] Paddle;

	// Use this for initialization
	void Start () {

        //Paddles are set to false to make them invisible
        for(int i = 0; i<24; i++)
        {
            Paddle[i].SetActive(false);
        }

	}
	
	// Update is called once per frame
	void Update () {

        // Test Code to turn on and off the first paddle with the a key
        if (Input.GetKeyDown(KeyCode.A))
        {
            Paddle[0].SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Paddle[0].SetActive(false);
        }

	}
}
