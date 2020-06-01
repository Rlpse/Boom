using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMaker : MonoBehaviour {
    private int count = 2;
    public GameObject wall;
    public Transform poi;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 2)
        {
            if (Input.GetKeyUp("t"))
            {
                build();
                count--;
            }
        }

        if (count == 1)
        {
            if (Input.GetKeyUp("t"))
            {
                count--;
                build();
                
            }
        }

    }

    void build()
    {
        Instantiate(wall, poi.position, poi.rotation);

    }

}
