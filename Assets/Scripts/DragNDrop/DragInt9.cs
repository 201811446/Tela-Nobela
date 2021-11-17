using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragInt9 : MonoBehaviour
{

    private Vector3 screenPoint8;
    private Vector3 startPosition8;
    public GameObject dropPlace_GO8;
    public GameObject dropPlace_TO8;

    private Vector3 dropPlacePosition8;
    private Vector3 startUp8;
    public CoinCounter coinz;
    public DragInt8 d4;

    public int i;

    public Timer tick;

    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePosition8 = dropPlace_GO8.GetComponent<Transform>().position;
        startUp8 = dropPlace_TO8.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePosition8;
            i += 1;
            d4.l += 1;
        }
        else if (i == 2)
        {
            d4.l -= 1;
            this.gameObject.transform.position = startUp8;
            i -= 1;
        }
        if (d4.l == 3)
        {
            d4.l += 10;
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
        startPosition8 = this.gameObject.transform.position;
        screenPoint8 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint8.z);
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
