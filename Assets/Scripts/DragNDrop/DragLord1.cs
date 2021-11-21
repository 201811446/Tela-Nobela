using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragLord1 : MonoBehaviour
{

    private Vector3 screenPoin1;
    private Vector3 startPositio1;
    public GameObject dropPlace_G1;
    public GameObject dropPlace_T1;

    private Vector3 dropPlacePositio1;
    private Vector3 startU1;
    public DragLord DL1;

    public int i;


    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePositio1 = dropPlace_G1.GetComponent<Transform>().position;
        startU1 = dropPlace_T1.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePositio1;
            i += 1;
            DL1.counter1 += 1;
        }
        else if (i == 2)
        {
            DL1.counter1 -= 1;
            this.gameObject.transform.position = startU1;
            i -= 1;
        }
        if (DL1.counter1 == 3)
        {
                SceneManager.LoadScene("SDA");
        }
    }

    void OnMouseDown()
    {
        startPositio1 = this.gameObject.transform.position;
        screenPoin1 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoin1.z);
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
