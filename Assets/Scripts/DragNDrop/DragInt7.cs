using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragInt7 : MonoBehaviour
{

    private Vector3 screenPoint6;
    private Vector3 startPosition6;
    public GameObject dropPlace_GO6;
    public GameObject dropPlace_TO6;

    private Vector3 dropPlacePosition6;
    private Vector3 startUp6;
    public CoinCounter coinz;
    public DragInt5 di3;

    public int i;

    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePosition6 = dropPlace_GO6.GetComponent<Transform>().position;
        startUp6 = dropPlace_TO6.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePosition6;
            i += 1;
            di3.k += 1;
        }
        else if (i == 2)
        {
            di3.k -= 1;
            this.gameObject.transform.position = startUp6;
            i -= 1;
        }
        if (di3.k == 3)
        {
            di3.k += 10;
            coinz.coins += 1;
            if (coinz.coins == 3)
            {
                SceneManager.LoadScene("WIN");
            }
        }
    }

    void OnMouseDown()
    {
        startPosition6 = this.gameObject.transform.position;
        screenPoint6 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint6.z);
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
