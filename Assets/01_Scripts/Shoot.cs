using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Input inputs;
    private PlayerIn playerInputs;

    public Vector3 dir;
    // Start is called before the first frame update
    void Awake()
    {
        playerInputs = new PlayerIn();
    }

    void OnEnable()
    {
        playerInputs.Enable();
    }

    void OnDisable()
    {
        playerInputs.Disable();
    }


    void Start()
    {
        //playerInputs.Player.Fire.performed += ctx => Shoot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
