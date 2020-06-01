using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walldestroy : MonoBehaviour {
    private int count = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (count == 3)
        {
            if (collision.gameObject.tag == "Bullet2")
            {
                count--;
                Destroy(collision.gameObject);
            }
        }


        if (collision.gameObject.tag == "Bullet2")
            {
                count--;
                Destroy(collision.gameObject);
            }
        
    }
}
