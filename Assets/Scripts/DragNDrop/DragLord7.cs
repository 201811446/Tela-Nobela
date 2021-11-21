using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragLord7 : MonoBehaviour
{

    private Vector3 screenPoin7;
    private Vector3 startPositio7;
    public GameObject dropPlace_G7;
    public GameObject dropPlace_T7;

    private Vector3 dropPlacePositio7;
    private Vector3 startU7;
    public DragLord6 DL7;

    public int i;


    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePositio7 = dropPlace_G7.GetComponent<Transform>().position;
        startU7 = dropPlace_T7.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePositio7;
            i += 1;
            DL7.counter3 += 1;
        }
        else if (i == 2)
        {
            DL7.counter3 -= 1;
            this.gameObject.transform.position = startU7;
            i -= 1;
        }
        if (DL7.counter3 == 4)
        {
                SceneManager.LoadScene("SDC");
        }
    }

    void OnMouseDown()
    {
        startPositio7 = this.gameObject.transform.position;
        screenPoin7 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoin7.z);
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
