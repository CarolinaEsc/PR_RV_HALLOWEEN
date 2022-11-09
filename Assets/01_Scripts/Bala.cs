using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bala : MonoBehaviour
{
    public int points = 0;
    float speed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if (other.tag == "Enemigo")
        {
            points = points + 5;
            player.SubirPuntos(points);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            
        }
    }
}
