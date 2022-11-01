using System.Collections;
using System.Collections.Generic;
using CMF;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
  [SerializeField]
  Controller playerController;

  [SerializeField]
  TMPro.TextMeshProUGUI timeRemainingText;

  private float timeRemaining = 5;

  void Start() {
    playerController.OnJump += OnJump;
  }

  void Update() {
    timeRemaining = timeRemaining - Time.deltaTime;

    if (timeRemaining <= 0) {
      timeRemainingText.text = "Game over!";
      return;
    }

    timeRemainingText.text = ("" + timeRemaining).Substring(0, 4);
  }

  void OnJump(Vector3 v) {
    timeRemaining = 2;
  }
}