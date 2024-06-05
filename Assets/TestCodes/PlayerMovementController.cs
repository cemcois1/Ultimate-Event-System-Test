using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpSpeed = 5.0f;
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private PlayerInputHandler playerInputHandler;

    private void Start()
    {
        playerInputHandler.playerInput.Player.Jump.performed +=Jump;
    }

    private void OnDisable()
    {
        playerInputHandler.playerInput.Player.Jump.performed -=Jump;
    }

    // WASD ile hareket

    void Update()
    {
        var movementInput = playerInputHandler.GetMovementInput();
        rigidbody.velocity = new Vector3(movementInput.x * speed, rigidbody.velocity.y, movementInput.z * speed);
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        if (obj.ReadValueAsButton())
        {
            rigidbody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }
    }
}