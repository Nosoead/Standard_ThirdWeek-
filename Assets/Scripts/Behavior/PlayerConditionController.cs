
using System;
using UnityEngine;

public class PlayerConditionController : MonoBehaviour
{
    public HealthHandler healthHandler;
    public ManaHandler manaHandler;

    private void Awake()
    {
        healthHandler = GetComponentInChildren<HealthHandler>();
        manaHandler = GetComponentInChildren<ManaHandler>();
    }

    private void Update()
    {
        UpdateConditionUI();
    }

    private void UpdateConditionUI()
    {
        UIManager.Instance.conditionControllerUI.healthUI.ApplyUI(healthHandler.CurrentValue, healthHandler.MaxValue);
        UIManager.Instance.conditionControllerUI.manaUI.ApplyUI(manaHandler.CurrentValue, manaHandler.MaxValue);
    }
}