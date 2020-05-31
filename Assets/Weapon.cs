using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int x;
    private int x1;
    private int shootCounter = 0;

    // Use this for initialization
    void Start () {
        x1= x * 2;
        x = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("f"))
        {
            Shoot();
            shootCounter++;
            print("Shoot counter = " + shootCounter.ToString());
        }

        if (Input.GetButton("Fire1"))
        {
            print(x * x1);
        }


    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


}
