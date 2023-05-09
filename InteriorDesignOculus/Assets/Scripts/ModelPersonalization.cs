using System; 
using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;
using UnityEngine.UI;
public class ModelPersonalization : MonoBehaviour
{
    //[SerializeField] private GameObject _canvas;
     public Material material;
    [SerializeField] private Material _selectedMaterial;
    [SerializeField] private List<Slider> _sliders;
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _basePoint;
    //[SerializeField] private GameObject _rotationCanvas;
    private GameObject handRayInteractor;
    private GameObject _menuManager;


    private void Start()
    {
        _player = GameObject.FindWithTag("Player");
        handRayInteractor = GameObject.FindWithTag("HandRayInteractor");
        _menuManager = GameObject.FindWithTag("MenuManager");
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
        material.color = new Color(_sliders[0].value, _sliders[1].value, _sliders[2].value);
    }

    public void ChangeMaterial()
    {
        //Cambiare il materiale del modello dall'interfaccio, modificare i riferimenti ai materiali e accedere
        //agli ScriptableObject dei Modelli
    }
    public void ChangeMaterialOnSelection()
    {
        gameObject.GetComponent<MeshRenderer>().material = _selectedMaterial;
        //When selected the model should change material
        //Get all childrens with a Mesh Renderer and change all the materials    
        MeshRenderer[] rs = GetComponentsInChildren<MeshRenderer>();
        foreach(MeshRenderer r in rs)
            r.material = _selectedMaterial;
    }

    public void ChangeMaterialOnPositioning()
    {
        //ERRORE: quando si seleziona un altra sedia riposizionandala prenderà il materiale dell'ultima sedia fatta spawnare
        //SOLUZIONE: quando un modella viene selezionato estrarne i materiali e poi riapplicarli
        //Reselect the main material of the model
        gameObject.GetComponent<MeshRenderer>().material = _menuManager.GetComponent<MenuManager>().choosedMaterial;
        //Reset all the materials for all childrens
        MeshRenderer[] rs = GetComponentsInChildren<MeshRenderer>();
        foreach(MeshRenderer r in rs)
            r.material = _menuManager.GetComponent<MenuManager>().choosedMaterial;
    }

    public void DisableRayInteractableScript()
    {
        handRayInteractor.GetComponent<RayMovement>()._rayInteractableComponent =
            gameObject.GetComponent<RayInteractable>();
        gameObject.GetComponent<RayInteractable>().enabled = false;
       
    }
    
    /*
    public void ActivateCanvas()
    {
        _canvas.SetActive(true);
    }

    public void DisableCanvas()
    {
        _canvas.SetActive(false);
    }
    */
}


