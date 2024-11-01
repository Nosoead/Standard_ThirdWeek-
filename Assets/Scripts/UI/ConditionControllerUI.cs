using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionControllerUI : MonoBehaviour
{
    public HealthUI healthUI;
    public ManaUI manaUI;

    private void Awake()
    {
        healthUI = GetComponentInChildren<HealthUI>();
        manaUI = GetComponentInChildren<ManaUI>();
    }
}
