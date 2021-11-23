using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText10 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay10;
    public string[] sentences10;
    private int index10; 
    public float typingSpeed10;
   
    public GameObject continueButton10;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay10.text == sentences10[index10]){
           continueButton10.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences10[index10].ToCharArray()){
         textDisplay10.text += letter;
         yield return new WaitForSeconds(typingSpeed10);
      }
    }
    
    public void NextSentence()
    {
      continueButton10.SetActive(false);

      if(index10 < sentences10.Length - 1){
         index10++;
         textDisplay10.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
