using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public float scores = 0f;

    public Text scorecount;

    public Player player;

    public GameObject playButton;

    public GameObject gameOver;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        Pause();
    }

    public void Play()
    {

        player.transform.position = new Vector3(0,0,0);
        scores = 0f;
        scorecount.text = scores.ToString();

        gameOver.SetActive(false);
        playButton.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore()
    {
        scores++;
        scorecount.text = scores.ToString();
        Debug.Log(scores);
    }
}
