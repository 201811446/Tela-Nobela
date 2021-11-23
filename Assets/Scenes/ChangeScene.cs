using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
    
    public void Change_Scene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
