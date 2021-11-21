using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragLord9 : MonoBehaviour
{

    private Vector3 screenPoin9;
    private Vector3 startPositio9;
    public GameObject dropPlace_G9;
    public GameObject dropPlace_T9;

    private Vector3 dropPlacePositio9;
    private Vector3 startU9;
    public DragLord6 DL9;

    public int i;


    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePositio9 = dropPlace_G9.GetComponent<Transform>().position;
        startU9 = dropPlace_T9.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePositio9;
            i += 1;
            DL9.counter3 += 1;
        }
        else if (i == 2)
        {
            DL9.counter3 -= 1;
            this.gameObject.transform.position = startU9;
            i -= 1;
        }
        if (DL9.counter3 == 4)
        {
                SceneManager.LoadScene("SDC");
        }
    }

    void OnMouseDown()
    {
        startPositio9 = this.gameObject.transform.position;
        screenPoin9 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoin9.z);
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
