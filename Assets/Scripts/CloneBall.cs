using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CloneBall : MonoBehaviour
{
    private Vector2 screenBounds;
    private Vector2 direction;
    private Rigidbody2D rb;
    public float speed = 10;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(Random.Range(0,2),Random.Range(1,2));
        screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    void Update()
    {
        
        if (this.transform.position.x >= screenBounds.x)
        {
            Destroy(this.gameObject);
        }

        if (this.transform.position.x <= screenBounds.x * -1)
        {
         
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction.y = -direction.y;
        }
        
    }
}
