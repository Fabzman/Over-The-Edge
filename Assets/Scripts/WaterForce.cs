﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterForce : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;
    public float waterStrength;
    private ConstantForce waterForce;
    public float speedIncrease;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        waterForce = GetComponent<ConstantForce>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.right * thrust);
        }

        waterStrength += (Time.deltaTime);
        waterForce.force = new Vector3(-1f - Mathf.RoundToInt(waterStrength / speedIncrease) * 0.1f, 0, 0);
    }

    void FixedUpdate()
    {
        //GetComponent<ConstantForce>().force = Vector3.left * 0.1f;
        //rb.constantForce = 10;
    }
}