using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Button Play_Button;

    public Button Quit_Button;

    public void Play_Game()
    {
        SceneManager.LoadScene (0);
    }

    public void Quit_Game()
    {
        Application.Quit();
    }
}
