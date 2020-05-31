using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2Movement : MonoBehaviour {
    public float speed = 5f;

    public Rigidbody2D rb;
    
    Vector2 movement; 
	// Use this for initialization
	void Update () {
         movement.x = Input.GetAxisRaw("Horizontal");
         movement.y = Input.GetAxisRaw("Vertical2");
	}
	
	// Update is called once per frame
	void FixedUpdate() {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
	}
}
