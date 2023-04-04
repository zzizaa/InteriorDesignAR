using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private GameObject _cam;

    private void Start()
    {
        _cam = GameObject.FindWithTag("MainCamera");
    }

    private void LateUpdate()
    {
        transform.LookAt(transform.position + _cam.transform.rotation * Vector3.back, _cam.transform.rotation * Vector3.up);
    }
}
