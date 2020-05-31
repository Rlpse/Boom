using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Bullet2")
        {
            Destroy(collision.gameObject);
            Debug.Log("Player2 point!");
        }
    }

}
