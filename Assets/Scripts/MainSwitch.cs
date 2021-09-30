using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSwitch : MonoBehaviour
{
    public void Story()
    {
        SceneManager.LoadScene("Story");
    }
    public void DressUp()
    {
        SceneManager.LoadScene("DressUp");
    }
    public void Terno()
    {
        SceneManager.LoadScene("Terno");
    }
}
