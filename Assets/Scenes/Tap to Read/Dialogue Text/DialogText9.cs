using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText9 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay9;
    public string[] sentences9;
    private int index9; 
    public float typingSpeed9;
   
    public GameObject continueButton9;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay9.text == sentences9[index9]){
           continueButton9.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences9[index9].ToCharArray()){
         textDisplay9.text += letter;
         yield return new WaitForSeconds(typingSpeed9);
      }
    }
    
    public void NextSentence()
    {
      continueButton9.SetActive(false);

      if(index9 < sentences9.Length - 1){
         index9++;
         textDisplay9.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
