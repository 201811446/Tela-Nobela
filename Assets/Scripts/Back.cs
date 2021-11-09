using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void BackMaria()
    {
        SceneManager.LoadScene("StoryMenu-Maria");
    }
    public void BackCatalina()
    {
        SceneManager.LoadScene("StoryMenu-Catalina");
    }
    public void BackStar()
    {
        SceneManager.LoadScene("StoryMenu-Star");
    }
    public void BackDressUp()
    {
        SceneManager.LoadScene("DressUpMenu");
    }
    public void BackMiniGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
