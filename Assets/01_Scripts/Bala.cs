using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bala : MonoBehaviour
{
    public int points = 0;
    public Text pointsTxt;
    public Text pointsTxt2;
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, Time.deltaTime * speed);
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            points = points + 5;
            pointsTxt.text=points.ToString();
            pointsTxt2.text=points.ToString();

        }
    }
}
