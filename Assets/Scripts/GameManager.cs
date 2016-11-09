using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    public int CurrentScore = 0;
    public float TimeLeft = 0.0f;
    public bool IsAbleToStart = false;
    public bool JustFinished = false;
    public int CoinToShowNext = 0;
    public AudioClip[] SongList;
    public AudioClip VictoryClip;

    private AudioSource backgroundMusic;
    
    void Start()
    {
        instance = this;
        backgroundMusic = gameObject.AddComponent<AudioSource>();
    }

    public void StartDash()
    {
        var songIndex = Random.Range(0, SongList.Length);
        backgroundMusic.clip = SongList[songIndex];
        backgroundMusic.Play();
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
        backgroundMusic.Stop();
        JustFinished = true;
        backgroundMusic.PlayOneShot(VictoryClip);
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
