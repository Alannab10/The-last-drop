using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPaneles : MonoBehaviour
{
    [SerializeField] GameObject panelInicio, panelFinalizado, panelPausa, panelAjustes, panelButton;

    private void Start()
    {
        GameController.Instancia.iniciadoEvento += MostrarButton;
        GameController.Instancia.reanudadoEvento += MostrarButton;
        GameController.Instancia.finalizadoEvento += MostrarFinalizado;
        GameController.Instancia.pausadoEvento += MostrarPausa;
        GameController.Instancia.ajustesEvento += MostrarAjustes;

        MostrarInicio();
    }

    public void MostrarPausa()
    {
        panelButton.SetActive(false);
        panelPausa.SetActive(true);
        panelInicio.SetActive(false);
        panelFinalizado.SetActive(false);
        panelAjustes.SetActive(false);
        
    }

    public void MostrarFinalizado()
    {
        panelButton.SetActive(false);
        panelPausa.SetActive(false);
        panelInicio.SetActive(false);
        panelFinalizado.SetActive(true);
        panelAjustes.SetActive(false);

    }

    public void MostrarInicio()
    {
        panelButton.SetActive(false);
        panelPausa.SetActive(false);
        panelInicio.SetActive(true);
        panelFinalizado.SetActive(false);
        panelAjustes.SetActive(false);

    }
    public void MostrarAjustes()
    {
        panelButton.SetActive(false);
        panelPausa.SetActive(false);
        panelInicio.SetActive(false);
        panelFinalizado.SetActive(false);
        panelAjustes.SetActive(true);

    }

    public void MostrarButton()
    {
        panelButton.SetActive(true);
        panelPausa.SetActive(false);
        panelInicio.SetActive(false);
        panelFinalizado.SetActive(false);
        panelAjustes.SetActive(false);
    }
}
