using System;
using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using Oculus.Interaction.Surfaces;
using UnityEngine;
using UnityEngine.UIElements;

public class RayMovement : MonoBehaviour
{
    [SerializeField] private GameObject _modelToMove;
    [SerializeField] private GameObject _floor;
    [SerializeField] private ColliderSurface _floorSurface;
    [SerializeField] private RayInteractor _rayInteractor;
    public RayInteractable _rayInteractableComponent;
    private bool _isEditingMode;
    private readonly float rotationLimit = 180f;
    [SerializeField] private MenuManager _menuManager;
    [SerializeField] private GameObject _editingMenu;
    [SerializeField] private GameObject _modelMenu;

    private void Start()
    {
       print("RAYMOVEMENTEXIST");
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
    public void GetRayCastHitPoint()
    {
        //Spostare definitivamente il modello nel punto scelto 
        //print("RAYCAST POINT: " + _rayInteractor.CollisionInfo.Value.Point);
        if (_modelToMove == null || _isEditingMode) return;
        else if (_rayInteractor.CollisionInfo.HasValue)
        {
            _modelToMove.transform.position = _rayInteractor.CollisionInfo.Value.Point;
            print("POSIZIONE DEL MODELLO: " + _modelToMove.transform.position);
            ResetMaterial();
            DeselectObject();
            //_selectHand.isLeftHand = false;
            //_modelToMove.transform.position = _rayInteractor.CollisionInfo.Value.Point;
        }
    }
    
    //Methods for Editing Mode
    public void RotateModel(float degree)
    {
        _modelToMove.transform.localEulerAngles = new Vector3(0, degree * rotationLimit, 0);
    }

    public void ScaleModel(float scaling)
    {
        float remappedValue = RemapValue(scaling, -1f, 1f, 0.8f, 1.2f);
        _modelToMove.transform.localScale = new Vector3(remappedValue, remappedValue, remappedValue);
    }

    public void TranslateModel()
    {
        
    }

    float RemapValue(float value, float inputMin, float inputMax, float outputMin, float outputMax)
    {
        float inputRange = inputMax - inputMin;
        float outputRange = outputMax - outputMin;
        float normalizedValue = (value - inputMin) / inputRange;
        float remappedValue = outputMin + (normalizedValue * outputRange);
        return remappedValue;
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
