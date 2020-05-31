using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bull;
    public GameObject superbullet;
    public GameObject Boom;
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

        if (Input.GetKeyUp("l"))
        {
            Super();
        }

        if (Input.GetKeyUp("o"))
        {
            Boomam();
        }
    }

    void Shoot1()
    {
        Instantiate(bull, firepoint.position, firepoint.rotation);
    }

    void Super()
    {
        Instantiate(superbullet, firepoint.position, firepoint.rotation);


    }

    void Boomam()
    {
        Destroy(superbullet);
        Instantiate(superbullet, firepoint.position, firepoint.rotation);
        Instantiate(Boom, firepoint.position, firepoint.rotation);
    }
}