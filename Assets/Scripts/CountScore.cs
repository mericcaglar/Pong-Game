using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountScore : MonoBehaviour
{
    public Text ScoreBoard;
    public GameObject ball;
    
    private int PlayerScore = 0;
    private int ComputerScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        /* TOPUN EKRANDAN ÇIKTIĞINDA BAŞLANGICA GERİ DÖNMESİNİ KONTROL EDEN 
        KOD SATIRI BURAYA DA YAZILACAK */
        if (ball.transform.position.x >= 10f)
        {
            PlayerScore++;
        }

        if (ball.transform.position.x <= -10f)
        {
            ComputerScore++;
        }

        ScoreBoard.text = PlayerScore.ToString() + " - " + ComputerScore.ToString(); 
        print("Skor: " + PlayerScore + " , " + ComputerScore);
    }
}
