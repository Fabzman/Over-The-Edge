using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleForce : MonoBehaviour {

    private ConstantForce playerForce;
    private ConstantForce obstacleForce;

    // Use this for initialization
    void Start ()
    {
        playerForce = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<ConstantForce>();
        //if(playerForce)
        obstacleForce = GetComponent<ConstantForce>();
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    private void FixedUpdate()
    {
        obstacleForce.force = playerForce.force;
    }
}
