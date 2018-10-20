using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    bool hasBeenHitThisLap = false;
    LapManager lapManager = null;
    public bool isFinishLine = false;

	// Use this for initialization
	void Start () {
        lapManager = transform.parent.GetComponent<LapManager>();
        LapManager.onLapComplete += ResetLap;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        switch(other.transform.root.tag)
        {
            case "Player":
                if(isFinishLine)
                {
                    lapManager.CheckForEndOfLap();
                }
                if (!hasBeenHitThisLap)
                {
                    hasBeenHitThisLap = true;
                    lapManager.NewCheckPointHit();
                }
                break;
            default:
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.transform.root.tag)
        {
            case "Player":
                if (!hasBeenHitThisLap)
                {
                    hasBeenHitThisLap = true;
                    lapManager.NewCheckPointHit();
                }
                break;
            default:
                break;
        }
    }

    private void ResetLap()
    {
        hasBeenHitThisLap = false;
    }
}
