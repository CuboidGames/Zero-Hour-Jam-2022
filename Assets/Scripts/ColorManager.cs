using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour {
  public string currentColor = "white";

  [SerializeField]
  private Renderer rendererDelegate;

  [SerializeField]
  private Material whiteMaterial;

  [SerializeField]
  private Material blackMaterial;

  [SerializeField]
  private Material blueMaterial;

  public void ToggleColor() {
    if (currentColor == "white") {
      rendererDelegate.material = blueMaterial;
      currentColor = "blue";
    } else if (currentColor == "blue") {
      rendererDelegate.material = blackMaterial;
      currentColor = "black";
    } else {
      rendererDelegate.material = whiteMaterial;
      currentColor = "white";
    }
  }
}