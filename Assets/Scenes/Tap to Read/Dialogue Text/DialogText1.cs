using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText1 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay1;
    public string[] sentences1;
    private int index1; 
    public float typingSpeed1;
   
    public GameObject continueButton1;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay1.text == sentences1[index1]){
           continueButton1.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences1[index1].ToCharArray()){
         textDisplay1.text += letter;
         yield return new WaitForSeconds(typingSpeed1);
      }
    }
    
    public void NextSentence()
    {
      continueButton1.SetActive(false);

      if(index1 < sentences1.Length - 1){
         index1++;
         textDisplay1.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
