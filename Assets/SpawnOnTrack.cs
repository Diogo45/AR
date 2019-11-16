using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnTrack : DefaultTrackableEventHandler
{

    public GameObject spawn;
    public bool spawned = false;


    protected override void OnTrackingFound()
    {
        if (spawned) return;
        GameObject parent = GameState.inst.ground;
        Instantiate(spawn, parent.transform);
        spawned = true;
    }
}
