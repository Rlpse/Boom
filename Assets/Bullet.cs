using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private int points = 0;
    public float speed = 30f;
    public Rigidbody2D rb;
    public GameObject player;
    // Use this for initialization
	void Start () {
        rb.velocity = transform.right * speed;
	}

    void Update()
    {
        
    }


    void OnTriggerEnter2D (Collider2D hitinfo)
    {
        Debug.Log(hitinfo.name);
        Destroy(gameObject);   
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bosses")
        {
            points++;
        }

        if (points == 12)
        {
            Debug.Log(points);
            Destroy(player);
        }

    }

    

}
