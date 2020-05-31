using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour {
    public Transform Space;
    public Transform Placing;
    public Transform Where;
    public GameObject Wall;
    public GameObject Box;
    public GameObject SquarePrefab;
    public Object Sqyare; 
    // Use this for initialization
	void Start () {
		Sqyare = Instantiate(SquarePrefab, Space.position, Space.rotation);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire3"))
        {
            Place2();
            Object.Destroy(Sqyare);
        }
          
        if (Input.GetButton("Fire2"))
        {
            Place();
        }
	}

    void Place()
    {
        Instantiate(SquarePrefab, Space.position, Space.rotation);
    } 

    void Place2()
    {
        Instantiate(Box, Placing.position, Placing.rotation);
        Instantiate(Box, Where.position, Where.rotation);
    }
}
