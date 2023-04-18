using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/NewModel", order = 1)]
public class ModelScriptableObject : ScriptableObject
{
    public string modelName;
    public GameObject model;
    public Sprite image;
    public Mesh modelMesh;
    public List<Material> materials;
    public List<string> materialsName;
    public Material interactingMaterial;
}
