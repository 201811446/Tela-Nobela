using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText17 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay17;
    public string[] sentences17;
    private int index17; 
    public float typingSpeed17;
   
    public GameObject continueButton17;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay17.text == sentences17[index17]){
           continueButton17.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences17[index17].ToCharArray()){
         textDisplay17.text += letter;
         yield return new WaitForSeconds(typingSpeed17);
      }
    }
    
    public void NextSentence()
    {
      continueButton17.SetActive(false);

      if(index17 < sentences17.Length - 1){
         index17++;
         textDisplay17.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
