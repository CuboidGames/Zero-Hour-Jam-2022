using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHandler : MonoBehaviour
{
  [SerializeField]
  bool randomizeState = true;

  [SerializeField]
  string state = "WhitePlatform";

  string[] colors = { "WhitePlatform", "BluePlatform", "BlackPlatform" };

  float lastHit = -100;

  void Start()
  {
    if (randomizeState)
    {
      RandomizePlatform();
    }

    ActivateCurrentPlatform();
  }

  private void RandomizePlatform()
  {
    state = colors[Random.Range(0, colors.Length)];
  }

  void ActivateCurrentPlatform()
  {
    for (var i = 0; i < transform.childCount; i++)
    {
      var platform = transform.GetChild(i);
      var active = platform.CompareTag(state);

      platform.gameObject.SetActive(active);
    }
  }

  public void ActivateNextPlatform()
  {
    if (lastHit + 0.3 > Time.time ) {
      return;
    }

    lastHit = Time.time;

    RandomizePlatform();
    ActivateCurrentPlatform();
  }
}
