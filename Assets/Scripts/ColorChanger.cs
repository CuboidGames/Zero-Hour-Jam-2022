using System.Collections;
using System.Collections.Generic;
using CMF;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    Controller controller;

    ColorManager colorManager;

    // Start is called before the first frame update
    void Start()
    {
      colorManager = GetComponentInParent<ColorManager>();
      controller = GetComponentInParent<Controller>();       

      controller.OnJump += OnJump;
    }

    void OnJump(Vector3 v) {
      colorManager.ToggleColor();
    }

}
