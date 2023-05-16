using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandaj : MonoBehaviour
{
    public GameObject inttext, bandaj, kan;
    public AudioSource kagitSesi1;
    public bool interactable;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                inttext.SetActive(false);
                interactable = false;
                kagitSesi1.Play();
                bandaj.SetActive(false);
                kan.SetActive(false);

            }
        }
    }
}
