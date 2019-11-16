using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchableObject : MonoBehaviour
{
    
    public GameObject pincerOne;
    public GameObject pincerTwo;

    public bool pinched = false;

        
    // Update is called once per frame
    void Update()
    {
        if (!pincerOne || !pincerTwo) return;

        if (!pinched) return;


        gameObject.transform.position = (pincerTwo.transform.position + pincerOne.transform.position)/2f;

        //if (gameObject.transform.position.y < 0f)
        //{
        //    gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0f, gameObject.transform.position.z);
        //}

    }
}
