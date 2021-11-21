using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragLord3 : MonoBehaviour
{

    private Vector3 screenPoin3;
    private Vector3 startPositio3;
    public GameObject dropPlace_G3;
    public GameObject dropPlace_T3;

    private Vector3 dropPlacePositio3;
    private Vector3 startU3;
    public int counter2;

    public int i;


    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePositio3 = dropPlace_G3.GetComponent<Transform>().position;
        startU3 = dropPlace_T3.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePositio3;
            i += 1;
            counter2 += 1;
        }
        else if (i == 2)
        {
            counter2 -= 1;
            this.gameObject.transform.position = startU3;
            i -= 1;
        }
        if (counter2 == 3)
        {
                SceneManager.LoadScene("SDB");
        }
    }

    void OnMouseDown()
    {
        startPositio3 = this.gameObject.transform.position;
        screenPoin3 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoin3.z);
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
