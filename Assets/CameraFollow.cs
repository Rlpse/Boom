using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    private Transform playerfollow;
    public float offset;
    // Use this for initialization
	void Start () {
        playerfollow = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 temp = transform.position;

        temp.x = playerfollow.position.x;
        temp.y = playerfollow.position.y;
        temp.x += offset;
        temp.y += offset;
        transform.position = temp; 
    }
}
