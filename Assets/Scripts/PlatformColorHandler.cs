using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColorHandler : MonoBehaviour
{
  PlatformHandler platformHandler;

  void Start()
  {
    platformHandler = transform.parent.parent.GetComponent<PlatformHandler>();
  }

  void OnTriggerExit(Collider collider) {
    platformHandler.ActivateNextPlatform();
  }
}
