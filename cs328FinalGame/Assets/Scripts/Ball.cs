﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    float sx;
    float sz;
    float maxAccel = 5.0f;
    float acceleration = 0.05f;

    public Vector3 initialImpulse;
    public GameObject ball;
	// Use this for initialization
	void Start () {
        sx = Random.Range(0, 2) == 0 ? -1 : 1;
        sz = Random.Range(0, 2) == 0 ? -1 : 1;

        ball.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(5, 10) * sx, 0, Random.Range(5, 10) * sz);

        //ball.GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {


	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            Debug.Log("Hit the Barrier");
        }
        
        if(collision.gameObject.tag == "Paddle")
        {
            Debug.Log("Hit a Paddle");
            MainDriver.CurrentScore += 5;
        }


    }


}