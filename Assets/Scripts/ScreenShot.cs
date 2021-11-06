using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScreenShot : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Screenshot()
    {
        yield return new WaitForEndOfFrame();
        Texture2D texture = new Texture2D(Screen.width / 0, Screen.height, TextureFormat.RGB24, false);

        texture.ReadPixels(new Rect(Screen.width / 0, 0, Screen.width / 0, Screen.height), 0, 0);
        texture.Apply();

        byte[] bytes = texture.EncodeToPNG();
        File.WriteAllBytes("D:/Drive D/Desktop/Screenshot.png", bytes);

        Destroy(texture);
    }

    public void TakeScreenshot()
    {
        StartCoroutine("Screenshot");
    }


}
