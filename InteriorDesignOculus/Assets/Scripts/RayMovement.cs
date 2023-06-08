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
    private bool _isEditingMode;
    [SerializeField] private MenuManager _menuManager;
    [SerializeField] private GameObject _editingMenu;
    [SerializeField] private GameObject _modelMenu;

    private void Start()
    {
        //GetHand();
    }

    private void Update()
    {
        MoveSelectedObject();
    }

    public void SelectObject(GameObject model, bool isEditingMode)
    {
        print("Oggetto selezionato " + model.name);
        _isEditingMode = isEditingMode;
        _modelToMove = model;
        if (_isEditingMode)
        {
            ActivateEditCanvas();
        }
        print("Oggetto assegnato " + _modelToMove.name);
        //_selectHand.isLeftHand = true;
    }

    /*private void GetHand()
    {
        if (_rayInteractor.GetComponent<OVRHand.Hand>() == OVRHand.Hand.HandLeft)
        {
            _selectHand.isLeftHand = true;
            _selectHand.isRightHand = false;
        }
        else if (_rayInteractor.GetComponent<OVRHand.Hand>() == OVRHand.Hand.HandRight)
        {
            _selectHand.isRightHand = true;
            _selectHand.isLeftHand = false;
        }
    }*/
    
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
        if (_modelToMove == null || _isEditingMode) return;
        else if (_rayInteractor.CollisionInfo.HasValue)
        {
            _modelToMove.transform.position = _rayInteractor.CollisionInfo.Value.Point;
        }
    }
    public void GetRayCastHitPoint(RayInteractor rayInteractor)
    {
        //Spostare definitivamente il modello nel punto scelto 
        print("RAYCAST POINT: " + _rayInteractor.CollisionInfo.Value.Point);
        if (_modelToMove == null || _isEditingMode) return;
        else
        {
            _modelToMove.transform.position = rayInteractor.CollisionInfo.Value.Point;
            print("POSIZIONE DEL MODELLO: " + _modelToMove.transform.position);
            ResetMaterial();
            DeselectObject();
            //_selectHand.isLeftHand = false;
            //_modelToMove.transform.position = _rayInteractor.CollisionInfo.Value.Point;
        }
    }

    public void ResetMaterial()
    {
        _modelToMove.GetComponentInChildren<ModelPersonalization>().ChangeMaterialOnPositioning();
    }

    private void ActivateEditCanvas()
    {
        _menuManager.ActivateMenu(_editingMenu);
        _menuManager.DeactivateMenu(_modelMenu);
    }
}
