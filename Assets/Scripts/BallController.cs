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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(Random.Range(-1,1),Random.Range(-1,1));
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            direction.x = -direction.x;
        }
        
    }
}
