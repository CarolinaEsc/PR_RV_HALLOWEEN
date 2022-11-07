using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    Vector2 dir = Vector2.zero;
    public float speed = 5;
    public int points = 0;
    public int life = 10;
    public Text pointsTxt;
    public Text lifesTxt;
    public GameObject gameOver;

    void OnEnable()
    {
    
    }

    void OnDisable()
    {
    
    }

    void Awake()
    {

    }

    void Start()
    {
        pointsTxt.text = "Points " + points.ToString();
        lifesTxt.text = "Lifes " + life.ToString();
    }

    void Update()
    {
       // rb.velocity = new Vector3(dir.x * speed, rb.velocity.y, dir.y * speed);
    }

    void TakeDamage()
    {
        life--;
        lifesTxt.text = "Lifes " + life.ToString();
        if(life <= 0)
        {
            gameOver.SetActive(true);
             Time.timeScale = 0;
        }
    }

    void AddPoints()
    {
        points++;
        pointsTxt.text = "Points " + points.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
            TakeDamage();
        }
    }
}
