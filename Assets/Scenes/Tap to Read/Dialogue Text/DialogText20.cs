using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText20 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay20;
    public string[] sentences20;
    private int index20; 
    public float typingSpeed20;
   
    public GameObject continueButton20;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay20.text == sentences20[index20]){
           continueButton20.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences20[index20].ToCharArray()){
         textDisplay20.text += letter;
         yield return new WaitForSeconds(typingSpeed20);
      }
    }
    
    public void NextSentence()
    {
      continueButton20.SetActive(false);

      if(index20 < sentences20.Length - 1){
         index20++;
         textDisplay20.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
