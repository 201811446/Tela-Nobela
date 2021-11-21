using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragLord : MonoBehaviour
{

    private Vector3 screenPoin;
    private Vector3 startPositio;
    public GameObject dropPlace_G;
    public GameObject dropPlace_T;

    private Vector3 dropPlacePositio;
    private Vector3 startU;
    public int counter1;

    public int i;


    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePositio = dropPlace_G.GetComponent<Transform>().position;
        startU = dropPlace_T.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePositio;
            i += 1;
            counter1 += 1;
        }
        else if (i == 2)
        {
            counter1 -= 1;
            this.gameObject.transform.position = startU;
            i -= 1;
        }
        if (counter1 == 3)
        {
                SceneManager.LoadScene("SDA");
        }
    }

    void OnMouseDown()
    {
        startPositio = this.gameObject.transform.position;
        screenPoin = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoin.z);
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
