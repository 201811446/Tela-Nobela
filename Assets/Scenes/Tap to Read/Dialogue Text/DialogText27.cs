using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogText27 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay27;
    public string[] sentences27;
    private int index27; 
    public float typingSpeed27;
   
    public GameObject continueButton27;    

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Type()); 
    }

    // Update is called once per frame
    void Update()
    {
        if(textDisplay27.text == sentences27[index27]){
           continueButton27.SetActive(true);
        }
    }

    IEnumerator Type(){
      foreach(char letter in sentences27[index27].ToCharArray()){
         textDisplay27.text += letter;
         yield return new WaitForSeconds(typingSpeed27);
      }
    }
    
    public void NextSentence()
    {
      continueButton27.SetActive(false);

      if(index27 < sentences27.Length - 1){
         index27++;
         textDisplay27.text = "";
         StartCoroutine(Type());
      } else {
            SceneManager.LoadScene("MainMenu");
      }
    }
}
