using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActivation : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    private void OnTriggerEnter(Collider other)
    {
        _canvas.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        _canvas.SetActive(false);
    }
}
