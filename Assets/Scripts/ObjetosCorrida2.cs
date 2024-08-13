using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjetosCorrida2 : MonoBehaviour
{
    public TMP_Text pontos;
    public static int Pontos = 0; // Use 'static' para manter a pontuação entre instâncias

    void Start()
    {
        updatePontos(); // Exibe a pontuação inicial ao iniciar o jogo
    }

    void updatePontos()
    {
        pontos.text = "Pontos: " + Pontos.ToString(); // Atualiza o texto com a pontuação atual
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Chão"))
        {
            Destroy(gameObject); // Destrói o objeto ao tocar o chão
        }
        else if(other.gameObject.CompareTag("Player"))
        {
            Pontos++; // Incrementa a pontuação
            updatePontos(); // Atualiza a UI dos pontos
            Destroy(gameObject); // Destrói o objeto após a colisão com o player
        }
    }
}
