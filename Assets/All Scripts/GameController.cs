using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public GameObject gameOverPanel;
    public GameObject tapToStart;
    public GameObject scoreText;

    private void Start() {
        gameOverPanel.SetActive(false);
        tapToStart.SetActive(true);
        scoreText.SetActive(false);
        PouseGame();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            StartGame();
        }
    }

    public void GameOver() {
        gameOverPanel.SetActive(true);
        scoreText.SetActive(false);
    }

    public void Restart() {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void PouseGame() {
        Time.timeScale = 0f;
    }

    public void StartGame() {
        scoreText.SetActive(true);
        tapToStart.SetActive(false);
        Time.timeScale = 1f;
    }
}
