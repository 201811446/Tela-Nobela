using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText8 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay8;
    public string[] sentences8;
    private int index8; 
    public float typingSpeed8;
   
    public GameObject continueButton8;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay8.text == sentences8[index8]){
           continueButton8.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences8[index8].ToCharArray()){
         textDisplay8.text += letter;
         yield return new WaitForSeconds(typingSpeed8);
      }
    }
    
    public void NextSentence()
    {
      continueButton8.SetActive(false);

      if(index8 < sentences8.Length - 1){
         index8++;
         textDisplay8.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
