using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText19 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay19;
    public string[] sentences19;
    private int index19; 
    public float typingSpeed19;
   
    public GameObject continueButton19;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay19.text == sentences19[index19]){
           continueButton19.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences19[index19].ToCharArray()){
         textDisplay19.text += letter;
         yield return new WaitForSeconds(typingSpeed19);
      }
    }
    
    public void NextSentence()
    {
      continueButton19.SetActive(false);

      if(index19 < sentences19.Length - 1){
         index19++;
         textDisplay19.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
