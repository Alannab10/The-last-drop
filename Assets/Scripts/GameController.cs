using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public delegate void DelegatedGameEvents();
    [SerializeField] DelegatedGameEvents GameStartedFirstTimeEvent;
    [SerializeField] DelegatedGameEvents GamePausedEvent;
    [SerializeField] DelegatedGameEvents GameResumedEvent;
    [SerializeField] DelegatedGameEvents GameEndedEvent;
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
        SceneManager.LoadScene("Level 1");
        GameStartedFirstTimeEvent?.Invoke();
    }
    public void GameReload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
