using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    float time = 0.0f;
    [SerializeField]
    UnityEngine.UI.Text timeDisplay = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!LapManager.raceCompleted)
        {
            time += Time.deltaTime;

            int minutes = (int)time / 60;
            float seconds = time - (float)minutes * 60;

            timeDisplay.text = minutes.ToString() + ":" + seconds.ToString("00.000");
        }
	}
}
