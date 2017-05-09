using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainDriver : MonoBehaviour {

    public Text Score;
    public Text Lives;
    public static int CurrentScore;
    public static int lives = 5;
    public GameObject[] Paddle;
    KeyCode[] Keys = new KeyCode[24];


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
            Paddle[i].SetActive(false);        
        }
        setKeycodes();
	}
	
	// Update is called once per frame
	void Update () {

        if (lives <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        Score.text = "Score : " + CurrentScore.ToString();
        Lives.text = "Lives Left: " + lives.ToString();
        // 24 Paddles
        for (int i = 0; i < 24; i++)
        {
            // Array of keycodes used to compare which key is pressed
            if (Input.GetKeyDown(Keys[i]))
            {
                //Play sound effect
                source.PlayOneShot(keypressSound, 1F);
                Paddle[i].SetActive(true);
            }
            if (Input.GetKeyUp(Keys[i]))
            {
                Paddle[i].SetActive(false);
            }
        }
    }

    private void setKeycodes()
    {
        for (int i = 0; i < 24; i++)
        {
            Keys[i] = (KeyCode.A + i);
        }
    }

 }