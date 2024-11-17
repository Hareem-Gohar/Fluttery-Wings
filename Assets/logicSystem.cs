using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicSystem : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject gameOverScreen;

    public void addScore(int scoreTotal)
    {
        playerScore = playerScore + scoreTotal;
        score.text = playerScore.ToString();
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
