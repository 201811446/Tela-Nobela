using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText18 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay18;
    public string[] sentences18;
    private int index18; 
    public float typingSpeed18;
   
    public GameObject continueButton18;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay18.text == sentences18[index18]){
           continueButton18.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences18[index18].ToCharArray()){
         textDisplay18.text += letter;
         yield return new WaitForSeconds(typingSpeed18);
      }
    }
    
    public void NextSentence()
    {
      continueButton18.SetActive(false);

      if(index18 < sentences18.Length - 1){
         index18++;
         textDisplay18.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
