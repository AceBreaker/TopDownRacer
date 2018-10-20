using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody myRigidbody = null;

    [SerializeField]
    float rotateRate = 1.0f;

    [SerializeField]
    float moveSpeed = 50.0f;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
        {
            myRigidbody.AddForce(transform.forward * moveSpeed);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            myRigidbody.AddForce(transform.forward * -moveSpeed);

        }

        if (Input.GetKey(KeyCode.A))
        {
            TurnCar(-1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            TurnCar(1);
        }
    }

    void TurnCar(int left)
    {
        transform.Rotate(new Vector3(0.0f, left * rotateRate, 0.0f));
    }
}
