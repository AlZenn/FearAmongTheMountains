using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectLadder : MonoBehaviour
{
    public GameObject inttext, collect_text, ending_text;
    public GameObject lad1, lad2, lad3, lad4;
    public AudioSource pickup;
    public bool interactable;
    public int merdiven = 0;

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
                // pickup.Play();
                if (merdiven == 0)
                {
                    lad1.SetActive(false);
                    lad2.SetActive(true);
                    merdiven++;
                }
                if (merdiven == 1)
                {
                    lad2.SetActive(false);
                    lad3.SetActive(true);
                    merdiven++;
                }
                if (merdiven == 2)
                {
                    lad3.SetActive(false);
                    lad4.SetActive(true);
                    merdiven++;
                }
                if (merdiven == 3)
                {
                    lad4.SetActive(false);
                    merdiven++;
                    ending_text.SetActive(true);
                    Invoke("SetFalse", 5.0f);

                }

                void SetFalse()
                {

                    ending_text.SetActive(false);
                }


            }
        }
    }
}
