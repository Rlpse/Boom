using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMechanic : MonoBehaviour {
   
    private bool wallallow = false;
    public GameObject wall;
    public Transform position;
    private int count = 3;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 
        if (count == 3)
        {
            if (Input.GetKeyUp("p"))
            {
                place();
                count--;
            }
        }

        if (count == 2)
            if (Input.GetKeyUp("p"))
            {
                place();
                count--;
            }

    }

    void place()
    {
        Instantiate(wall, position.position, position.rotation);
    }

   

}
