using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ObjetosCorrida2 : MonoBehaviour
{
    public TMP_Text pontos;
    public static int Pontos = 0;


    void Start()
    {
        updatePontos();
    }

    void Update()
    {
        updatePontos();
    }

    void updatePontos()
    {
        pontos.text = "Pontos: " + Pontos.ToString();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Chão"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            Pontos++;
            Destroy(gameObject);
        }
    }
}
