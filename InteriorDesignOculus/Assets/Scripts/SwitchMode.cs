using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMode : MonoBehaviour
{
   public bool editingMode;
   [SerializeField] private GameObject _leftHand;
   [SerializeField] private GameObject _rightHand;
   [SerializeField] private Material _editMaterial;
   [SerializeField] private Material _baseMaterial;

   [SerializeField] private MenuManager _menuManager;
   [SerializeField] private GameObject _editMenu;
   [SerializeField] private GameObject _modelMenu;
   
   public void ChangeMode()
   {
      editingMode = !editingMode;
      ChangeMaterial();
   }

   private void ChangeMaterial()
   {
      if (editingMode)
      {
         _leftHand.GetComponent<SkinnedMeshRenderer>().material = new Material(_editMaterial);
         _rightHand.GetComponent<SkinnedMeshRenderer>().material = new Material(_editMaterial);
      }
      else
      {
         _leftHand.GetComponent<SkinnedMeshRenderer>().material = new Material(_baseMaterial);
         _rightHand.GetComponent<SkinnedMeshRenderer>().material = new Material(_baseMaterial);
         ResetMenu();
      }
   }

   private void ResetMenu()
   {
      _menuManager.ActivateMenu(_modelMenu);
      _menuManager.DeactivateMenu(_editMenu);
   }
}
