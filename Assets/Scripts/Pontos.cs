/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pontos : MonoBehaviour
{
    public static Pontos instance;
    public int pontos;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Persiste o objeto entre cenas
        }
        else
        {
            Destroy(gameObject); // Destroi clones adicionais
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pontos++;
            Debug.Log("Colisão detectada! Pontos: " + pontos);
        }
    }
}*/

