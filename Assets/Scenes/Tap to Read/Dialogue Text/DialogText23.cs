using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText23 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay23;
    public string[] sentences23;
    private int index23; 
    public float typingSpeed23;
   
    public GameObject continueButton23;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay23.text == sentences23[index23]){
           continueButton23.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences23[index23].ToCharArray()){
         textDisplay23.text += letter;
         yield return new WaitForSeconds(typingSpeed23);
      }
    }
    
    public void NextSentence()
    {
      continueButton23.SetActive(false);

      if(index23 < sentences23.Length - 1){
         index23++;
         textDisplay23.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
