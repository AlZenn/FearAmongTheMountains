using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{

    public string SceneName;
    public float waitTime;

    void Start()
    {
        StartCoroutine("LoadToMenu");
        
    }

    IEnumerator LoadToMenu()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneName);
    }

}
