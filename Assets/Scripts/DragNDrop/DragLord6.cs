using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragLord6 : MonoBehaviour
{

    private Vector3 screenPoin6;
    private Vector3 startPositio6;
    public GameObject dropPlace_G6;
    public GameObject dropPlace_T6;

    private Vector3 dropPlacePositio6;
    private Vector3 startU6;
    public int counter3;

    public int i;


    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePositio6 = dropPlace_G6.GetComponent<Transform>().position;
        startU6 = dropPlace_T6.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePositio6;
            i += 1;
            counter3 += 1;
        }
        else if (i == 2)
        {
            counter3 -= 1;
            this.gameObject.transform.position = startU6;
            i -= 1;
        }
        if (counter3 == 4)
        {
                SceneManager.LoadScene("SDC");
        }
    }

    void OnMouseDown()
    {
        startPositio6 = this.gameObject.transform.position;
        screenPoin6 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoin6.z);
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
