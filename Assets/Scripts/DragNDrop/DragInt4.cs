using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragInt4 : MonoBehaviour
{

    private Vector3 screenPoint3;
    private Vector3 startPosition3;
    public GameObject dropPlace_GO3;
    public GameObject dropPlace_TO3;

    private Vector3 dropPlacePosition3;
    private Vector3 startUp3;
    public CoinCounter coinz;
    public DragInt2 di2;

    public int i;

    public Timer tick;

    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePosition3 = dropPlace_GO3.GetComponent<Transform>().position;
        startUp3 = dropPlace_TO3.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePosition3;
            i += 1;
            di2.j += 1;
        }
        else if (i == 2)
        {
            di2.j -= 1;
            this.gameObject.transform.position = startUp3;
            i -= 1;
        }
        if (di2.j == 3)
        {
            di2.j += 10;
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
        startPosition3 = this.gameObject.transform.position;
        screenPoint3 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint3.z);
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
