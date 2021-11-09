using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maria : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("StoryMenu-Catalina");
    }
    public void Previous()
    {
        SceneManager.LoadScene("StoryMenu-Star");
    }
    public void Gear()
    {
        SceneManager.LoadScene("Option");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void StoryMaria()
    {
        SceneManager.LoadScene("Maria-Story");
    }
}
