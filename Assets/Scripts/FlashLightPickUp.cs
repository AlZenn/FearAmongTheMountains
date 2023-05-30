using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightPickUp : MonoBehaviour
{
    public GameObject inttext, flashlightTable , flashlightHand;
    public AudioSource pickup;
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
                pickup.Play();
                flashlightHand.SetActive(true);
                flashlightTable.SetActive(false);

            }
        }
    }
}
