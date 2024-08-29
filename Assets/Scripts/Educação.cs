using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Educação : MonoBehaviour
{
    public int curso;
    void Start()
    {
        curso =0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SalvarDados()
    {
        PlayerPrefs.SetInt("Curso", curso);
        PlayerPrefs.Save();
    }

    public void Office()
    {
        SceneManager.LoadScene("Curso");
        curso = 1;
        SalvarDados();
    }

    public void Excel()
    {
        SceneManager.LoadScene("Curso");
        curso = 2;
        SalvarDados();
    }

    public void Gestão()
    {
        SceneManager.LoadScene("Curso");
        curso = curso = 3;
        SalvarDados();
    }

    public void Mba()
    {
        SceneManager.LoadScene("Curso");
        curso = curso = 4;
        SalvarDados();
    }
}
