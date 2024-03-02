using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] float movementSpeed = 50;
    [SerializeField] float turnSpeed = 60;

    Transform myT;

    void Awake()
    {
        myT = transform;
    }

    void Update()

    {
        Turn();
        Thrust();
    }

    void Turn()
    { 
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll");


        myT.Rotate(-pitch,yaw,-roll);
    }

    void Thrust ()
    {
        if (Input.GetAxis("Vertical") > 0)
            transform.position += transform.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");

    }


}