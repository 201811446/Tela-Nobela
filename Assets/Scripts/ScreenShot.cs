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
        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);

        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.Apply();

        string name = "TelaNobela_ScreenShot" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";

        //byte[] bytes = texture.EncodeToPNG();
        //File.WriteAllBytes(Application.dataPath + "/Screenshot.png", bytes);

        NativeGallery.SaveImageToGallery(texture, "Tela Nobela", name);

        Destroy(texture);
    }

    public void TakeScreenshot()
    {
        StartCoroutine("Screenshot");
    }


}
