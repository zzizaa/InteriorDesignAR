using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private List<ModelScriptableObject> _models;
    [SerializeField] private Image _modelImage;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private SpawnModel _spawnModel;
    [SerializeField] private TMP_Dropdown _dropdownMaterials;
    
    private int _modelValue;
    public void ActivateMenu(GameObject menu)
    {
        menu.SetActive(true);
    }

    public void DeactivateMenu(GameObject menu)
    {
        menu.SetActive(false);
    }

    public void SetupModel(int value)
    {
        _modelValue = value;
        _modelImage.sprite = _models[value].image;
        _name.text = _models[value].modelName;
        _dropdownMaterials.AddOptions(_models[value].materialsName);
    }

    public void ChangeMaterial()
    {
        
    }

    public void ChooseModelToSpawn()
    {
        _spawnModel.SelectModel(_modelValue);
    }
}
