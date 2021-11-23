using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText25 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay25;
    public string[] sentences25;
    private int index25; 
    public float typingSpeed25;
   
    public GameObject continueButton25;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay25.text == sentences25[index25]){
           continueButton25.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences25[index25].ToCharArray()){
         textDisplay25.text += letter;
         yield return new WaitForSeconds(typingSpeed25);
      }
    }
    
    public void NextSentence()
    {
      continueButton25.SetActive(false);

      if(index25 < sentences25.Length - 1){
         index25++;
         textDisplay25.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
