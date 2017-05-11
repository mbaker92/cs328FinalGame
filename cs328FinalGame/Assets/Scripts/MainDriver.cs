using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainDriver : MonoBehaviour {

    public Text Score;
    public Text Lives;
    //public Text butt;
    public static int CurrentScore;
    public static int lives = 5;
    public Image[] LifeSprite = new Image[5];

    public GameObject[] Paddle;
    KeyCode[] Keys = new KeyCode[24];

    KeyCode change1 = KeyCode.Keypad5;
    KeyCode change2 = KeyCode.Keypad9;


    //public static int pressedKeys;




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

        //Level 0
        setKeycodes();
        for(int i=0; i<5; i++)
        {
            LifeSprite[i].enabled = true;
        }

	}
	
	// Update is called once per frame
	void Update () {

        checkLives();

        //Level 1
        if (Input.GetKeyDown(change1))
        {
            Debug.Log("Change Keys 1");

            setKeycodes1();
        }

        //Level 2
        if (Input.GetKeyDown(change2))
        {
            Debug.Log("Change Keys 2");

            setKeycodes2();
        }
        // pressedKeys = 0;

        if (lives <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        Score.text = "Score : " + CurrentScore.ToString();
        // butt.text = "Key Pressed: " + pressedKeys.ToString();

        // 24 Paddles
        for (int i = 0; i < 24; i++)
        {
            // Array of keycodes used to compare which key is pressed
            if (Input.GetKeyDown(Keys[i]))
            {
                //pressedKeys++;
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

    //Level 0
    private void setKeycodes()
    {
        for (int i = 0; i < 24; i++)
        {
            Keys[i] = (KeyCode.A + i);
        }
    }

    //Level 1
    private void setKeycodes1()
    {
        for (int i = 0; i < 24; i++)
        {
            Keys[i] = (KeyCode.B + i);
        }
    }

    //Level 2
    private void setKeycodes2()
    {
        for (int i = 0; i < 24; i++)
        {
            Keys[i] = (KeyCode.Z - i);
        }
    }

    private void checkLives()
    {
        switch (lives)
        {
            case 0: LifeSprite[4].enabled = false; break;
            case 1: LifeSprite[3].enabled = false; break;
            case 2: LifeSprite[2].enabled = false; break;
            case 3: LifeSprite[1].enabled = false; break;
            case 4: LifeSprite[0].enabled = false; break;
        }

    }

}