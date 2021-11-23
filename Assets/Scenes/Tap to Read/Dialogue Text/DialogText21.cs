using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText21 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay21;
    public string[] sentences21;
    private int index21; 
    public float typingSpeed21;
   
    public GameObject continueButton21;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay21.text == sentences21[index21]){
           continueButton21.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences21[index21].ToCharArray()){
         textDisplay21.text += letter;
         yield return new WaitForSeconds(typingSpeed21);
      }
    }
    
    public void NextSentence()
    {
      continueButton21.SetActive(false);

      if(index21 < sentences21.Length - 1){
         index21++;
         textDisplay21.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
