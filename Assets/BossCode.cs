using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossCode : MonoBehaviour
{
    public int health = 20;
    public Slider healthbar;
    public GameObject boss;
    public GameObject stage;
    public Transform point;
    // Use this for initialization
    void Start()
    {
        healthbar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = health;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            health--;
        }

        if (health == 10)
        {
            Destroy(healthbar);
           
        }

        if (health == 10) 
        {
            
        }

        if (health == 0)
        {
            Destroy(boss);
        }
    }
}