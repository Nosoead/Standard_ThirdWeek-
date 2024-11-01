using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewGameObject", menuName = "ScriptableObject/NewGameObject" )]
public class NewGameObjectSO : ScriptableObject
{
    public string uniquID;
    public GameObject newGameObject()
    {
        GameObject newObject = new GameObject(uniquID);
        newObject.AddComponent<BoxCollider>();


        return newObject;
    }
}
