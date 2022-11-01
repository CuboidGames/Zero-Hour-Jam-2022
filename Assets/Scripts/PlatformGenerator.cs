using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject platformPrefab;

    [SerializeField]
    int rings = 4;

    [SerializeField]
    float platformSize = 1;

    void Start()
    {
        for (var i = 1; i < rings + 1; i++) {
          var ringLength = 2 * Mathf.PI * platformSize * i;
          var platforms = Mathf.Floor(ringLength / platformSize);

          for (int j = 0; j < platforms; j++) {
            var offset = (j / platforms) * 2 * Mathf.PI;
            var position = new Vector3(Mathf.Sin(offset), 0, Mathf.Cos(offset)) * i * platformSize;

            Instantiate(platformPrefab, position, Quaternion.identity, transform);
          }
        }
    }
}
