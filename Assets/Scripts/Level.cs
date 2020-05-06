using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;
    GameSession gameSession;

    private void Awake()
    {
        gameSession = FindObjectOfType<GameSession>();
    }

    public void LoadStartMenu()
    {
        gameSession.ResetGame();
        SceneManager.LoadScene(0);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }


    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Game Over");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
