﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player2Collision : MonoBehaviour {
    private int shoot = -1;
    public Text boom;
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {

       
        if (collision.gameObject.tag == "Bullet")
        {
            shoot++;
            Destroy(collision.gameObject);
            boom.text = "Red = " + shoot.ToString(); 
            
        }

        if (shoot >= 15)
        {
            boom.text = "Red is WINNER! Please restart to continue.";
        }


    }
}
