using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Certifique-se de adicionar isso para trabalhar com UI

public class Menu : MonoBehaviour
{
    public Button trabalhoButton; // Referência ao botão de trabalho

    void Start()
    {
        AtualizarEstadoBotaoTrabalho();
    }

    public void Começar()
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
    
    public void Corrida()
    {
        SceneManager.LoadScene("Corrida");
    }

    public void Economicos()
    {
        SceneManager.LoadScene("Economicos");
    }

    void AtualizarEstadoBotaoTrabalho()
    {
        int ultimoMes = PlayerPrefs.GetInt("UltimoMesTrabalho", -1);
        int ultimoAno = PlayerPrefs.GetInt("UltimoAnoTrabalho", -1);
        int mesAtual = DateTime.Now.Month;
        int anoAtual = DateTime.Now.Year;

        if (ultimoMes != mesAtual || ultimoAno != anoAtual)
        {
            // Liberar botão de trabalho
            trabalhoButton.interactable = true;
            PlayerPrefs.SetInt("UltimoMesTrabalho", mesAtual);
            PlayerPrefs.SetInt("UltimoAnoTrabalho", anoAtual);
        }
        else
        {
            // Bloquear botão de trabalho
            trabalhoButton.interactable = false;
        }

        PlayerPrefs.Save();
    }
}
