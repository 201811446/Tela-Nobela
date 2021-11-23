using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText2 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay2;
    public string[] sentences2;
    private int index2; 
    public float typingSpeed2;
   
    public GameObject continueButton2;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay2.text == sentences2[index2]){
           continueButton2.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences2[index2].ToCharArray()){
         textDisplay2.text += letter;
         yield return new WaitForSeconds(typingSpeed2);
      }
    }
    
    public void NextSentence()
    {
      continueButton2.SetActive(false);

      if(index2 < sentences2.Length - 1){
         index2++;
         textDisplay2.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
