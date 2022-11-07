using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy_1;
    public GameObject enemy_2;
    int spawnRandom = 0;
    public float timer = 0;
    float timeToSpawn;
    public float velocity = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn=Random.Range(5, 20);
        Debug.Log("Enemygo tiene:"+ timeToSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        InstantiateObject();
    }

    void InstantiateObject()
    {
        if (timer < timeToSpawn)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnRandom=Random.Range(1, 25);
            if(spawnRandom >= 0 && spawnRandom <= 3)
            {
                Instantiate(enemy_1, this.transform.transform.position, this.transform.rotation); 
                timer = 0;      
            }
            else
            {
                if(spawnRandom >= 23 && spawnRandom <=25)
                {
                    Instantiate(enemy_2, this.transform.transform.position, this.transform.rotation);        
                    timer = 0;
                }
                else
                {
                    Debug.Log("Nada");
                }
            }
        }
    }

}