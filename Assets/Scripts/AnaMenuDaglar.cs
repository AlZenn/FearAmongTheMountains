using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnaMenuDaglar : MonoBehaviour
{

    public float speed = 0.1f;
    void Update()
    {
        transform.position -= new Vector3(speed, 0, 0);
    }
}
