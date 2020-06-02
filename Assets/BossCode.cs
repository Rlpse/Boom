using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossCode : MonoBehaviour
{
    public Transform point1;
    public GameObject explosion;
    private int health = 2;
    public Slider healthbar;
    public GameObject boss;
    public GameObject stage;
    public Transform point;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            
            Destroy(collision.gameObject);
            
            health--;
        }

        if (health == 0)
        {



            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(boss);
        }
    }
}