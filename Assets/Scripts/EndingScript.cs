using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndingScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void mainmenudon()
    {
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }

}
