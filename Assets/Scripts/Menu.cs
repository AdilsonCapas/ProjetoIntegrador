using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{    public void Começar()
    {
        SceneManager.LoadScene("Escolhas");
    }
    
    public void Casa()
    {
        SceneManager.LoadScene("Casa");
    }
    
    public void Cargos()
    {
        SceneManager.LoadScene("Cargos");
    }

    public void Escritorio()
    {
        SceneManager.LoadScene("Escritorio");
    }

    public void Config()
    {
        SceneManager.LoadScene("Config");
    }

    public void Trabalho()
    {
        SceneManager.LoadScene("Trabalho");
    }

    public void Tenis()
    {
        SceneManager.LoadScene("Tenis");
    }

    public void Imobiliaria()
    {
        SceneManager.LoadScene("Imobiliaria");
    }

    public void CasaImo()
    {
        SceneManager.LoadScene("CasaImo");
    }
    public void Apart()
    {
        SceneManager.LoadScene("Apartamento");
    }

    public void Educação()
    {
        SceneManager.LoadScene("Educação");
    }

    public void Financeiro()
    {
        SceneManager.LoadScene("Financeiro");
    }

    public void Concessionária()
    {
        SceneManager.LoadScene("Concessionária");
    }

    public void Hospital()
    {
        SceneManager.LoadScene("Hospital");
    }

    public void Mercado()
    {
        SceneManager.LoadScene("Mercado");
    }

    public void Receita()
    {
        SceneManager.LoadScene("Receita");
    }
}