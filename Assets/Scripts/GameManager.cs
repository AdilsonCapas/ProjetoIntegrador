using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int Erros { get; private set; } = 3; // Valor inicial de erros

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IncrementErros(int amount)
    {
        Erros += amount;
    }

    public void DecrementErros(int amount)
    {
        Erros -= amount;
        Debug.Log("Erros após decremento: " + Erros); // Log para verificar o valor dos erros
        if (Erros <= 0)
        {
            Erros = 0;
            EndGame();
        }
    }

    private void EndGame()
    {
        Debug.Log("Game Over!");
    }
}
