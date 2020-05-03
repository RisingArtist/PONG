using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject gamePanel;
    public GameObject pausePanel;
    public Text playerOneScoreText;
    public Text playerTwoScoreText;
    public Text countdownText;

    float countdown = Constants.RESET_COUNTDOWN;

    bool startCountdown = false;
    [HideInInspector]
    public bool finishCountdown = false;

    private void Start()
    {
        TogglePanel(pausePanel, false);
        playerOneScoreText.text = "0";
        playerTwoScoreText.text = "0";
    }

    // Switch panel's activity 
    void TogglePanel(GameObject _panel, bool _active)
    {
        _panel.SetActive(_active);
    }

    // Pre-Countdown logic
    public void StartCountdown()
    {
        startCountdown = true;
        finishCountdown = false;
        countdownText.enabled = true;
    }

    // Countdown the timer
    public void Countdown()
    {
        UpdateText(countdownText, (int)(countdown + 1));
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            FinishCountdown();
        }
    }

    // Post-Countdown logic
    public void FinishCountdown()
    {
        startCountdown = false;
        finishCountdown = true;
        countdownText.enabled = false;
        ResetTimer();
    }

    // Reset the timer back for next time
    public void ResetTimer()
    {
        countdown = Constants.RESET_COUNTDOWN;
    }

    public void Update()
    {
        if (!startCountdown)
            return;

        Countdown();
    }

    // Update the target text to value; Used for points & countdown
    public void UpdateText(Text _text, int _value)
    {
        _text.text = _value.ToString();
    }

    // Show the Game Panel 
    public void DisplayGamePanel()
    {
        TogglePanel(pausePanel, false);
        TogglePanel(gamePanel, true);
    }

    // Show the Pause Panel
    public void DisplayPause()
    {
        TogglePanel(pausePanel, true);
        TogglePanel(gamePanel, false);
    }
}
