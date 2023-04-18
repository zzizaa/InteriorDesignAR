using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private List<ModelScriptableObject> _models;
    [SerializeField] private Image _modelImage;
    public void ActivateMenu(GameObject menu)
    {
        menu.SetActive(true);
    }

    public void DeactivateMenu(GameObject menu)
    {
        menu.SetActive(false);
    }

    public void SetModelImage(int i)
    {
        _modelImage.sprite = _models[i].image;
    }
}
