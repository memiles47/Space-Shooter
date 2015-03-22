using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    // Game Control Variables
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public GameObject hazard;
    public Vector3 spawnValues;

    // GUI Variables
    public GameObject refScoreText;
    public GameObject refRestartText;
    public GameObject refGameOverText;

    // Declaration of Private variables
    private bool gameOver;
    private bool restart;
    private int score;
    private Text scoreText;
    private Text restartText;
    private Text gameOverText;


    // Start is called just before any of the Update methods is called the first time (Since v1.0)
    public void Start()
    {
        gameOver = false;
        restart = false;
        score = 0;
        restartText = refRestartText.GetComponent<Text>();
        gameOverText = refGameOverText.GetComponent<Text>();
        scoreText = refScoreText.GetComponent<Text>();
        restartText.text = "";
        gameOverText.text = "";
        UpdateScore();
        StartCoroutine (SpawnWaves());
    }

    public void Update()
    {
        if(restart)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel (Application.loadedLevel);
            }
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while(true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                // Declaration of function variables
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;

                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);

                if (gameOver)
                {
                    restartText.text = "Prss 'R' for Restart";
                    restart = true;
                    break;
                }
            }
            yield return new WaitForSeconds(waveWait);
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    
    void UpdateScore()
    {
        scoreText.text = "Score: " + score;

    }

    public void GameOver()
    {
        gameOverText.text = "Game Over";
        gameOver = true;
    }
}