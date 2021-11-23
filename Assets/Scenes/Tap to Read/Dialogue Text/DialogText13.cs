using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText13 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay13;
    public string[] sentences13;
    private int index13; 
    public float typingSpeed13;
   
    public GameObject continueButton13;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay13.text == sentences13[index13]){
           continueButton13.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences13[index13].ToCharArray()){
         textDisplay13.text += letter;
         yield return new WaitForSeconds(typingSpeed13);
      }
    }
    
    public void NextSentence()
    {
      continueButton13.SetActive(false);

      if(index13 < sentences13.Length - 1){
         index13++;
         textDisplay13.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
