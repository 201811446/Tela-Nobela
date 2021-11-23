using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText4 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay4;
    public string[] sentences4;
    private int index4; 
    public float typingSpeed4;
   
    public GameObject continueButton4;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay4.text == sentences4[index4]){
           continueButton4.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences4[index4].ToCharArray()){
         textDisplay4.text += letter;
         yield return new WaitForSeconds(typingSpeed4);
      }
    }
    
    public void NextSentence()
    {
      continueButton4.SetActive(false);

      if(index4 < sentences4.Length - 1){
         index4++;
         textDisplay4.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
