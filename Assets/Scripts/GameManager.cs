using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private float startDelay = 1f;
    private float repeatRate = 4f;
    public GameObject obstacle;
    private float randomPosition = 2f;
    private float spawnPosition = 10f;

    public GameObject gameOverPrompt;

    public GameObject restartButton;
    // Start is called before the first frame update
    void Start()
    {
        // Time delay for repeating the obstacles
        InvokeRepeating("Spawn", startDelay, repeatRate);
    }


    // Instantiating gameObjects at the provided spawnPosition of X-axis and random position of Y-axis
    void Spawn()
    {
        GameObject obstacles = Instantiate(obstacle, new Vector3(spawnPosition, Random.Range(-randomPosition, randomPosition), 0), Quaternion.identity) as GameObject;
    }

    // Updating score everytime the user passes an obstacle
    public void UpdateScore()
    {
        score += 1;
        scoreText.text = "" + score + "";
    }

    public void ShowGameOver()
    {
        gameOverPrompt.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
