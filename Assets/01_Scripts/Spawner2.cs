using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject enemy_1;
    int spawnRandom = 0;
    public float timer = 0;
    float timeToSpawn;
    public float velocity = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn=Random.Range(5, 20);
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
        }
    }
}
