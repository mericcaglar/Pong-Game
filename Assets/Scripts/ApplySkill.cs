using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplySkill : MonoBehaviour
{

    private string getColor;
    public GameObject playerObj;
    public GameObject computerObj;
    

    void Update()
    {
        getColor = this.gameObject.GetComponent<SpriteRenderer>().color.ToString();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Çubukların boyunu değiştirir
            if (getColor == "RGBA(0.557, 0.267, 0.678, 1.000)")
            {
                playerObj.transform.localScale = new Vector3(0.42f,5f,1);
                StartCoroutine(resetWidth(playerObj));
                
            }
            //Topun boyunu değiştirir
            if (getColor == "RGBA(0.750, 0.220, 0.160, 1.000)")
            {
                this.gameObject.transform.localScale = new Vector3(1f, 1f, 1);
                StartCoroutine(resetWidth(this.gameObject));
                
            }
        }
        if (collision.gameObject.CompareTag("Computer"))
        {
            //Çubukların boyunu değiştirir
            if (getColor == "RGBA(0.557, 0.267, 0.678, 1.000)")
            {
                computerObj.transform.localScale = new Vector3(0.42f,5f,1);
                StartCoroutine(resetWidth(computerObj));
            }
            //Topun boyunu değiştirir
            if (getColor == "RGBA(0.750, 0.220, 0.160, 1.000)")
            {
                this.gameObject.transform.localScale = new Vector3(1f,1f,1);
                StartCoroutine(resetWidth(this.gameObject));
                
            }
        }
    }

    IEnumerator resetWidth(GameObject gameObject )
    {
        yield return new WaitForSeconds(4);
        if (gameObject != this.gameObject)
        {
            gameObject.transform.localScale = new Vector3(0.42f,3f,1); 
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(0.5f,0.5f,1);
        }
    }
}
