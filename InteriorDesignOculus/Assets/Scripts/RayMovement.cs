using System;
using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Surfaces;
using UnityEngine;

public class RayMovement : MonoBehaviour
{
    private GameObject _modelToMove;
    [SerializeField] private GameObject _floor;
    
    public void SelectObject(GameObject model)
    {
        print("Oggetto selezionato " + model.name);
        _modelToMove = model;
    }

    public void MoveToSelectedLocation()
    {
        if (_modelToMove == null) return;
        else
        {
            //Spostare l'oggetto nel punto corrispondete all'hit del raycast
            //_modelToMove.transform.position = hitPoint.transform.position;
        }
    }
    
    
}
