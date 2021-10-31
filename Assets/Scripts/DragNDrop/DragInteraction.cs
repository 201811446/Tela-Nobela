using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragInteraction : MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 startPosition;
    public GameObject dropPlace_GO;
    public GameObject dropPlace_TO;

    private Vector3 dropPlacePosition;
    private Vector3 startUp;

    public int i;

    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePosition = dropPlace_GO.GetComponent<Transform>().position;
        startUp = dropPlace_TO.GetComponent<Transform>().position;
    }
    
    void Update()
    {
        
    }

    void OnMouseUp()
    {
        if(i == 1)
        {
            this.gameObject.transform.position = dropPlacePosition;
            i += 1;
        }
        else if(i == 2)
        {
            this.gameObject.transform.position = startUp;
            i -= 1;
        }
    }

    void OnMouseDown()
    {
        startPosition = this.gameObject.transform.position;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
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
