using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevMode : MonoBehaviour
{
    public GameObject enemy, text;
    public bool toggle;

    private void Start()
    {
        if (toggle == false)
        {
            if (toggle == false)
            {
                enemy.SetActive(false);
                text.SetActive(true);
            }
        }
        if (toggle == true)
        {
            enemy.SetActive(true);
            text.SetActive(false);
        }
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            toggle = !toggle;
            if (toggle == false)
            {
                enemy.SetActive(false);
                text.SetActive(true);
            }
            if (toggle == true)
            {
                enemy.SetActive(true);
                text.SetActive(false);
            }
        }
    }
}
