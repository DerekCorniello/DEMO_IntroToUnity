﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreenSwitch : MonoBehaviour
{
    public void gotoGame()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void quit()
    {
        Application.Quit();
    }
}
