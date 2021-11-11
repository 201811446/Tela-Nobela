using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Story()
    {
        SceneManager.LoadScene("StoryMenu-Star");
    }
    public void Dressup()
    {
        SceneManager.LoadScene("DressUpMenu");
    }
    public void MiniGame()
    {
        SceneManager.LoadScene("Minigame");
    }
    public void Back()
    {
        SceneManager.LoadScene("StartScreen");
    }
    public void Option()
    {
        SceneManager.LoadScene("Option");
    }
}

