using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    bool timerActive = false;
    private float currentTime = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
    }

    // Update is called once per frame
    void Update()
    {
            Debug.Log(currentTime);
            if(currentTime > 0)
            currentTime -= Time.deltaTime * 2f;
            if (currentTime <= 0)
            {
                timerActive = false;
                Debug.Log("done");
                SceneManager.LoadScene("PURCHASECOM");
                
            }
    }

    public void StartTimer()
    {
        timerActive = true;
    }

    public void StopTimer()
    {
        timerActive = false;
    }
}
