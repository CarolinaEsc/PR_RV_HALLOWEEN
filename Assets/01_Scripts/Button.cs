using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject Ui;
    public GameObject menuInicio;


    void Start()
    {

    }

    void Update()
    {
        
    }

    public void RestartGame(){
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene("GAME");
    }

    public void Iniciar(){
        menuInicio.SetActive(false);
        Time.timeScale = 1;
    }
}
