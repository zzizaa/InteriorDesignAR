using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnModel : MonoBehaviour
{
    [SerializeField] private GameObject _chair;
    [SerializeField] private Transform spawningPoint;
    
    public void SpawnChair()
    {
        Instantiate(_chair, spawningPoint.position, Quaternion.identity);
    }

    public void DestroyChair()
    {
        Destroy(_chair);
    }
}
