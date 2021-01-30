using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DeploySkill : MonoBehaviour
{
    private GameObject gameManager;
    private SkillGenerator skillGenerator;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        skillGenerator = gameManager.GetComponent<SkillGenerator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            GameObject.FindGameObjectWithTag("Ball").GetComponent<SpriteRenderer>().color = this.GetComponent<SpriteRenderer>().color;
            Destroy(this.gameObject);
            skillGenerator.isSkillBallOnScreen = false;
        }
    }
}
