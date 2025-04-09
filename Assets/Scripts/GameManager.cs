using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPaneles : MonoBehaviour
{
    [SerializeField] GameObject panelInicio, panelFinalizado, panelPausa, panelHud;

    private void Start()
    {
        MostrarInicio();
    }
    public void MostrarPausa()
    {
        panelPausa.SetActive(true);
        panelInicio.SetActive(false);
        panelFinalizado.SetActive(false);
        panelHud.SetActive(false);
    }

    public void MostrarHud()
    {
        panelPausa.SetActive(false);
        panelInicio.SetActive(false);
        panelFinalizado.SetActive(false);
        panelHud.SetActive(true);
    }

    public void MostrarFinalizado()
    {

        panelPausa.SetActive(false);
        panelInicio.SetActive(false);
        panelFinalizado.SetActive(true);
        panelHud.SetActive(false);
    }

    public void MostrarInicio()
    {
        panelPausa.SetActive(false);
        panelInicio.SetActive(true);
        panelFinalizado.SetActive(false);
        panelHud.SetActive(false);
    }
}
