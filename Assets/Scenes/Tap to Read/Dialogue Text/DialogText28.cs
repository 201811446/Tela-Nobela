using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText28 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay28;
    public string[] sentences28;
    private int index28; 
    public float typingSpeed28;
   
    public GameObject continueButton28;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay28.text == sentences28[index28]){
           continueButton28.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences28[index28].ToCharArray()){
         textDisplay28.text += letter;
         yield return new WaitForSeconds(typingSpeed28);
      }
    }
    
    public void NextSentence()
    {
      continueButton28.SetActive(false);

      if(index28 < sentences28.Length - 1){
         index28++;
         textDisplay28.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
