using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText11 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay11;
    public string[] sentences11;
    private int index11; 
    public float typingSpeed11;
   
    public GameObject continueButton11;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay11.text == sentences11[index11]){
           continueButton11.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences11[index11].ToCharArray()){
         textDisplay11.text += letter;
         yield return new WaitForSeconds(typingSpeed11);
      }
    }
    
    public void NextSentence()
    {
      continueButton11.SetActive(false);

      if(index11 < sentences11.Length - 1){
         index11++;
         textDisplay11.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
