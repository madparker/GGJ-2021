using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3();

        newPos.x = (p1.transform.position.x + p2.transform.position.x) / 2f;
        newPos.y = (p1.transform.position.y + p2.transform.position.y) / 2f;
        
        newPos.z = p1.transform.position.z - 10;

        if (p1.transform.position.z > p2.transform.position.z)
        {
            newPos.z = p2.transform.position.z - 10;
        }

        transform.position = newPos;
    }
}
