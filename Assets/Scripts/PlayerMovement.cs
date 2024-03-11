using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    [HideInInspector] public float lastHorizontalVector;
    [HideInInspector] public float lastVerticalVector;
    [HideInInspector] public Vector2 moveDir;
    void Start()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
    }

    void Update() // Frame rate dependent
    {
        InputManagement();
    }

    private void FixedUpdate() // Frame rate independent
    {
        Move();
    }

    void InputManagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDir = new Vector2(moveX, moveY).normalized;

        if (moveDir.x != 0)
            lastHorizontalVector = moveDir.x;
        if (moveDir.y != 0)
            lastVerticalVector = moveDir.x;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }
}
