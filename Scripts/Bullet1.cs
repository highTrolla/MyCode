using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour {

    public float speed = 600;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + Vector3.up * Time.deltaTime * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ship")
        {
            return;
        }
        Destroy(this.gameObject);
    }
}
