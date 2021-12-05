using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CoinCounter : MonoBehaviour
{

    public int coins;
    public Text currentcoins;
    int coinceu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinceu = PlayerPrefs.GetInt("Score", coins);
        currentcoins.text = coinceu.ToString();
    }

    

}


  
