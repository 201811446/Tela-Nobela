using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragInt3 : MonoBehaviour
{

    private Vector3 screenPoint2;
    private Vector3 startPosition2;
    public GameObject dropPlace_GO2;
    public GameObject dropPlace_TO2;

    private Vector3 dropPlacePosition2;
    private Vector3 startUp2;
    public CoinCounter coinz;
    public DragInt2 d2;

    public int i;

    public Timer tick;

    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePosition2 = dropPlace_GO2.GetComponent<Transform>().position;
        startUp2 = dropPlace_TO2.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePosition2;
            i += 1;
            d2.j += 1;
        }
        else if (i == 2)
        {
            d2.j -= 1;
            this.gameObject.transform.position = startUp2;
            i -= 1;
        }
        if (d2.j == 3)
        {
            d2.j += 10;
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
        startPosition2 = this.gameObject.transform.position;
        screenPoint2 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint2.z);
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
