using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;


    [Header("Jump")]
    public float jumpPower;
    public LayerMask groudLayerMask;

    [Header("Look")]
    public Transform cameraContainer;
    public float minXLook;
    public float maxXLook;
    private float cameraCurrentRotation;
    public float lookSensitivity;
}
