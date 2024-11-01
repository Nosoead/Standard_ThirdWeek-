using UnityEngine;
using UnityEngine.UI;

public class ConditionUI : MonoBehaviour
{
    public Image uiBar;

    public void ApplyUI(float currentValue, float maxValue)
    {
        uiBar.fillAmount = currentValue / maxValue;
    }
}