using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class VariaveisDois : MonoBehaviour
{

    public int money = 0;
    public int dias = 1;
    public int meses = 1;
    public int anos = 2024;
    public TMP_Text moneyText;
    public TMP_Text dia;
    public TMP_Text mes;
    public TMP_Text ano;

    private static bool isGameInitialized = false;

    void Start()
    {
        // Checar se é a primeira vez que o jogo está sendo iniciado no editor
        if (!isGameInitialized)
        {
            // Resetar os PlayerPrefs ao iniciar o jogo no editor pela primeira vez
            ResetPlayerPrefs();
            isGameInitialized = true; // Marcar como inicializado
        }

        // Carregar os dados do PlayerPrefs
        CarregarDados();

        // Atualizar os textos na interface
        UpdateMoneyText();
        UpdateDia();
        UpdateMes();
        UpdateAno();
    }

    void UpdateMoneyText()
    {
        moneyText.text = "Dinheiro: " + money.ToString();
    }

    void UpdateDia()
    {
        dia.text = dias.ToString("D2"); // Formatando para sempre ter dois dígitos
    }

    void UpdateMes()
    {
        mes.text = meses.ToString("D2"); // Formatando para sempre ter dois dígitos
    }

    void UpdateAno()
    {
        ano.text = anos.ToString();
    }

    public void AumentarDia()
    {
        if (dias >= 1 && dias <= 30)
        {
            dias++;
        }
        if (dias == 31 && meses <= 11)
        {
            dias = 1;
            meses++;
        }
        else if (dias == 31 && meses == 12)
        {
            dias = 1;
            meses = 1;
            anos++;
        }
        UpdateDia();
        UpdateMes();
        UpdateAno();

        // Salvar os dados após modificar
        SalvarDados();
    }

    void AumentarCascalho()
    {
        money = money + 5000;

        UpdateMoneyText();
        SalvarDados();     
    }

    void SalvarDados()
    {
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.SetInt("Dias", dias);
        PlayerPrefs.SetInt("Meses", meses);
        PlayerPrefs.SetInt("Anos", anos);
        PlayerPrefs.Save();
    }

    void CarregarDados()
    {
        money = PlayerPrefs.GetInt("Money", 0);
        dias = PlayerPrefs.GetInt("Dias", 1);
        meses = PlayerPrefs.GetInt("Meses", 1);
        anos = PlayerPrefs.GetInt("Anos", 2024);
    }

    void ResetPlayerPrefs()
    {
        // Limpar os valores de PlayerPrefs
        PlayerPrefs.DeleteKey("Money");
        PlayerPrefs.DeleteKey("Dias");
        PlayerPrefs.DeleteKey("Meses");
        PlayerPrefs.DeleteKey("Anos");
        PlayerPrefs.Save();

        // Definir os valores iniciais (opcional)
        money = 0;
        dias = 1;
        meses = 1;
        anos = 2024;
    }
}
