using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBala : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        
    }

    void Update()
    {
        rb.velocity = new Vector3(0, 0, 10);
    }
}
