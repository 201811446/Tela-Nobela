using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText6 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay6;
    public string[] sentences6;
    private int index6; 
    public float typingSpeed6;
   
    public GameObject continueButton6;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay6.text == sentences6[index6]){
           continueButton6.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences6[index6].ToCharArray()){
         textDisplay6.text += letter;
         yield return new WaitForSeconds(typingSpeed6);
      }
    }
    
    public void NextSentence()
    {
      continueButton6.SetActive(false);

      if(index6 < sentences6.Length - 1){
         index6++;
         textDisplay6.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
