using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelPersonalization : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    [SerializeField] private Material _material;
    [SerializeField] private List<Slider> _sliders;

    public void ChangeColor()
    {
        _material.color = new Color(_sliders[0].value, _sliders[1].value, _sliders[2].value);
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


