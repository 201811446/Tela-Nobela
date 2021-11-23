using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText24 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay24;
    public string[] sentences24;
    private int index24; 
    public float typingSpeed24;
   
    public GameObject continueButton24;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay24.text == sentences24[index24]){
           continueButton24.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences24[index24].ToCharArray()){
         textDisplay24.text += letter;
         yield return new WaitForSeconds(typingSpeed24);
      }
    }
    
    public void NextSentence()
    {
      continueButton24.SetActive(false);

      if(index24 < sentences24.Length - 1){
         index24++;
         textDisplay24.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
