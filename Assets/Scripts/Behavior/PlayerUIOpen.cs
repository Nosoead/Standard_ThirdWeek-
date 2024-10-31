using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUIOpen : MonoBehaviour
{
    private InputHandler inputHandler;
    bool isPlaying = true;

    private void Awake()
    {
        inputHandler = GetComponent<InputHandler>();
    }

    private void OnEnable()
    {
        inputHandler.OnUIOpenEvent += OnOpenUI;
    }
    private void OnDisable()
    {
        inputHandler.OnUIOpenEvent -= OnOpenUI;
    }

    private void Start()
    {
        UIManager.Instance.preferences.SetActive(false);
    }

    private void OnOpenUI()
    {
        isPlaying = !isPlaying;
        UIManager.Instance.preferences.SetActive(!isPlaying);
        Cursor.lockState = isPlaying ? CursorLockMode.Locked : CursorLockMode.None;
    }
}

