using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 5f;
    public Camera cam;
    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePos;
    // Update is called once per frame
	void Update ()
    {   //
        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    public static Vector2 Rotate(Vector2 v, float degrees)
    {
        float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);

        float tx = v.x;
        float ty = v.y;
        v.x = (cos * tx) - (sin * ty);
        v.y = (sin * tx) + (cos * ty);
        return v;
    }

    void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        if (Input.GetKey("w"))
        {
            rb.MovePosition(rb.position + lookDir * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.MovePosition(rb.position + -lookDir * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.MovePosition(rb.position + Rotate(lookDir, 90.0f) * moveSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.MovePosition(rb.position + Rotate(lookDir, -90.0f) * moveSpeed * Time.fixedDeltaTime);
        }
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

}

