using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText5 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay5;
    public string[] sentences5;
    private int index5; 
    public float typingSpeed5;
   
    public GameObject continueButton5;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay5.text == sentences5[index5]){
           continueButton5.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences5[index5].ToCharArray()){
         textDisplay5.text += letter;
         yield return new WaitForSeconds(typingSpeed5);
      }
    }
    
    public void NextSentence()
    {
      continueButton5.SetActive(false);

      if(index5 < sentences5.Length - 1){
         index5++;
         textDisplay5.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
