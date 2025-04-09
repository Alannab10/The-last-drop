using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instancia;
    public ScoreController score;
        
    public delegate void EventosGameDelegado();
    public EventosGameDelegado iniciadoEvento;
    public EventosGameDelegado finalizadoEvento;
    public EventosGameDelegado pausadoEvento;
    public EventosGameDelegado reanudadoEvento;
    public EventosGameDelegado ajustesEvento;

    public void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Time.timeScale = 0f;
    }

    public void IniciarJuego()
    {
        Time.timeScale = 1f;
        iniciadoEvento?.Invoke();
    }

    public void FinalizarJuego()
    {
        Time.timeScale = 0f;
        finalizadoEvento?.Invoke();
    }

    public void PausarJuego()
    {
        Time.timeScale = 0f;
        pausadoEvento?.Invoke();
    }

    public void ReanudarJuego()
    {
        Time.timeScale = 1f;
        reanudadoEvento?.Invoke();
    }

    public void AjustesJuego()
    {
        Time.timeScale = 0f;
        pausadoEvento?.Invoke();
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

