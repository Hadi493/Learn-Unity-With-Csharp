using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;

    int myScore = 0;

    // Update is called once per frame
    void Update() {
        scoreText.text = myScore.ToString();
    }

    public void AddScore(int score) {
        myScore = myScore + score;
    }
}
