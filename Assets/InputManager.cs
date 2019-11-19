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
    
}
