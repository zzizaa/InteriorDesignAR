using System;
using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using Oculus.Interaction.Surfaces;
using UnityEngine;

public class RayMovement : MonoBehaviour
{
    private GameObject _modelToMove;
    [SerializeField] private GameObject _floor;
    [SerializeField] private ColliderSurface _floorSurface;
    [SerializeField] private RayInteractor _rayInteractor;

    public void SelectObject(GameObject model)
    {
        print("Oggetto selezionato " + model.name);
        _modelToMove = model;
    }

    public void DeselectObject()
    {
        _modelToMove = null;
    }
    
    
    /*public void MoveToSelectedLocation()
    {
        if (_modelToMove == null) return;
        else
        {
            //Spostare l'oggetto nel punto corrispondete all'hit del raycast
            //_modelToMove.transform.position = hitPoint.transform.position;
        }
    }*/
    public void GetRayCastHitPoint(RayInteractor rayInteractor)
    {
        //Spostare definitivamente il modello nel punto scelto 
        print("RAYCAST POINT: " + _rayInteractor.CollisionInfo.Value.Point);
        if (_modelToMove == null) return;
        else
        {
            _modelToMove.transform.position = rayInteractor.CollisionInfo.Value.Point;
            //_modelToMove.transform.position = _rayInteractor.CollisionInfo.Value.Point;
        }
    }
    
}