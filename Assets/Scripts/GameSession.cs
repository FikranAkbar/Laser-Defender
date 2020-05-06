using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{

    int score;

    private void Awake()
    {
        if(FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        } 
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddScore(int scoreInc)
    {
        score += scoreInc;
    }

    public int GetScore()
    {
        return score;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
