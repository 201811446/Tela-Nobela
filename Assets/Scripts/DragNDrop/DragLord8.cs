using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragLord8 : MonoBehaviour
{

    private Vector3 screenPoin8;
    private Vector3 startPositio8;
    public GameObject dropPlace_G8;
    public GameObject dropPlace_T8;

    private Vector3 dropPlacePositio8;
    private Vector3 startU8;
    public DragLord6 DL8;

    public int i;


    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePositio8 = dropPlace_G8.GetComponent<Transform>().position;
        startU8 = dropPlace_T8.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePositio8;
            i += 1;
            DL8.counter3 += 1;
        }
        else if (i == 2)
        {
            DL8.counter3 -= 1;
            this.gameObject.transform.position = startU8;
            i -= 1;
        }
        if (DL8.counter3 == 4)
        {
                SceneManager.LoadScene("SDC");
        }
    }

    void OnMouseDown()
    {
        startPositio8 = this.gameObject.transform.position;
        screenPoin8 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoin8.z);
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
