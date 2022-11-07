using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour
{
    public float x;
    public float y;
    public bool gyroEnabled = true;
    float sensivity = 50f;
    Gyroscope gyro;
    public Transform player;
    public LayerMask interactionLayer;
    public float moveSpeed = 5;
    public float rayDistance = 10f;

    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro.enabled = true;
            gyro = Input.gyro;
        }
    }
    void Update()
    {
        if (gyroEnabled)
        {
            float xFiltered = FilerGyroValue(x);
            transform.RotateAround(transform.position, transform.right, -xFiltered* sensivity * Time.deltaTime);
            float yFiltered = FilerGyroValue(y);
            transform.RotateAround(transform.position, transform.up, -xFiltered* sensivity * Time.deltaTime);

            //Caminar
            //Debug.Log(transform.localEulerAngles.x);
            /*if (transform.localEulerAngles.x >= 15 && transform.localEulerAngles.x < 50)
            {
                player.Translate(transform.forward * moveSpeed * Time.deltaTime);
            }*/

            /*Debug.DrawRay(transform.position, transform.forward * rayDistance, Color.red);
            Ray raycast = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if(Physics.Raycast(raycast, out hit, rayDistance, interactionLayer, QueryTriggerInteraction.Collide)){
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
            }*/
        }
    }

    float FilerGyroValue(float axis){
        if (axis < -0.1f || axis > 0.1f)
        {
            return axis;
        }else{
            return 0;
        }
    }
}
