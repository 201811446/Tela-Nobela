using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragInt2 : MonoBehaviour
{

    private Vector3 screenPoint1;
    private Vector3 startPosition1;
    public GameObject dropPlace_GO1;
    public GameObject dropPlace_TO1;

    private Vector3 dropPlacePosition1;
    private Vector3 startUp1;
    public CoinCounter coinz;
    public int j;

    public int i;

    public Timer tick;

    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePosition1 = dropPlace_GO1.GetComponent<Transform>().position;
        startUp1 = dropPlace_TO1.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePosition1;
            i += 1;
            j += 1;
        }
        else if (i == 2)
        {
            j -= 1;
            this.gameObject.transform.position = startUp1;
            i -= 1;
        }
        if (j == 3)
        {
            j += 10;
            coinz.coins += 1;
            if(coinz.coins == 3)
            { 
                tick.currentTime = tick.startMinutes * 60;
                SceneManager.LoadScene("WIN");
            }
        }
    }

    void OnMouseDown()
    {
        startPosition1 = this.gameObject.transform.position;
        screenPoint1 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint1.z);
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
