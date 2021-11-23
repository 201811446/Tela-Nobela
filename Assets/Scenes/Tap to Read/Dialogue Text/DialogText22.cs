using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText22 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay22;
    public string[] sentences22;
    private int index22; 
    public float typingSpeed22;
   
    public GameObject continueButton22;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay22.text == sentences22[index22]){
           continueButton22.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences22[index22].ToCharArray()){
         textDisplay22.text += letter;
         yield return new WaitForSeconds(typingSpeed22);
      }
    }
    
    public void NextSentence()
    {
      continueButton22.SetActive(false);

      if(index22 < sentences22.Length - 1){
         index22++;
         textDisplay22.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
