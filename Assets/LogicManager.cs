using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverPanel;
    public GameObject gameWonPanel;
    public GameObject winImage;  // Reference to the UI Image to display
    public GameObject winAudio;  // Reference to the Audio Source to play
    public GameObject winEffects;  // Reference to the Particle System for effects
    [ContextMenu("AddScore")]
    public void AddScore(int scoreToAdd=1)
    {
        score+=scoreToAdd;
        scoreText.text = score.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void GameWon()
    {
        gameWonPanel.SetActive(true);
    }
}
