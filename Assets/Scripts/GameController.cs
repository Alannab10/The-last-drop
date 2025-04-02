using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public delegate void DelegatedGameEvents();
    public DelegatedGameEvents GameStartedFirstTimeEvent;
    public DelegatedGameEvents GameStartedEvent;
    public DelegatedGameEvents GamePausedEvent;
    public DelegatedGameEvents GameResumedEvent;
    public DelegatedGameEvents GameEndedEvent;
     void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        Time.timeScale = 0f;
    }
    public void GameStartedFirst()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        GameStartedFirstTimeEvent?.Invoke();
    }
    public void GameStarted()
    {
        Time.timeScale = 1f;
        GameStartedEvent?.Invoke();
    }
    public void GamePaused()
    {
        Time.timeScale = 0f;
        GamePausedEvent?.Invoke();
    }
    public void GameResumed()
    {
        Time.timeScale = 1f;
        GameResumedEvent?.Invoke();
    }
    public void GameEnded()
    {
        Time.timeScale = 0f;
        GameEndedEvent?.Invoke();
    }
    public void GameQuit()
    {
        Application.Quit(); 
    }
}
