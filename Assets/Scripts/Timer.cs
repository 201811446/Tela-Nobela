using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
     public bool timerActive = false;
     public float currentTime;
     public int startMinutes;
     public Text currentTimeText;

     // Start is called before the first frame update
     void Start()
     {
         currentTime = startMinutes * 60;
     }

     // Update is called once per frame
     void Update()
     {
         if (timerActive == true)
         {
             currentTime = currentTime - Time.deltaTime;
            if (currentTime <= 0)
            {
                timerActive = false;
                SceneManager.LoadScene("LOSE");
            }
         }
         TimeSpan time = TimeSpan.FromSeconds(currentTime);
         currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
     }

     public void StartTime()
     {
         timerActive = true;
     }

     public void StopTime()
     {
         timerActive = false;
     }
}
