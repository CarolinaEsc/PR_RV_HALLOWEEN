using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform target;
    float moveSpeed = 1.5f;
    float rotationSpeed = 6;

    Transform myTransform;
    // Start is called before the first frame update
    void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform; //target the player
    }
    
    // Update is called once per frame
    void Update()
    {
        //Calcular distancia
        float distancia;
        distancia = Vector3.Distance(target.transform.position, transform.position);

        if(distancia<50)
        {
            //Voltear
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
            Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
            //Caminar
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;


        }

        
    }

    
}
