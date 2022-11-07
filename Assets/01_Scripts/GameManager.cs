using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject panelController;
    public GameObject panelInicio;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Inicio(){
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        Debug.Log("Inicio");
        panelController.SetActive(true);
    }

    public void VolverInicio(){
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        Debug.Log("Volver");
        panelInicio.SetActive(true);
    }

    public void Restart(){
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        Debug.Log("Restart");
    }
}
