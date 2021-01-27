using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Oyuncunun hızı 
    [SerializeField] private float speed = 1;
    
    //Mouse poziyonunu tutmak için Vector2 değişkeni tanımlandı
    private Vector2 mousePos;
    
    //Karakterin pozisyonunu tutmak için Vector2 değişkeni tanımlandı
    private Vector2 playerPosition;
    
    void Update()
    {
        //Mouse kordinatlarını mousePos değişkenine atadık
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        
        //Mouse pozisyonunu player değişkenine atadık
        playerPosition = new Vector2(transform.position.x,mousePos.y*speed);
        
        //playerPosition değişkeninde tuttuğumuz değerleri objenin pozisyon değerlerine atadık
        gameObject.transform.position = playerPosition;
    }
}
