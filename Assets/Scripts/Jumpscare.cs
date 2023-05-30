using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumpscare : MonoBehaviour
{
    public Animator jumpscareAnim;
    public GameObject player;
    public float jumpscareTime;
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            jumpscareAnim.SetTrigger("jumpscare");
            StartCoroutine(jumpscr());
        }
    }

    IEnumerator jumpscr()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
    }

}
