using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossCode : MonoBehaviour
{
    public GameObject fence;
    private int gateway = 4;
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
        if(gateway == 0)
        {
            Destroy(fence);
        }

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
            gateway--;
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(boss);
        }

       

    }
}