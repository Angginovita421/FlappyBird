using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("UI")]
    public GameObject playButton;
    public GameObject gameOverPanel;
    public TextMeshProUGUI scoreText;

    private int score = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        Time.timeScale = 0;
        gameOverPanel.SetActive(false);
    }

   public PipeSpawner pipeSpawner;

   public void StartGame()
   {
    Time.timeScale = 1;
    playButton.SetActive(false);
    pipeSpawner.StartSpawn();
   }


    public void AddScore()
    {
    score++;
    scoreText.text = score.ToString();
    }


    public void GameOver()
    {
        Debug.Log("GAME OVER TERPANGGIL");
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
