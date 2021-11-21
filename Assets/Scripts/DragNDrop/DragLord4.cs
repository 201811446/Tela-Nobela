using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragLord4 : MonoBehaviour
{

    private Vector3 screenPoin4;
    private Vector3 startPositio4;
    public GameObject dropPlace_G4;
    public GameObject dropPlace_T4;

    private Vector3 dropPlacePositio4;
    private Vector3 startU4;
    public DragLord3 DL3;

    public int i;


    //private bool isCorrectPlace;

    void Start()
    {
        dropPlacePositio4 = dropPlace_G4.GetComponent<Transform>().position;
        startU4 = dropPlace_T4.GetComponent<Transform>().position;
    }

    void Update()
    {

    }

    void OnMouseUp()
    {
        if (i == 1)
        {
            this.gameObject.transform.position = dropPlacePositio4;
            i += 1;
            DL3.counter2 += 1;
        }
        else if (i == 2)
        {
            DL3.counter2 -= 1;
            this.gameObject.transform.position = startU4;
            i -= 1;
        }
        if (DL3.counter2 == 3)
        {
                SceneManager.LoadScene("SDB");
        }
    }

    void OnMouseDown()
    {
        startPositio4 = this.gameObject.transform.position;
        screenPoin4 = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoin4.z);
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
