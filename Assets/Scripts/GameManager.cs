using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    public int CurrentScore = 0;
    public float TimeLeft = 0.0f;
    public bool IsAbleToStart = false;
    public bool JustFinished = false;
    public int CoinToShowNext = 0;
    
    void Start()
    {
        instance = this;
    }

    public void Reset()
    {
        CurrentScore = 0;
        TimeLeft = 0.0f;
        IsAbleToStart = false;
        JustFinished = false;
        CoinToShowNext = 0;
    }

    public void NextCoin()
    {
        CoinToShowNext++;
    }

    public void SetIsAbleToStart(bool CanStart)
    {
        IsAbleToStart = CanStart;
    }

    public void Finish()
    {
        JustFinished = true;
    }

    public void AddPoints(int Points)
    {
        CurrentScore += Points;
    }

    public void ChangeTime(float TimeChange)
    {
        TimeLeft += TimeChange;
    }
}
