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
    public Text livesTxt;
    public Text livesTxt2;
    public Text pointsTxt;
    public Text pointsTxt2;
    //----------------------------------------------------------------
    public GameObject gameoverScreen;
    public GameObject ui;
    public GameObject superBala;
    public GameObject bala;
    public GameObject punto;
    //----------------------------------------------------------------
    public Inputs inputs;

    public Image powerBar;
    float maxPower = 300;
    float power = 50;
    int timer = 0;

    void OnEnable()
    {
        inputs.Enable();
    }

    void OnDisable()
    {
        inputs.Disable();
    }

    private void Awake() {
        inputs = new Inputs();
        inputs.Player.Shoot.performed += ctx => Fire();
        inputs.Player.Disparo.performed += ctx => Fire();
        inputs.Player.SuperShoot.performed += ctx => InstanciarBala();
        inputs.Player.SuperDisparo.performed += ctx => InstanciarBala();
    }

    void Start()
    {
        ui.SetActive(true);
        if (SystemInfo.supportsGyroscope)
        {
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


        if(timer < 3)
        {
            timer++;
            powerBar.fillAmount = power / maxPower;
        }else{
            timer = 0;
            power++;
        }   
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

    private void InstanciarBala(){
        if(power >= maxPower){
            Instantiate(superBala, punto.transform.position, punto.transform.rotation);
            power = 10;
        }else{
            Debug.Log("Cargando poder");
        }
    }

    void Fire()
    {
        Instantiate(bala, punto.transform.position, punto.transform.rotation);
    }

    public void SubirPuntos(int puntos){
        Debug.Log("Subo "+puntos);
        pointsTxt.text =  puntos + "";
        pointsTxt2.text = puntos+ "";
    }

}
