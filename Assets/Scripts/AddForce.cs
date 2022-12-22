using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0f, 250, 0f);
        }
    }
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-5, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.D)) 
        {
            rb.AddForce(5, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0f, 0f, 5);
        }
        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0f,0f, -5);
        }
    }
}
