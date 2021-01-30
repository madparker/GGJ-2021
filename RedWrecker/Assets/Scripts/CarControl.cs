using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public float forceMod = 10;
    
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   

        Vector3 vel = rb.velocity;
        vel.z = -forceMod;
        rb.velocity = vel;
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * forceMod);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -forceMod);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * forceMod * 20);
        }
    }
}
