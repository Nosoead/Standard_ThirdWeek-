using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public UnityAction<Vector2> OnMoveEvent;
    public UnityAction<Vector2> OnLookEvent;
    public UnityAction OnJumpEvent;
    public UnityAction OnUIOpenEvent;

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            Vector2 moveDirection = context.ReadValue<Vector2>();
            OnMoveEvent?.Invoke(moveDirection);
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            Vector2 moveDirection = context.ReadValue<Vector2>();
            OnMoveEvent?.Invoke(moveDirection);
        }
    }

    public void OnLook(InputAction.CallbackContext context)
    {
            Vector2 mouseDelta = context.ReadValue<Vector2>();
            OnLookEvent?.Invoke(mouseDelta);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            Debug.Log("test");
            OnJumpEvent?.Invoke();
        }
    }

    public void OnUIOpen(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            OnUIOpenEvent?.Invoke();
        }
    }
}
