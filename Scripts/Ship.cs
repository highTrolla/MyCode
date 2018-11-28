using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    public float strength = 20f;
    public Transform Bullet;
    public float HP = 3;
    public float combo;
    public float score;

    // Use this for initialization
    void Start()
    {
        combo = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

        movement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            fire();

        }

    }

    void movement()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * strength * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * strength * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * strength * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * strength * Time.deltaTime);
        }
    }
    void fire()
    {
        Instantiate(Bullet, transform.position, transform.rotation);
        print("sah dood");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            DeathEvent();
        }

    }

    void DeathEvent()
    {
        print("Player Oof");
        HP -= 1;
        combo = 0;
        if (HP <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public int currentScore;

    public void AddPoint(int amountToAdd)
    {
        currentScore += amountToAdd;
    }

}

