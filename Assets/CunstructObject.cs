using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CunstructObject : MonoBehaviour
{

    public GameObject PreviousNeeded;
    public Text debug; 

    private GameState GameState;
    private Transform parentTransform;



    // Start is called before the first frame update
    void Start()
    {
        GameState = FindObjectOfType<GameState>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(gameObject.transform.position, PreviousNeeded.transform.position) < 0.1f && Mathf.Abs(Quaternion.Angle(parentTransform.rotation, PreviousNeeded.transform.rotation)) < 100f)
        {
            for(int i = 0; i < gameObject.GetComponent<MeshRenderer>().materials.Length && i < PreviousNeeded.GetComponent<MeshRenderer>().materials.Length; i++)
            {
                PreviousNeeded.GetComponent<MeshRenderer>().materials[i] = gameObject.GetComponent<MeshRenderer>().materials[i];
            }

            debug.text = "AAAAAAA";
            Destroy(gameObject);
        }

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
