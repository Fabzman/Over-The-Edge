using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CrowdMovement : MonoBehaviour
{
    public float jumpTime = .5F;
    public float minJumpDelay = 0F;
    public float maxJumpDelay = 2F;
    public float jumpPower = 1F;

    private float jumpTimer;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        jumpTimer -= Time.deltaTime;
        if (jumpTimer <= 0F)
        {
            jumpTimer = jumpTime + Random.Range(minJumpDelay, maxJumpDelay);
            transform.DOJump(transform.position, jumpPower, 1, jumpTime);
        }
    }
}
