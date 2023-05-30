using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu;
    public string sceneName;
    public bool toggle;
    public PlayerController playerScript;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toggle = !toggle;
            if (toggle == false)
            {
                pausemenu.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            if (toggle == true)
            {
                pausemenu.SetActive(true);
                Time.timeScale = 0;
                playerScript.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    public void resumeGame()
    {
        toggle = false;
        pausemenu.SetActive(false);
        Time.timeScale = 1;
        playerScript.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }



}
