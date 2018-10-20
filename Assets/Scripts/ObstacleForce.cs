using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleForce : MonoBehaviour {

    public ConstantForce playerForce;
    private ConstantForce obstacleForce;

    // Use this for initialization
    void Start ()
    {
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
