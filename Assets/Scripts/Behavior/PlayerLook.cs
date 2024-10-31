using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    
    private float cameraCurrentXRotation;
    private float cameraCurrentYRotation;
    private Vector2 mouseDelta;
    private bool canLook = true;

    private InputHandler inputHandler;
    private PlayerStat stat;
   
    private void Awake()
    {
        inputHandler = GetComponent<InputHandler>();
        stat = GetComponent<PlayerStat>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnEnable()
    {
        inputHandler.OnLookEvent += OnPlayerLook;
        inputHandler.OnUIOpenEvent += OnUIOpenInLook;
    }

    private void OnDisable()
    {
        inputHandler.OnLookEvent -= OnPlayerLook;
        inputHandler.OnUIOpenEvent -= OnUIOpenInLook;
    }


    private void LateUpdate()
    {
        if (canLook)
        {
            ApplyLook();
        }
    }

    private void OnUIOpenInLook()
    {
        canLook = !canLook;
        Cursor.lockState = canLook ? CursorLockMode.Locked : CursorLockMode.None;
    }

    //연산
    private void OnPlayerLook(Vector2 mouseDelta)
    {
        cameraCurrentXRotation += mouseDelta.y * stat.lookSensitivity;
        cameraCurrentXRotation = Mathf.Clamp(cameraCurrentXRotation, stat.minXLook, stat.maxXLook);
        cameraCurrentYRotation = mouseDelta.x * stat.lookSensitivity;
    }

    //적용
    private void ApplyLook()
    {
        stat.cameraContainer.localEulerAngles = new Vector3(-cameraCurrentXRotation, 0, 0);
        transform.eulerAngles += new Vector3(0, cameraCurrentYRotation, 0);
    }
        //parent --> localEulerAngles
        //gameObject --> eulerAngles
}
