﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {
    public Button StartButton;

    public void ButtonClick()
    {
        SceneManager.LoadScene("Level1");
    }
}
