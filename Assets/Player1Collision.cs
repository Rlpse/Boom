using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player1Collision : MonoBehaviour {
    private int shoot = 0;
    public Text score;
  
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet2")
        {
            shoot++;
            Destroy(collision.gameObject);
            score.text = "Purple =" + shoot.ToString();
            
        }

        if (shoot >= 15)
        {
            score.text = "Purple is WINNER! Please restart to continue.";
            
        }

        



    }

}
