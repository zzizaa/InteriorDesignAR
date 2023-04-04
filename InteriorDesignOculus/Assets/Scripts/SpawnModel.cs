using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnModel : MonoBehaviour
{
    [SerializeField] private GameObject _chair;
    [SerializeField] private Transform spawningPoint;
    [SerializeField] private List<ModelScriptableObject> _models;
    [SerializeField] private GameObject _model;
    

    public void SelectModel(int i)
    {
        Instantiate(_models[i].model, _model.transform.position, Quaternion.identity);
    }
    public void SpawnChair()
    {
        print("Chair Spawned");
        //Choose the position where to spawn the model (preset: 1,1,1)
        //A good way is to spawn in front of the player, maybe 2m, at level of terrain
        _chair.transform.position = new Vector3(1, 1, 1);
        _chair.SetActive(true);
        
    }

    public void DestroyChair()
    {
        _chair.SetActive(false);
    }
}
