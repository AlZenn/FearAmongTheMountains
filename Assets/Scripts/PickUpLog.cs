using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PickUpLog : MonoBehaviour
{
    public GameObject inttext, key, logYazi1, logYazi2, logYazi3, logYazi4, key2, key3, key4, duvar, startEnemy;
    public AudioSource pickupsound;
    public bool interactable;
    public int logSayac = 0;

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
                //pickupsound.Play();
                

                logSayac++;

                if (logSayac == 1)
                {
                    logYazisi1();
                    startEnemy.SetActive(false);
                    key.SetActive(false);
                    key2.SetActive(true);
                }
                if (logSayac == 2)
                {
                    logYazisi2();
                    key2.SetActive(false);
                    key3.SetActive(true);
                }
                if (logSayac == 3)
                {
                    logYazisi3();
                    key3.SetActive(false);
                    key4.SetActive(true);
                }
                if (logSayac == 4)
                {
                    key4.SetActive(false);
                    logYazisi4();
                    duvar.SetActive(false);
                }


            }
        }

        
    }
    void logYazisi1()
    {
        logYazi1.SetActive(true);
        StopCoroutine("disableText");
        StartCoroutine("disableText");
    }
    void logYazisi2()
    {
        logYazi2.SetActive(true);
        StopCoroutine("disableText");
        StartCoroutine("disableText");
    }
    void logYazisi3()
    {
        logYazi3.SetActive(true);
        StopCoroutine("disableTex1");
        StartCoroutine("disableText");
    }
    void logYazisi4()
    {
        logYazi4.SetActive(true);
        StopCoroutine("disableText");
        StartCoroutine("disableText");
    }
    IEnumerator disableText()
    {
        yield return new WaitForSeconds(2.0f);
        logYazi1.SetActive(false);
        logYazi2.SetActive(false);
        logYazi3.SetActive(false);
        logYazi4.SetActive(false);
    }



}
