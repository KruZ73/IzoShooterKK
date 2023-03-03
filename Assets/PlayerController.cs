using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    Vector2 inputVector;
    Rigidbody rb;


   
    void Start()
    {
        inputVector = Vector2.zero;
        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        // Debug.Log("Wychylenie kontrolera: " + inputVector.ToString());


       //ector3 movement = new Vector3(0, 0, inputVector.y);
        // transform.Translate(movement);

        // metoda z fizyk¹


      //Vector3 rotation = new Vector3(0, inputVector.x, 0);
        //transform.Rotate(rotation);
    }

    private void FixedUpdate()
    {
        if(inputVector.y == 0)
        {
            rb.velocity = Vector3.zero;
        } else
        {
            Vector3 movement = transform.forward * inputVector.y;
            rb.AddForce(movement, ForceMode.Impulse);
        }


        if(inputVector.x == 0)
        {
            rb.angularVelocity = Vector3.zero;
        } else
        {
            Vector3 rotation = transform.up * inputVector.x;
            rb.AddTorque(rotation, ForceMode.VelocityChange);
        }





    }


    void OnMove(InputValue inputValue)
    {
        inputVector = inputValue.Get<Vector2>();
    }




}
