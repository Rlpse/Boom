using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bull;
  
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("k"))
        {
            Shoot1();
        }

       
        
    }

    void Shoot1()
    {
        Instantiate(bull, firepoint.position, firepoint.rotation);
    }
}