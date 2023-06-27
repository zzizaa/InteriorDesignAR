using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;

public class FloorSetup : MonoBehaviour
{
    [SerializeField] private InteractableUnityEventWrapper _eventWrapper;
    [SerializeField] private RayMovement _rayMovement;
    public void SetupFloor(GameObject floor, RayInteractable rayInteractable)
    {
        gameObject.transform.SetParent(floor.transform.parent);
        _eventWrapper.InjectInteractableView(rayInteractable);
        _eventWrapper.WhenSelect.AddListener(_rayMovement.EnableRayInteractableScript);
        //_eventWrapper.WhenSelect.AddListener((() => _rayMovement.EnableRayInteractableScript()));
        _eventWrapper.WhenSelect.AddListener(_rayMovement.GetComponent<RayMovement>().GetRayCastHitPoint);
    }
}
