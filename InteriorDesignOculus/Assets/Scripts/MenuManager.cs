using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private List<ModelScriptableObject> _models;
    [SerializeField] private Image _modelImage;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private SpawnModel _spawnModel;
    [SerializeField] private TMP_Dropdown _dropdownMaterials;
    public Material choosedMaterial;
    
    private int _modelValue;

    private void Update()
    {
        _dropdownMaterials.onValueChanged.AddListener(delegate { ChangeMaterial(_dropdownMaterials.value); });
        //_dropdownMaterials.onValueChanged(ChangeMaterial(_dropdownMaterials.value));
    }

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
    
    private void ChangeMaterial(int value)
    {
        _models[_modelValue].model.GetComponentInChildren<MeshRenderer>().material = _models[_modelValue].materials[value];
        choosedMaterial = _models[_modelValue].materials[value];
    }

    public void ChooseModelToSpawn()
    {
        _spawnModel.SelectModel(_modelValue);
    }

    public void ResetDropdownMaterials()
    {
        _dropdownMaterials.ClearOptions();
    }
}
