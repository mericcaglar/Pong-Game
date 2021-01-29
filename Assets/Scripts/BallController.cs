using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
    [SerializeField]private float speed;

    private Vector2 direction;

    private Rigidbody2D rb;

    private Vector2 screenBounds;

    public GameObject ball;

   
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized;
        screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
       
        ball = GameObject.Find("Ball");
        }

    private void Update()
    {
        if (ball.transform.position.x >= 10f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }

        if (ball.transform.position.x <= -10f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = direction * speed;
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            direction.x = -direction.x;
           
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction.y = -direction.y;
        }
    }
}
