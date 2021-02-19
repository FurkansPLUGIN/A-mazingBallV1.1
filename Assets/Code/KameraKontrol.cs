using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public GameObject top;
    Vector3 araMesafe;
    void Start()
    {
        araMesafe = transform.position - top.transform.position;
    }

    
    void LateUpdate()
    {
        transform.position = top.transform.position + araMesafe;
    }
}
