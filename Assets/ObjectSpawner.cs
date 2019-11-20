using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ObjectSpawner : DefaultTrackableEventHandler
{

    public GameObject objPrefab;
    private bool instantiated = false;

    protected override void OnTrackingFound()
    {
        if (!instantiated)
        {
            Instantiate(objPrefab, gameObject.transform.position, Quaternion.identity);
            instantiated = true;
        }
    }

}

