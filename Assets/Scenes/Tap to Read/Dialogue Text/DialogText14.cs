using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText14 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay14;
    public string[] sentences14;
    private int index14; 
    public float typingSpeed14;
   
    public GameObject continueButton14;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay14.text == sentences14[index14]){
           continueButton14.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences14[index14].ToCharArray()){
         textDisplay14.text += letter;
         yield return new WaitForSeconds(typingSpeed14);
      }
    }
    
    public void NextSentence()
    {
      continueButton14.SetActive(false);

      if(index14 < sentences14.Length - 1){
         index14++;
         textDisplay14.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
