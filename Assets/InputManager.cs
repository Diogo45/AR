using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool dragging = false;
    void Start()
    {
        
    }
    private void OnMouseDown()
    {

        dragging = true;
        GetComponent<LeanDragTranslate>().enabled = true;
    }
    private void OnMouseUp()
    {
        dragging = false;
        GetComponent<LeanDragTranslate>().enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        /*
        if (dragging)
        {
            
            Vector3 posn = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //posn.y = 0;
            transform.position = posn;
        }
        if (Input.touchCount>0) {
            Touch touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                Debug.Log(hit.transform.name);
                hit.transform.Translate()
            }
        }
        */

    }
}
