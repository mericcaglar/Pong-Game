using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerController : MonoBehaviour
{
    public GameObject ball;
    private Vector2 pos;
    
    void Update()
    {
        pos = new Vector2(transform.position.x,ball.transform.position.y);
        transform.position = pos;
    }
}
