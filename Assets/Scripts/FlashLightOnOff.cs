using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightOnOff : MonoBehaviour
{
    public GameObject light;
    public bool toggle;
    public AudioSource toggleSound;

    private void Start()
    {
        if (toggle == false)
        {
            if (toggle == false)
            {
                light.SetActive(false);
            }
        }
        if (toggle == true)
        {
            light.SetActive(true);
        }
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            toggle = !toggle;
            //toggleSound.Play();
            if (toggle == false)
            {
                light.SetActive(false);
            }
            if (toggle == true)
            {
                light.SetActive(true);
            }
        }
    }
}
