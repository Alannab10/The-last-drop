using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPaneles : MonoBehaviour
{
    [SerializeField] GameObject panelInicio, panelFinalizado, panelPausa;

    private void Start()
    {
        MostrarInicio();
    }

    public void MostrarPausa()
    {
        panelPausa.SetActive(true);
        panelInicio.SetActive(false);
        panelFinalizado.SetActive(false);
        
    }

    public void MostrarFinalizado()
    {

        panelPausa.SetActive(false);
        panelInicio.SetActive(false);
        panelFinalizado.SetActive(true);
        
    }

    public void MostrarInicio()
    {
        panelPausa.SetActive(false);
        panelInicio.SetActive(true);
        panelFinalizado.SetActive(false);
        
    }
}
