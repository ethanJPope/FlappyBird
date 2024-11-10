using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    [SerializeField]
    private FloatSO scoreSO;
    public int playerScore = 0;
    public Text scoreText;
    public Text highScoreText;
    public GameObject GameOverScreen;

    public void addScore() {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        if(playerScore <= scoreSO.Value) {
            highScoreText.text = "High Score: " + scoreSO.Value.ToString();
        }
        else if(playerScore > scoreSO.Value) {
            scoreSO.Value = playerScore;
            highScoreText.text = "High Score: " + scoreSO.Value.ToString();
        }

        GameOverScreen.SetActive(true);
    }
}
