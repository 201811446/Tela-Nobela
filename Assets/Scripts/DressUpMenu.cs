using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DressUpMenu : MonoBehaviour
{
    public void Maria()
    {
        SceneManager.LoadScene("DressUp");
    }
    public void Catalina()
    {
        SceneManager.LoadScene("DressUp");
    }
    public void Star()
    {
        SceneManager.LoadScene("DressUp");
    }
    public void Gear()
    {
        SceneManager.LoadScene("Option");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}