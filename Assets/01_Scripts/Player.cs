using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float x;
    public float y;
    public bool gyroEnabled = true;
    float sensivity = 50f;
    Gyroscope gyro;
    //----------------------------------------------------------------
    public Rigidbody rb;
    Vector2 dir = Vector2.zero;
    public float speed = 5;
    public int points = 0;
    public int lives = 10;
    public Text pointsTxt;
    public Text pointsTxt2;
    public Text livesTxt;
    public Text livesTxt2;
    //----------------------------------------------------------------
    public GameObject gameoverScreen;
    public GameObject ui;

    //----------------------------------------------------------------
    void Start()
    {
        ui.SetActive(true);
        if (SystemInfo.supportsGyroscope)
        {
            //Abilita el giroscopiods
            gyro = Input.gyro;
            gyro.enabled = true;
        }
    }

    void Update()
    {
        if (gyroEnabled)
        {
            x = Input.gyro.rotationRate.x;
            y = Input.gyro.rotationRate.y;
            float xFilterd = FilterGyroValue(x);
            transform.RotateAround(transform.position, transform.right, - xFilterd * sensivity * Time.deltaTime);

            float yFilterd = FilterGyroValue(y);
            transform.RotateAround(transform.position, transform.up, - yFilterd * sensivity * Time.deltaTime);
        }
        pointsTxt.text = points.ToString();
        pointsTxt2.text = points.ToString();
    }

    float FilterGyroValue(float axis)
    {
        if (axis < 0.1f || axis > 0.1f)
        {
            return axis;
        }
        else
        {
            return 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo")
        {
            lives--;
            livesTxt.text = lives.ToString();
            livesTxt2.text = lives.ToString();    
            Destroy(other.gameObject);
            if(lives <= 0)
            {
                ui.SetActive(false);
                gameoverScreen.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

}
