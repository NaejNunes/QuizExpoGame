﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioControlador : MonoBehaviour
{
    public GameObject PainelInicio, PainelRA, PainelPremio;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IniciarQuiz()
    {
        SceneManager.LoadScene("Quiz");
    }

    public void VoltaMenu()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void AbrirPainelRA()
    {
        PainelInicio.SetActive(false);
        PainelRA.SetActive(true);
    }

    public void FecharPainelRA()
    {
        PainelRA.SetActive(false);
        PainelInicio.SetActive(true);

    }

    public void IniciarRecebaPremio()
    {
        PainelInicio.SetActive(false);
        PainelPremio.SetActive(true);
    }

     public void FecharRecebaPremio()
    {
        PainelPremio.SetActive(false);
        PainelInicio.SetActive(true);
    }

    public void IniciarHome()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void Atari()
    {
        SceneManager.LoadScene("Atari");
    }

    public void GameBoy()
    {
        SceneManager.LoadScene("GameBoyColor");
    }

    public void MegaDriver()
    {
        SceneManager.LoadScene("MegaDriver");
    }

    public void Nintendo()
    {
        SceneManager.LoadScene("Nintendo");
    }
}
