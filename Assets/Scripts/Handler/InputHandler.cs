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
    public UnityAction OnInteractiveEvent;
    private ManaHandler manaHandler;

    private void Awake()
    {
        manaHandler = GetComponent<ManaHandler>();
    }

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
        if (context.phase == InputActionPhase.Performed)
        {
            Vector2 mouseDelta = context.ReadValue<Vector2>();
            OnLookEvent?.Invoke(mouseDelta);
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            Vector2 mouseDelta = context.ReadValue<Vector2>();
            OnLookEvent?.Invoke(mouseDelta);
        }
        //Vector2 mouseDelta = context.ReadValue<Vector2>();
        //    OnLookEvent?.Invoke(mouseDelta);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            OnJumpEvent?.Invoke();
        }
    }

    public void OnUIOpen(InputAction.CallbackContext context)
    {
        OnUIOpenEvent?.Invoke();
    }
    public void OnInteractive(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            OnInteractiveEvent?.Invoke();
        }
    }

    public void OnCastSkill(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            Debug.Log("��ų���");
            float usingMana = -10;
            if (manaHandler.CurrentValue > Mathf.Abs(usingMana))
            {
                manaHandler.ApplyExternalEffect(usingMana);
            }
        }
    }

    public void OnUsePotion(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            Debug.Log("����ȸ��");
            float manaRecovery = 20;
            manaHandler.ApplyExternalEffect(manaRecovery);
        }
    }
}
