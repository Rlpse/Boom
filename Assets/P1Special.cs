﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Special : MonoBehaviour {
    public GameObject specialbullet;
    public Transform firepoint1;
    public Transform firepoint2;
    public Transform firepoint3;
    private int special = 3;
    bool CommandDisabler = false;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (special == 3 && special == 2 && special == 1)
        {
            if (Input.GetKey("g"))
            {
                skill();
               
                special--;
            }
        }
	}

    void skill()
    {
        Instantiate(specialbullet, firepoint1.position, firepoint1.rotation);
        Instantiate(specialbullet, firepoint2.position, firepoint2.rotation);
        Instantiate(specialbullet, firepoint3.position, firepoint3.rotation);
      

    }

    }
