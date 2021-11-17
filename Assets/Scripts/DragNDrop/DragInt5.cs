using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragInt5 : MonoBehaviour
{

    private Vector3 screenPoint4;
    private Vector3 startPosition4;
    public GameObject dropPlace_GO4;
    public GameObject dropPlace_TO4;

    private Vector3 dropPlacePosition4;
    private Vector3 startUp4;
    public CoinCounter coinz;
    public int k;

    public int i;

    public Timer tick;

    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePosition4 = dropPlace_GO4.GetComponent<Transform>().position;
        startUp4 = dropPlace_TO4.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePosition4;
            i += 1;
            k += 1;
        }
        else if (i == 2)
        {
            k -= 1;
            this.gameObject.transform.position = startUp4;
            i -= 1;
        }
        if (k == 3)
        {
            k += 10;
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
        startPosition4 = this.gameObject.transform.position;
        screenPoint4 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint4.z);
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
