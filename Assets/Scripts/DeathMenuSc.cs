using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenuSc : MonoBehaviour
{
    public string startMenu;
    public void retry()
    {
        SceneManager.LoadScene(startMenu);
    }

    public void quitgame()
    {
        Application.Quit();
    }
}
