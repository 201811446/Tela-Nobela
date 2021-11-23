using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText3 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay3;
    public string[] sentences3;
    private int index3; 
    public float typingSpeed3;
   
    public GameObject continueButton3;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay3.text == sentences3[index3]){
           continueButton3.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences3[index3].ToCharArray()){
         textDisplay3.text += letter;
         yield return new WaitForSeconds(typingSpeed3);
      }
    }
    
    public void NextSentence()
    {
      continueButton3.SetActive(false);

      if(index3 < sentences3.Length - 1){
         index3++;
         textDisplay3.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
