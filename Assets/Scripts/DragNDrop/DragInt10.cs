using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragInt10 : MonoBehaviour
{

    private Vector3 screenPoint9;
    private Vector3 startPosition9;
    public GameObject dropPlace_GO9;
    public GameObject dropPlace_TO9;

    private Vector3 dropPlacePosition9;
    private Vector3 startUp9;
    public CoinCounter coinz;
    public DragInt8 di4;

    public int i;

    public Timer tick;

    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePosition9 = dropPlace_GO9.GetComponent<Transform>().position;
        startUp9 = dropPlace_TO9.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePosition9;
            i += 1;
            di4.l += 1;
        }
        else if (i == 2)
        {
            di4.l -= 1;
            this.gameObject.transform.position = startUp9;
            i -= 1;
        }
        if (di4.l == 3)
        {
            di4.l += 10;
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
        startPosition9 = this.gameObject.transform.position;
        screenPoint9 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint9.z);
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
