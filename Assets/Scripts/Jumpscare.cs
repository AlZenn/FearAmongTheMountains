using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumpscare : MonoBehaviour
{
    public Animator jumpscareAnim;
    public AudioSource jumpscareses;
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
            jumpscareses.Play();
        }
    }

    IEnumerator jumpscr()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
    }

}
