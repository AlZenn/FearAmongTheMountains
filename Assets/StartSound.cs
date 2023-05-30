using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSound : MonoBehaviour
{
    public AudioSource ses;
    public GameObject sesobjesi;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ses.Play();
            Destroy(sesobjesi);
        }
    }
}
