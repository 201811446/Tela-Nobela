using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragInt6 : MonoBehaviour
{

    private Vector3 screenPoint5;
    private Vector3 startPosition5;
    public GameObject dropPlace_GO5;
    public GameObject dropPlace_TO5;

    private Vector3 dropPlacePosition5;
    private Vector3 startUp5;
    public CoinCounter coinz;
    public DragInt5 d3;

    public int i;

    public Timer tick;

    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePosition5 = dropPlace_GO5.GetComponent<Transform>().position;
        startUp5 = dropPlace_TO5.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePosition5;
            i += 1;
            d3.k += 1;
        }
        else if (i == 2)
        {
            d3.k -= 1;
            this.gameObject.transform.position = startUp5;
            i -= 1;
        }
        if (d3.k == 3)
        {
            d3.k += 10;
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
        startPosition5 = this.gameObject.transform.position;
        screenPoint5 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint5.z);
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
