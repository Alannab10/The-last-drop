using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPaneles : MonoBehaviour
{
    [SerializeField] GameObject panelInicio, panelFinalizado, panelPausa, panelAjustes;

    private void Start()
    {
        MostrarInicio();
    }

    private void OnEnable()
    {

        GameController.Instancia.finalizadoEvento += MostrarFinalizado;
        GameController.Instancia.pausadoEvento += MostrarPausa;
        GameController.Instancia.ajustesEvento += MostrarAjustes;
    }
    public void MostrarPausa()
    {
        panelPausa.SetActive(true);
        panelInicio.SetActive(false);
        panelFinalizado.SetActive(false);
        panelAjustes.SetActive(false);
    }

    public void MostrarFinalizado()
    {

        panelPausa.SetActive(false);
        panelInicio.SetActive(false);
        panelFinalizado.SetActive(true);
        panelAjustes.SetActive(false);
    }

    public void MostrarInicio()
    {
        panelPausa.SetActive(false);
        panelInicio.SetActive(true);
        panelFinalizado.SetActive(false);
        panelAjustes.SetActive(false);
    }
    public void MostrarAjustes()
    {
        panelPausa.SetActive(false);
        panelInicio.SetActive(true);
        panelFinalizado.SetActive(false);
        panelAjustes.SetActive(false);
    }
}
