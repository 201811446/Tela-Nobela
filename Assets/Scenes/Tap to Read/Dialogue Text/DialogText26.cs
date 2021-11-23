using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText26 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay26;
    public string[] sentences26;
    private int index26; 
    public float typingSpeed26;
   
    public GameObject continueButton26;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay26.text == sentences26[index26]){
           continueButton26.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences26[index26].ToCharArray()){
         textDisplay26.text += letter;
         yield return new WaitForSeconds(typingSpeed26);
      }
    }
    
    public void NextSentence()
    {
      continueButton26.SetActive(false);

      if(index26 < sentences26.Length - 1){
         index26++;
         textDisplay26.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
