using System;
using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using Oculus.Interaction.Surfaces;
using UnityEngine;

public class RayMovement : MonoBehaviour
{
    [SerializeField] private GameObject _modelToMove;
    [SerializeField] private GameObject _floor;
    [SerializeField] private ColliderSurface _floorSurface;
    [SerializeField] private RayInteractor _rayInteractor;
    public RayInteractable _rayInteractableComponent;
    private bool _isSelected;


    private void Update()
    {
        if(_isSelected) MoveSelectedObject();
    }

    public void SelectObject(GameObject model)
    {
        print("Oggetto selezionato " + model.name);
        _modelToMove = model;
        print("Oggetto assegnato " + _modelToMove.name);
        _isSelected = true;
    }

    public void DeselectObject()
    {
        _modelToMove = null;
    }

    public void EnableRayInteractableScript()
    {
        _rayInteractableComponent.enabled = true;
    }
    private void MoveSelectedObject()
    {
        if (_modelToMove == null) return;
        else
        {
            _modelToMove.transform.position = _rayInteractor.CollisionInfo.Value.Point;
        }
    }
    public void GetRayCastHitPoint(RayInteractor rayInteractor)
    {
        //Spostare definitivamente il modello nel punto scelto 
        print("RAYCAST POINT: " + _rayInteractor.CollisionInfo.Value.Point);
        if (_modelToMove == null) return;
        else
        {
            _modelToMove.transform.position = rayInteractor.CollisionInfo.Value.Point;
            print("POSIZIONE DEL MODELLO: " + _modelToMove.transform.position);
            ResetMaterial();
            DeselectObject();
            _isSelected = false;
            //_modelToMove.transform.position = _rayInteractor.CollisionInfo.Value.Point;
        }
    }

    public void ResetMaterial()
    {
        _modelToMove.GetComponentInChildren<ModelPersonalization>().ChangeMaterialOnPositioning();
    }
    
}
