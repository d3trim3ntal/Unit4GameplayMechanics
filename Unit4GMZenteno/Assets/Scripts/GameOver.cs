using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y <= -10)
        {
            GameOverScene();
        }
    }

    public void GameOverScene()
    {
        gameOverScreen.SetActive(true);
    }

    public void RestartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
