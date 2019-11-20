using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CunstructObject : MonoBehaviour
{

    private GameState GameState;

    // Start is called before the first frame update
    void Start()
    {
        GameState = GameObject.FindObjectOfType<GameState>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameState.CurrentState)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
        }
    }
}
