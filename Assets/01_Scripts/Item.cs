using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isBomb = true;
    float velocity = 8f;

    void Start()
    {
        Destroy(this.gameObject, 8F);
        
    }

    void Update()
    {
        if(this.gameObject.transform.position.y > 0 ){
            transform.position += Vector3.down * velocity * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
