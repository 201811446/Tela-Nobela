using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Catalina : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("StoryMenu-Star");
    }
    public void Previous()
    {
        SceneManager.LoadScene("StoryMenu-Maria");
    }
    public void Gear()
    {
        SceneManager.LoadScene("Option");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void StoryCatalina()
    {
        SceneManager.LoadScene("Catalina-Story");
    }
}
