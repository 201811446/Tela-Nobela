using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText15 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay15;
    public string[] sentences15;
    private int index15; 
    public float typingSpeed15;
   
    public GameObject continueButton15;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay15.text == sentences15[index15]){
           continueButton15.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences15[index15].ToCharArray()){
         textDisplay15.text += letter;
         yield return new WaitForSeconds(typingSpeed15);
      }
    }
    
    public void NextSentence()
    {
      continueButton15.SetActive(false);

      if(index15 < sentences15.Length - 1){
         index15++;
         textDisplay15.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
