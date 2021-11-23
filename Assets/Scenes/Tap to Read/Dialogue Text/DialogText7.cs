using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText7 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay7;
    public string[] sentences7;
    private int index7; 
    public float typingSpeed7;
   
    public GameObject continueButton7;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay7.text == sentences7[index7]){
           continueButton7.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences7[index7].ToCharArray()){
         textDisplay7.text += letter;
         yield return new WaitForSeconds(typingSpeed7);
      }
    }
    
    public void NextSentence()
    {
      continueButton7.SetActive(false);

      if(index7 < sentences7.Length - 1){
         index7++;
         textDisplay7.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
