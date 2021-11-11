using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DressUpMenu : MonoBehaviour
{
    public void Maria()
    {
        SceneManager.LoadScene("DressUp1");
    }
    public void Catalina()
    {
        SceneManager.LoadScene("DressUp2");
    }
    public void Star()
    {
        SceneManager.LoadScene("DressUp3");
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