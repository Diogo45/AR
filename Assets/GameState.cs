using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARSubsystems;


public class GameState : MonoBehaviour
{

    public static GameState inst;

    public bool HasFingers = false;

    public bool Pinch = false;
    public bool CarryingObject = false;

    public string carriedGameObject = "";

    public GameObject ground;

    public int CurrentState = 0;

    //private bool spawned = false;

    private void Awake()
    {
        if (!inst)
        {
            inst = this;
        }
        else
        {
            Destroy(this);
        }


        var tracking = new List<UnityEngine.XR.InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.HandTracking, tracking);

        foreach(InputDevice id in tracking)
        {
            Debug.Log("AAAAAAAA" + id.name);
        }




    }


    //private void Update()
    //{
    //    if (!spawned)
    //    {
    //        if (Camera.main.depthTextureMode == DepthTextureMode.None)
    //        {
    //            var g = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //            g.transform.localScale = Vector3.one / 10f;
    //            g.transform.transform.parent = Camera.main.transform;
    //            g.transform.position += Vector3.forward / 2.5f;
    //        }
    //        else
    //        {
    //            var g = GameObject.CreatePrimitive(PrimitiveType.Capsule);
    //            g.transform.localScale = Vector3.one / 10f;
    //            g.transform.transform.parent = Camera.main.transform;
    //            g.transform.position += Vector3.forward / 2.5f;
    //        }
    //        spawned = true;
    //    }
    //}

}
