using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOManager : MonoBehaviour
{
    [SerializeField] private List<NewGameObjectSO> newGameObjectSO = new List<NewGameObjectSO>();

    private void Start()
    {
        foreach (var SO in newGameObjectSO)
        {
            SO.newGameObject();
        }
    }
}
