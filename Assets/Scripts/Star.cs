using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Star : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("StoryMenu-Maria");
    }
    public void Previous()
    {
        SceneManager.LoadScene("StoryMenu-Catalina");
    }
    public void Gear()
    {
        SceneManager.LoadScene("Option");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void StoryStar()
    {
        SceneManager.LoadScene("Tap to Read - How the Moon and Stars came to Be");
    }
}
