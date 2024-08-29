using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    public Animator animPlayer;
    public SpriteRenderer sprite;
    public float moveH;
    public int velocidade;
    public int forcaPulo;
    private Rigidbody2D rb;
    public bool isJumping = false;
    public bool comVida = true;
    public int Money = 0;
    public int pontos;
    public int salario = 0;

    void Start()
    {
        salario = 0;
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate() 
    {
        // Andar
        moveH = Input.GetAxis("Horizontal"); // -1 a 1
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);
    }

    void SalvarDados()
    {
        PlayerPrefs.SetInt("Salario", salario);
        PlayerPrefs.Save();
    }

    void Update()
    {
        // Animação Run para a direita e esquerda
        if(Input.GetKey(KeyCode.D))
        {
            sprite.flipX = false;
        }

        // Animação Pular
        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
            isJumping = true;
        }

        if(pontos == 10 && salario == 0)
        {
            salario = salario + 1;
            SceneManager.LoadScene("Escritorio");
            //PlayerPrefs.SetInt("Salario", salario);
            SalvarDados();
        }
    } 

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Chão"))
        {
            isJumping = false;
        }
        if(other.gameObject.CompareTag("ObjetosC"))
        {
            pontos++;
            
        }
    }
}

