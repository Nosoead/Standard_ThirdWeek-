using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;


    [Header("Jump")]
    public float jumpPower;
    public LayerMask groundLayerMask;

    [Header("Look")]
    public Transform cameraContainer;
    public float minXLook;
    public float maxXLook;
    public float lookSensitivity;


    [Header("Conditions")]
    [SerializeField] private float startHealth;
    [SerializeField] private float startMana;
    public float StartHealth { get { return startHealth; } }
    public float StartMana { get { return startMana; } }
}
