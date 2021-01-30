using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserControl : MonoBehaviour
{
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = -transform.forward * 5;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = -transform.forward * 10.1f;
    }

    void OnCollisionEnter(Collision other)
    {
           Destroy(other.gameObject);
    }
    
}
