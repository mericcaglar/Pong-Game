using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScore : MonoBehaviour
{
    public Text CompScoreBoard;
    public Text PlayerScoreBoard;
    public GameObject ball;
    
    private int PlayerScore = 0;
    private int ComputerScore = 0;
    
    private Vector2 screenBounds;

    public static bool canAddScore = true;
    void Start()
    {
        screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }
    
    void Update()
    {
        if (ball.transform.position.x >= screenBounds.x && canAddScore)
        {
            canAddScore = false;
            PlayerScore++;
            ball.transform.position = new Vector3(0f, 0f, 0f);
        }

        if (ball.transform.position.x <= screenBounds.x * -1 && canAddScore)
        {
            canAddScore = false;
            ComputerScore++;
            ball.transform.position = new Vector3(0f, 0f, 0f);
        }

        if (PlayerScore >= 5) 
        {
            SceneManager.LoadScene (2);
        }

        if (ComputerScore >= 5)
        {
            SceneManager.LoadScene (3);
        }
        
        CompScoreBoard.text = ComputerScore.ToString(); 
        PlayerScoreBoard.text = PlayerScore.ToString();
    }

}
