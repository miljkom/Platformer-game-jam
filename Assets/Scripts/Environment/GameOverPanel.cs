using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverPanel : MonoBehaviour
{
    public CanvasGroup panel;
    public Text time;
    public Button restartButton;
    public CountdownTimer countdownTimer;
    private void Start()
    {
        restartButton.onClick.AddListener(Restart);
        panel.alpha = 0;
        panel.interactable = false;
    }
    public void Show()
    {
        panel.alpha = 1;
        panel.interactable = true;
        Time.timeScale = 0;
        time.text = $"Your time was:{countdownTimer.currentTime:N2}";
        
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
