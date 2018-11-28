using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvadersMovement : MonoBehaviour {

    float time;
    public float moveInterval = 5;
    Vector3 dir;
    public float speed = 10;

    // Use this for initialization
    void Start () {
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time % moveInterval * 2 < moveInterval) dir = new Vector3(-1, 1, 0);
        else dir = new Vector3(0, -1, 0);
        transform.position = transform.position + dir * Time.deltaTime * speed;
    }
}
