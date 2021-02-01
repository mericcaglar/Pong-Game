using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
    [SerializeField]private float speed = 7;

    private Vector2 direction;

    private Rigidbody2D rb;

    private Vector2 screenBounds;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized;
        screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }
    
    void FixedUpdate()
    {
        rb.velocity = direction * speed;
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Computer") )
        {
            direction.x = -direction.x;
            if (this.gameObject.GetComponent<SpriteRenderer>().color.ToString() != "RGBA(0.278, 0.278, 0.278, 1.000)")
            {
                this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.278f, 0.278f, 0.278f, 1);
                
            }
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction.y = -direction.y;
        }
    }
}
