using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody movementRigidbody;
    private InputHandler inputHandler;
    private PlayerStat stat;
    private Vector3 moveDirection = Vector3.zero;

    private void Awake()
    {
        movementRigidbody = GetComponent<Rigidbody>();
        inputHandler = GetComponent<InputHandler>();
        stat = GetComponent<PlayerStat>();
    }

    private void OnEnable()
    {
        inputHandler.OnMoveEvent += OnMovement;
    }

    private void OnDisable()
    {
        inputHandler.OnMoveEvent -= OnMovement;
    }

    private void FixedUpdate()
    {
        ApplyMovement(moveDirection);
    }

    private void OnMovement(Vector2 direction)
    {
        Vector3 realDirection = transform.forward * direction.y + transform.right * direction.x;
        realDirection *= stat.moveSpeed;
        realDirection.y = movementRigidbody.velocity.y;
        moveDirection = realDirection;
    }

    private void ApplyMovement(Vector3 moveDirection)
    {
        movementRigidbody.velocity = moveDirection;
    }
}
