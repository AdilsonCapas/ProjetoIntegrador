using UnityEngine;
using TMPro;

public class ObjetosCorrida : MonoBehaviour
{
    public TMP_Text errosText;

    void Start()
    {
        UpdateErros();
    }

    void UpdateErros()
    {
        if (errosText != null && GameManager.Instance != null)
        {
            errosText.text = "Erros: " + GameManager.Instance.Erros.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Chão"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.DecrementErros(1);
                UpdateErros();
            }
            else
            {
                Debug.LogError("GameManager não encontrado!");
            }

            Destroy(gameObject);
        }
    }
}
