using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Falling : MonoBehaviour
{
    public double value;
    public int Speed;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        movement.y = -1600;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().MovePosition(transform.position + movement * Speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            GameObject.Find("Score").GetComponent<Text>().text = Convert.ToString(Convert.ToDouble(GameObject.Find("Score").GetComponent<Text>().text) + value);
        }
        //GameObject.Find("Score").GetComponent<FallingManager>().OnScreen += -value;
        Destroy(gameObject);
    }
}
