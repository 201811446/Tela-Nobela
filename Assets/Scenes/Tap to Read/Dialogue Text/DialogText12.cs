using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText112 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay12;
    public string[] sentences12;
    private int index12; 
    public float typingSpeed12;
   
    public GameObject continueButton12;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay12.text == sentences12[index12]){
           continueButton12.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences12[index12].ToCharArray()){
         textDisplay12.text += letter;
         yield return new WaitForSeconds(typingSpeed12);
      }
    }
    
    public void NextSentence()
    {
      continueButton12.SetActive(false);

      if(index12 < sentences12.Length - 1){
         index12++;
         textDisplay12.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
