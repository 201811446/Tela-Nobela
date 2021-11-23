using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText16 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay16;
    public string[] sentences16;
    private int index16; 
    public float typingSpeed16;
   
    public GameObject continueButton16;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay16.text == sentences16[index16]){
           continueButton16.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences16[index16].ToCharArray()){
         textDisplay16.text += letter;
         yield return new WaitForSeconds(typingSpeed16);
      }
    }
    
    public void NextSentence()
    {
      continueButton16.SetActive(false);

      if(index16 < sentences16.Length - 1){
         index16++;
         textDisplay16.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
