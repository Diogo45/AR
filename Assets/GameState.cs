using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{

    public static GameState inst;

    public bool HasFingers = false;

    public bool Pinch = false;
    public bool CarryingObject = false;

    public string carriedGameObject = "";

    public GameObject ground;

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
    }
}
