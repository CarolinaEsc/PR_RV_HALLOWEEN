using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject menuInicio;
    void Start()
    {
        
    }

    public void Iniciar(){
        menuInicio.SetActive(false);
        Time.timeScale = 1;
    }
}
