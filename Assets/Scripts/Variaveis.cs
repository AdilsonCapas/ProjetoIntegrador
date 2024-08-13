using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Variaveis : MonoBehaviour
{
   public TMP_Text diaText;
    public TMP_Text mesText;
    public TMP_Text anoText;
    public TMP_Text moneyText;

    private static bool isGameInitialized = false;

    void Start()
    {
        if (!isGameInitialized)
        {
            // Resetar os PlayerPrefs ao iniciar o jogo no editor pela primeira vez
            ResetPlayerPrefs();
            isGameInitialized = true; // Marcar como inicializado
        }

        CarregarDados(); // Carregar dados ao iniciar a cena
        AtualizarTextos(); // Atualizar os textos na interface com os dados carregados
    }

    void CarregarDados()
    {
        // Carregar os dados salvos dos PlayerPrefs
        int dias = PlayerPrefs.GetInt("Dias", 1);
        int meses = PlayerPrefs.GetInt("Meses", 1);
        int anos = PlayerPrefs.GetInt("Anos", 2024);
        int money = PlayerPrefs.GetInt("Money", 0);

        // Atualizar os textos na interface com os dados carregados
        diaText.text = dias.ToString("D2"); // Formatando para sempre ter dois dígitos
        mesText.text = meses.ToString("D2"); // Formatando para sempre ter dois dígitos
        anoText.text = anos.ToString();
        moneyText.text = "Dinheiro: " + money.ToString();
    }

    void AtualizarTextos()
    {
        // Atualizar os textos na interface com os dados carregados
        int dias = PlayerPrefs.GetInt("Dias", 1);
        int meses = PlayerPrefs.GetInt("Meses", 1);
        int anos = PlayerPrefs.GetInt("Anos", 2024);
        int money = PlayerPrefs.GetInt("Money", 0);

        diaText.text = dias.ToString("D2"); // Formatando para sempre ter dois dígitos
        mesText.text = meses.ToString("D2"); // Formatando para sempre ter dois dígitos
        anoText.text = anos.ToString();
        moneyText.text = "Dinheiro: " + money.ToString();
    }

    void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteKey("Money");
        PlayerPrefs.DeleteKey("Dias");
        PlayerPrefs.DeleteKey("Meses");
        PlayerPrefs.DeleteKey("Anos");
        PlayerPrefs.Save();
    }

    public void AumentarDinheiro(int amount)
    {
        int money = PlayerPrefs.GetInt("Money", 0);
        money += amount;
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        AtualizarTextos(); // Atualizar os textos para refletir o novo valor
    }

    // Método para ser chamado pelo botão
    public void AumentarDinheiroBotao()
    {
        AumentarDinheiro(5000);
    }

    public void DiminuirDinheiro(int amount)
    {
        int money = PlayerPrefs.GetInt("Money", 0);
        money += amount;
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        AtualizarTextos(); // Atualizar os textos para refletir o novo valor
    }

    // Método para ser chamado pelo botão
    public void DiminuirDinheiroBotao()
    {
        DiminuirDinheiro(-3300);
    }
}
