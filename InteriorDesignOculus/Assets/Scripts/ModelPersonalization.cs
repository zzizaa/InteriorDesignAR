using System;
using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;
using UnityEngine.UI;

public class ModelPersonalization : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    [SerializeField] private Material _material;
    [SerializeField] private Material _selectedMaterial;
    [SerializeField] private List<Slider> _sliders;
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _basePoint;
    [SerializeField] private GameObject _rotationCanvas;
    private GameObject handRayInteractor;


    private void Start()
    {
        _player = GameObject.FindWithTag("Player");
        handRayInteractor = GameObject.FindWithTag("HandRayInteractor");
    }

    /*private void Update()
    {
        _rotationCanvas.transform.up = _player.transform.position - _basePoint.transform.position;
    }

    public void RotateModel(float rotationAngle)
    {
        gameObject.transform.RotateAround(gameObject.transform.position, gameObject.transform.up, rotationAngle);
    }*/

    public void SelectObject(GameObject parentGameObject)
    {
        print("Object to Spawn: " + parentGameObject.name);
        handRayInteractor.GetComponent<RayMovement>().SelectObject(parentGameObject);
    }
    public void ChangeColor()
    {
        _material.color = new Color(_sliders[0].value, _sliders[1].value, _sliders[2].value);
    }
    
    public void ChangeMaterialOnSelection()
    {
        gameObject.GetComponent<MeshRenderer>().material = _selectedMaterial;
        //When selected the model should change material and move with the raycast on the floor    
    }

    public void ChangeMaterialOnPositioning()
    {
        //Reselect the main material of the model
        gameObject.GetComponent<MeshRenderer>().material = _material;
    }
    public void ActivateCanvas()
    {
        _canvas.SetActive(true);
    }

    public void DisableCanvas()
    {
        _canvas.SetActive(false);
    }
}


