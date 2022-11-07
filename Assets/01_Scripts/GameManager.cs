using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Restart(){
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
        Debug.Log("Restart");
    }
}
