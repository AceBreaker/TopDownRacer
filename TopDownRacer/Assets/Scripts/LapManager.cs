using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapManager : MonoBehaviour {

    int checkpointCount = 0;

    public int checkPointsHit = 0;

    public int lapsCompleted = 0;
    [SerializeField]
    int totalLaps = 3;

    public static bool raceCompleted = false;

    public delegate void GenericDelegate();
    public static GenericDelegate onLapComplete = null;

	// Use this for initialization
	void Start () {
        checkpointCount = transform.childCount;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NewCheckPointHit()
    {
        checkPointsHit++;
    }

    void OnRaceOver()
    {
        if(lapsCompleted == totalLaps)
        {
            raceCompleted = true;
        }
    }

    public void CheckForEndOfLap()
    {
        if (checkPointsHit == checkpointCount)
        {
            onLapComplete();
            checkPointsHit = 0;
            lapsCompleted++;
            OnRaceOver();
        }
    }
}
