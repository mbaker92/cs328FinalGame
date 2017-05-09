using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainDriver : MonoBehaviour {

    public Text Score;
    public static int CurrentScore;
    public GameObject[] Paddle;

    //Sound effect Variables
    public AudioClip keypressSound;
    private AudioSource source;

    // Use this for initialization
    void Start () {
        CurrentScore = 0;

        //Get sound file
        source = GetComponent<AudioSource>();

        //Paddles are set to false to make them invisible
        for (int i = 0; i<24; i++)
        {
        //    Paddle[i].SetActive(false);
        }

	}
	
	// Update is called once per frame
	void Update () {

        Score.text = "Score : " + CurrentScore.ToString();


        // Test Code to turn on and off the first paddle with the a key
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Play sound effect
            source.PlayOneShot(keypressSound, 1F);

            Paddle[0].SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Paddle[0].SetActive(false);
        }

	}
}
