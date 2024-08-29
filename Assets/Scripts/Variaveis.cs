using System;
using UnityEngine;
using TMPro;

public class Variaveis : MonoBehaviour
{
    public TMP_Text diaText;
    public TMP_Text mesText;
    public TMP_Text anoText;
    public TMP_Text moneyText;
    public int salario = 0;
    public int uno = 1;
    public int ka =1;
    public int gol =1;
    public int argo =1;
    public int Bmw =1;
    public int Mercedes =1;
    public int Audi =1;
    public int Jaguar;
    
    private static bool isGameInitialized = false;
    
    void Start()
    {
        if (!isGameInitialized)
        {
            ResetPlayerPrefs();
            isGameInitialized = true;
        }
        
        CarregarDados();
        AtualizarTextos();
        
        VerificarLiberacaoSalario();
    }

    void CarregarDados()
    {
        int dias = PlayerPrefs.GetInt("Dias", 1);
        int meses = PlayerPrefs.GetInt("Meses", 1);
        int anos = PlayerPrefs.GetInt("Anos", 2024);
        int money = PlayerPrefs.GetInt("Money", 0);
        salario = PlayerPrefs.GetInt("Salario", 0);

        diaText.text = dias.ToString("D2");
        mesText.text = meses.ToString("D2");
        anoText.text = anos.ToString();
        moneyText.text = "Dinheiro: " + money.ToString();
    }

    void AtualizarTextos()
    {
        int dias = PlayerPrefs.GetInt("Dias", 1);
        int meses = PlayerPrefs.GetInt("Meses", 1);
        int anos = PlayerPrefs.GetInt("Anos", 2024);
        int money = PlayerPrefs.GetInt("Money", 0);

        diaText.text = dias.ToString("D2");
        mesText.text = meses.ToString("D2");
        anoText.text = anos.ToString();
        moneyText.text = "Dinheiro: " + money.ToString();
    }

    void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteKey("Money");
        PlayerPrefs.DeleteKey("Dias");
        PlayerPrefs.DeleteKey("Meses");
        PlayerPrefs.DeleteKey("Anos");
        PlayerPrefs.DeleteKey("Salario");
        PlayerPrefs.DeleteKey("UltimoMes");
        PlayerPrefs.DeleteKey("UltimoAno");
        PlayerPrefs.Save();
    }

    void VerificarLiberacaoSalario()
    {
        int ultimoMes = PlayerPrefs.GetInt("UltimoMes", -1);
        int ultimoAno = PlayerPrefs.GetInt("UltimoAno", -1);
        int mesAtual = DateTime.Now.Month;
        int anoAtual = DateTime.Now.Year;

        if (ultimoMes != mesAtual || ultimoAno != anoAtual)
        {
            // Liberar salário
            salario = 1;
            PlayerPrefs.SetInt("Salario", salario);
            PlayerPrefs.SetInt("UltimoMes", mesAtual);
            PlayerPrefs.SetInt("UltimoAno", anoAtual);
            PlayerPrefs.Save();
        }
    }

    public void AumentarDinheiro(int amount)
    {
        if (salario == 1)
        {
            int money = PlayerPrefs.GetInt("Money", 0);
            money += amount;
            salario = 0;
            PlayerPrefs.SetInt("Salario", salario);
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.Save();
            AtualizarTextos();
        }
    }

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
    }

    public void DiminuirDinheiroBotao()
    {
        DiminuirDinheiro(-3300);
    }

    public void Uno(int amount)
    {
        int money = PlayerPrefs.GetInt("Money", 0);
        if(money >= 10000 && uno <= 1)
        {
        money += amount;
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        AtualizarTextos();
        }
    }

    public void UnoB()
    {
        Uno(-10000);
        uno ++;
    }

    public void Gol(int amount)
    {
        int money = PlayerPrefs.GetInt("Money", 0);
        if(money >= 15000 && gol <= 1)
        {
        money += amount;
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        AtualizarTextos();
        }
    }

    public void GolB()
    {
        Gol(-15000);
        gol ++;
    }

    public void Ka(int amount)
    {
        int money = PlayerPrefs.GetInt("Money", 0);
        if(money >= 20000 && ka <= 1)
        {
        money += amount;
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        AtualizarTextos();
        }
    }

    public void KaB()
    {
        Ka(-20000);
        ka ++;
    }

    public void Argo(int amount)
    {
        int money = PlayerPrefs.GetInt("Money", 0);
        if(money >= 25000 && argo <= 1)
        {
        money += amount;
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        AtualizarTextos();
        }
    }

    public void ArgoB()
    {
        Argo(-25000);
        argo ++;
    }

    public void BMW(int amount)
    {
        int money = PlayerPrefs.GetInt("Money", 0);
        if(money >= 30000 && Bmw <= 1)
        {
        money += amount;
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        AtualizarTextos();
        }
    }

    public void BMWB()
    {
        BMW(-30000);
        Bmw ++;
    }

    public void AUDI(int amount)
    {
        int money = PlayerPrefs.GetInt("Money", 0);
        if(money >= 35000 && Audi <= 1)
        {
        money += amount;
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        AtualizarTextos();
        }
    }

    public void AUDIB()
    {
        AUDI(-35000);
        Audi ++;
    }

    public void MERCEDES(int amount)
    {
        int money = PlayerPrefs.GetInt("Money", 0);
        if(money >= 40000 && Mercedes <= 1)
        {
        money += amount;
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        AtualizarTextos();
        }
    }

    public void MERCEDESB()
    {
        MERCEDES(-40000);
        Mercedes ++;
    }

    public void JAGUAR(int amount)
    {
        int money = PlayerPrefs.GetInt("Money", 0);
        if(money >= 45000 && argo <= 1)
        {
        money += amount;
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        AtualizarTextos();
        }
    }

    public void JAGUARB()
    {
        JAGUAR(-45000);
        Jaguar ++;
    }
    // As funções de compra (Uno, Gol, Ka, etc.) permanecem inalteradas
}
