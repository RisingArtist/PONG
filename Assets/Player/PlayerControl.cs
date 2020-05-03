using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public bool isPlayer2;
    InputMaster inputMaster;
    Vector2 moveDirection = Vector2.zero;
    Rigidbody2D rb;
    Vector3 direction;

    private void Awake()
    {
        inputMaster = new InputMaster();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if(!isPlayer2)
        {
            //Player 1 
            inputMaster.Player_1.Move.performed += Move;
            inputMaster.Player_1.Move.canceled += Move;
        }
        else
        {
            //Player 2
            inputMaster.Player_2.Move.performed += Move;
            inputMaster.Player_2.Move.canceled += Move;
        }
    }


        
    // Get direction to move the paddle
    private void Move(InputAction.CallbackContext obj)
    {
        moveDirection = new Vector3(0, obj.ReadValue<Vector2>().y, 0);
    }

    // Move the paddle
    void FixedUpdate()
    {
        rb.velocity = moveDirection * speed;
    }

    // Disable Player Input
    private void OnDisable()
    {
        inputMaster.Disable();
    }

    // Enable Player Input
    private void OnEnable()
    {
        inputMaster.Enable();
    }

}
