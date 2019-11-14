using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchController : MonoBehaviour
{

    [SerializeField]
    public GameObject Indicador;
    [SerializeField]
    public GameObject Dedao;

    [Range(0.001f, 0.1f)]
    public float threshold = 0.05f;


    private GameState gameState;
    private Vuforia.ImageTargetBehaviour indicadorTracker;
    private Vuforia.ImageTargetBehaviour dedaoTracker;


    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.inst;
        indicadorTracker = Indicador.transform.parent.GetComponent<Vuforia.ImageTargetBehaviour>();
        dedaoTracker = Dedao.transform.parent.GetComponent<Vuforia.ImageTargetBehaviour>();
    }

    private void OnDrawGizmos()
    {
        if (gameState && gameState.Pinch)
        {
            Gizmos.DrawCube((Indicador.transform.position + Dedao.transform.position) / 2f, Vector3.one / 40f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: Tratar quando se perde o trackig do dedo enquanto carregando
        if (indicadorTracker.CurrentStatus != Vuforia.TrackableBehaviour.Status.TRACKED || dedaoTracker.CurrentStatus != Vuforia.TrackableBehaviour.Status.TRACKED)
        {
            //Debug.Log("FINGER NOT TRACKED \n RE-TRACK");
            return;
        }


        if(Vector3.Distance(Indicador.transform.position, Dedao.transform.position) < threshold)
        {
            Debug.DrawLine(Indicador.transform.position, Dedao.transform.position,Color.red);
            gameState.Pinch = true;
        }
        else
        {
            Debug.DrawLine(Indicador.transform.position, Dedao.transform.position,Color.blue);
            gameState.Pinch = false;
        }

        if (gameState.Pinch && !gameState.CarryingObject)
        {

           
            Collider[] col = Physics.OverlapSphere((Indicador.transform.position + Dedao.transform.position) / 2f, 0.025f);
            if (col.Length > 0)
            {
                //col[0].transform.parent = Indicador.transform;
                for (int i = 0; i < col.Length; i++)
                {
                    bool keepGoing = col[i].gameObject.TryGetComponent(out PinchableObject pinchable);
                    if (!keepGoing) continue;
                    Debug.Log("WOLOLO " + col[i].gameObject.name);
                    pinchable.pinched = true;
                    pinchable.pincerOne = Indicador;
                    pinchable.pincerTwo = Dedao;
                    gameState.CarryingObject = true;
                }
            }
        }
        else if (!gameState.Pinch && gameState.CarryingObject)
        {
            Collider[] col = Physics.OverlapSphere((Indicador.transform.position + Dedao.transform.position) / 2f, 0.025f);
            for (int i = 0; i < col.Length; i++)
            {
                bool keepGoing = col[i].gameObject.TryGetComponent(out PinchableObject pinchable);
                if (!keepGoing || !pinchable.pinched) continue;
                Debug.Log("NOLOLO" + col[i].gameObject.name);
                pinchable.pinched = false;
                pinchable.pincerOne = null;
                pinchable.pincerTwo = null;
                gameState.CarryingObject = false;
            }
        }

    }
}
