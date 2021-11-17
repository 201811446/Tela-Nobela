using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{

    public int i = 0;
    void Start()
    {
        i += 1;
    }

    public void change_scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
