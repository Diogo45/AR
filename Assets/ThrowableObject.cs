using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PinchableObject))]
public class ThrowableObject : MonoBehaviour
{

    private Rigidbody rBody;
    private PinchableObject pBody;

    private Vector3 originalPos;

    private bool wasPinchedLastFrame = false;
    // Start is called before the first frame update
    void Start()
    {
        rBody = gameObject.GetComponent<Rigidbody>();   
        pBody = gameObject.GetComponent<PinchableObject>();
        originalPos = gameObject.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (!pBody.pinched && wasPinchedLastFrame)
        {
            rBody.isKinematic = false;
            //rBody.useGravity = false;
            rBody.angularVelocity += Camera.main.gameObject.transform.forward;
            rBody.velocity += Camera.main.gameObject.transform.forward;
        }
        else if (pBody.pinched)
        {
            rBody.isKinematic = true;
        }

        

        wasPinchedLastFrame = pBody.pinched;
    }
}
