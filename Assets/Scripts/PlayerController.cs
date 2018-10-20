using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed;
    public Rigidbody rb;
    private Vector3 movement;
    private Vector3 moveSpeed;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //movement = new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
        //moveSpeed = movement * Speed;
        //transform.localPosition += moveSpeed * Time.deltaTime;
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, Input.GetAxisRaw("Vertical") * Speed);
    }
}
