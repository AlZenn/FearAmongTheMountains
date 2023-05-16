using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YaziClose : MonoBehaviour
{
    public GameObject Yazi;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Yazi.SetActive(false);
        }
    }
}
