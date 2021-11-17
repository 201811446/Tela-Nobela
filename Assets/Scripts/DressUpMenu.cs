using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DressUpMenu : MonoBehaviour
{
    public void Maria()
    {
        SceneManager.LoadScene("DSEL1");
    }
    public void Catalina()
    {
        SceneManager.LoadScene("DSEL2");
    }
    public void Star()
    {
        SceneManager.LoadScene("DSEL3");
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