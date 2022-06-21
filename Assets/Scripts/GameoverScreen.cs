using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameoverScreen : MonoBehaviour
{
    public Text pointsText;
    private bool JuegoPausado = false;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Puntos ";

        JuegoPausado = true;
        Pausa();
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        JuegoPausado = true;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Base juego");
        Time.timeScale = 1f;
        JuegoPausado = false;
    }

    public void ExittButton()
    {
        SceneManager.LoadScene("Menu Principal");
        Time.timeScale = 1f;
    }

    //private void Update()
    //{
    //    if (juegoPausado)
    //    {
    //        Pausa();
    //    }
    //}
    //public void Pausa()
    //{
    //    Time.timeScale = 0f;
    //    juegoPausado = true;
        
    //}
}
