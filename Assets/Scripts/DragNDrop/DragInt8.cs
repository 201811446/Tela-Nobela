using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragInt8 : MonoBehaviour
{

    private Vector3 screenPoint7;
    private Vector3 startPosition7;
    public GameObject dropPlace_GO7;
    public GameObject dropPlace_TO7;

    private Vector3 dropPlacePosition7;
    private Vector3 startUp7;
    public CoinCounter coinz;
    public int l;

    public int i;

    public Timer tick;

    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePosition7 = dropPlace_GO7.GetComponent<Transform>().position;
        startUp7 = dropPlace_TO7.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePosition7;
            i += 1;
            l += 1;
        }
        else if (i == 2)
        {
            l -= 1;
            this.gameObject.transform.position = startUp7;
            i -= 1;
        }
        if (l == 3)
        {
            l += 10;
            coinz.coins += 1;
            if (coinz.coins == 3)
            {
                tick.currentTime = tick.startMinutes * 60;
                SceneManager.LoadScene("WIN");
            }
        }
    }

    void OnMouseDown()
    {
        startPosition7 = this.gameObject.transform.position;
        screenPoint7 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint7.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        this.transform.position = curPosition;
    }

    /*void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.name == "bottom1slot")
        {
            isCorrectPlace = true;
        }
    }*/

}
