using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Curso2 : MonoBehaviour
{
    public int curso;
    //public int money;
    //public int curso2 = 1;
    public Image imageComponent; // O componente de UI Image
    public Sprite[] sprites; // Array de Sprites a serem usados
    public TMP_Text moneyText;

    void Start()
    {
        CarregarDados();
    }
    void CarregarDados()
    {
        curso = PlayerPrefs.GetInt("Curso", 0);
        //int money = PlayerPrefs.GetInt("Money", 0);

        //moneyText.text = "Dinheiro: " + money.ToString();
    }
    void Update()
    {
        // Verifica o valor da variável e troca a imagem
        switch (curso)
        {
            case 1:
                imageComponent.sprite = sprites[0]; // Exibe a primeira imagem
                break;
            case 2:
                imageComponent.sprite = sprites[1]; // Exibe a segunda imagem
                break;
            case 3:
                imageComponent.sprite = sprites[2]; // Exibe a terceira imagem
                break;
            case 4:
                imageComponent.sprite = sprites[3]; // Exibe a terceira imagem
                break;
            default:
                imageComponent.sprite = null; // Nenhuma imagem
                break;
        }
    }

    void AtualizarTextos()
    {
        int money = PlayerPrefs.GetInt("Money", 0);
        moneyText.text = "Dinheiro: " + money.ToString();
    }
    public void Curso()
{
    /*if (curso == 1 && money >= 3500 && curso2 == 1)
    {
        money -= 3500;
        curso2 = 2;
    }
    else if (curso == 2 && money >= 4500 && curso2 == 2)
    {
        money -= 4500;
        curso2 = 3;
    }
    else if (curso == 3 && money >= 6000 && curso2 == 3)
    {
        money -= 6000;
        curso2 = 4;
    }
    else if (curso == 4 && money >= 7000 && curso2 == 4)
    {
        money -= 7000;
        curso2 = 5;
    }
    
    // Atualiza os valores no PlayerPrefs, se necessário
    PlayerPrefs.SetInt("Money", money);
    PlayerPrefs.SetInt("Curso2", curso2);
    
    PlayerPrefs.Save(); // Salva os dados nos PlayerPrefs
    AtualizarTextos();  // Atualiza os textos na UI
    */
}

}
