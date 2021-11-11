using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScript : MonoBehaviour
{
    public static BgScript bgmusic;

    private void Awake()
    {
       if(bgmusic != null && bgmusic != this) 
	{
 	   Destroy(this.gameObject);
	   return;
	}
	
	bgmusic = this;
	DontDestroyOnLoad(this);
    }
}
