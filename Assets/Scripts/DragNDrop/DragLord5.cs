using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragLord5 : MonoBehaviour
{

    private Vector3 screenPoin5;
    private Vector3 startPositio5;
    public GameObject dropPlace_G5;
    public GameObject dropPlace_T5;

    private Vector3 dropPlacePositio5;
    private Vector3 startU5;
    public DragLord3 DL4;

    public int i;


    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePositio5 = dropPlace_G5.GetComponent<Transform>().position;
        startU5 = dropPlace_T5.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePositio5;
            i += 1;
            DL4.counter2 += 1;
        }
        else if (i == 2)
        {
            DL4.counter2 -= 1;
            this.gameObject.transform.position = startU5;
            i -= 1;
        }
        if (DL4.counter2 == 3)
        {
                SceneManager.LoadScene("SDB");
        }
    }

    void OnMouseDown()
    {
        startPositio5 = this.gameObject.transform.position;
        screenPoin5 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoin5.z);
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
