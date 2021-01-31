using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public float forceMod = 10;
    
    Rigidbody rb;

    public GameObject go;

    public KeyCode left;
    public KeyCode right;
    public KeyCode back;

    public AudioClip crash;

    public Vector3 rotAmnt = new Vector3();
    
    AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   

        Vector3 vel = rb.velocity;
        vel.z = -forceMod;
        rb.velocity = vel;
        
        if (Input.GetKey(right))
        {
            rb.AddForce(transform.right * forceMod);
        }
        if (Input.GetKey(left))
        {
            rb.AddForce(transform.right * -forceMod);
        }
        if (Input.GetKey(back))
        {
            rb.AddForce(transform.forward * forceMod * 50);
        }

        go.transform.right = rb.velocity.normalized;
    }

    void OnCollisionEnter(Collision other)
    {
        if (!audio.isPlaying)
        {
            audio.clip = crash;
            audio.Play();
        }
    }
}
