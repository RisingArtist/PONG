using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameStates { NONE, PLAYING, PAUSED }
    public static GameManager gm;
    public GameStates currentGameState;
    public Ball ball;
    public Goal p1Goal;
    public Goal p2Goal;
    public UiManager uiManager;

    AudioSource soundSource;
    public List<AudioClip> sounds;

    [HideInInspector]
    int p1Score;
    [HideInInspector]
    int p2Score;

    public enum Player { ONE, TWO };
    static Player player;

    bool isPaused = false;

    // Singleton Architecture - One GameManager Object
    private void Awake()
    {
        if(gm != null)
        {
            Destroy(this);
        }
        else
        {
            gm = this;
            soundSource = GetComponent<AudioSource>();
            p1Goal.player = Player.ONE;
            p2Goal.player = Player.TWO;
            Reset();
            DontDestroyOnLoad(this);
        }
    }

    // Resets the game and begins match
    public void Reset()
    {
        p1Score = 0;
        p2Score = 0;
        ball.ResetBall();
        ChangeGameState(GameStates.PLAYING);
        uiManager.UpdateText(uiManager.playerOneScoreText, 0);
        uiManager.UpdateText(uiManager.playerTwoScoreText, 0);
        uiManager.ResetTimer();
        uiManager.StartCountdown();
        StartCoroutine(StartMatch());
    }

    // Play a sound effect ( SFX ) by its track name
    public void PlaySFX(Constants.SoundTracks trackName)
    {
        soundSource.clip = null;
        switch (trackName)
        {
            case Constants.SoundTracks.PaddleHit:
                soundSource.clip = sounds[(int)trackName];
                soundSource.pitch = Random.Range(1.0f, 1.1f);
                soundSource.Play();
                break;
            case Constants.SoundTracks.GoalGet:
                soundSource.clip = sounds[(int)trackName];
                soundSource.Play();
                break;
        }
    }

    // Add a point to the player who got the goal and start again
    public void AddPointTo(Player p)
    {
        switch (p)
        {
            case Player.ONE:
                p1Score++;
                uiManager.UpdateText(uiManager.playerOneScoreText, p1Score);
                Debug.Log(p1Score);
                break;
            case Player.TWO:
                p2Score++;
                uiManager.UpdateText(uiManager.playerTwoScoreText, p2Score);
                break;
        }
        uiManager.StartCountdown();
        StartCoroutine(StartMatch());
    }

    // Waits until the countdown finishes before launching the ball
    IEnumerator StartMatch()
    {
        yield return new WaitUntil(() => uiManager.finishCountdown);

        ball.PlayBall();
        uiManager.finishCountdown = false;
    }

    // Pause or Resume the Game
    public void TogglePause()
    {
        isPaused = !isPaused;
        if(isPaused) // ...pauses game
        {
            ChangeGameState(GameStates.PAUSED);
        }
        else // ...resumes game
        {
            ChangeGameState(GameStates.PLAYING);
        }
    }

    // Update the Game State and Display proper screen
    public void ChangeGameState(GameStates _state)
    {
        currentGameState = _state;

        switch (currentGameState)
        {
            case GameStates.PLAYING:
                DisplayGame();
                break;
            case GameStates.PAUSED:
                DisplayPause();
                break;
        }
    }

    // Display the pause menu ( more like restart game screen ) 
    public void DisplayPause()
    {
        Time.timeScale = 0;
        uiManager.DisplayPause();
    }

    // Display the Game panel 
    public void DisplayGame()
    {
        if (Time.timeScale == 0)
            Time.timeScale = 1;
        uiManager.DisplayGamePanel();
    }

    // Turn off the game
    public void QuitGame()
    {
        Application.Quit();
    }

}
