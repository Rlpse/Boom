using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroywall : MonoBehaviour {
    private bool walldisable = false;
    public GameObject wall;
    public Transform point;
    private bool walldisable2 = false;
    public GameObject wall2;
    private int counter = 3;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (walldisable == true)
        {
           
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            counter--;
            if (counter == 2)
            {

            }

            if (counter == 0)
            {
                Destroy(wall);
            }


        }

      

    }


}
