using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetection : MonoBehaviour
{
  [SerializeField]
  TMPro.TextMeshProUGUI highScoreText;

  [SerializeField]
  TMPro.TextMeshProUGUI scoreText;

    private ColorManager colorManager;

    int score = 0;

    int highScore = 0;

    float lastHit = 0;

    public string currentColor { get { return colorManager.currentColor; } }

    void Start() {
      colorManager = GetComponent<ColorManager>();

      highScore = PlayerPrefs.GetInt("HighScore", 0);
      highScoreText.text = "" + highScore;
    }

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider) {
      if (collider.gameObject.CompareTag("WhitePlatform")) {
        CheckCollision("white");
      } else if (collider.gameObject.CompareTag("BlackPlatform")) {
        CheckCollision("black");
      } else if (collider.gameObject.CompareTag("BluePlatform")) {
        CheckCollision("blue");
      } else {
        score = 0;
        scoreText.text = "0";
      }
    }

    void CheckCollision(string color) {
      if (lastHit + 0.1 > Time.time ) {
        return;
      }

      lastHit = Time.time;

      if (currentColor == color) {
        score++;
        scoreText.text = "" + score;

        if (score > highScore) {
          highScore = score;
          highScoreText.text = "" + score;

          PlayerPrefs.SetInt("HighScore", highScore);
        }
      } else {
        score = 0;
        scoreText.text = "0";
      }
    }
}
