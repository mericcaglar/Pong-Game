using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountScore : MonoBehaviour
{
    public Text CompScoreBoard;
    public Text PlayerScoreBoard;
    public GameObject ball;
    
    private int PlayerScore = 0;
    private int ComputerScore = 0;
    
    private Vector2 screenBounds;
    
    void Start()
    {
        screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }
    
    void Update()
    {
        if (ball.transform.position.x >= screenBounds.x)
        {
            PlayerScore++;
            ball.transform.position = new Vector3(0f, 0f, 0f);
        }

        if (ball.transform.position.x <= screenBounds.x * -1)
        {
            ComputerScore++;
            ball.transform.position = new Vector3(0f, 0f, 0f);
        }

        CompScoreBoard.text = ComputerScore.ToString(); 
        PlayerScoreBoard.text = PlayerScore.ToString();
    }
}
