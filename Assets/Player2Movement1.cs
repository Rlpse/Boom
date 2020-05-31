using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement1 : MonoBehaviour {
    public float speed = 5f;
    public Rigidbody2D rb;
    
    Vector2 movement; 
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        movement.y = Input.GetAxisRaw("Vertical2");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);    
    }

}
