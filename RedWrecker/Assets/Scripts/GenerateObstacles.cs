using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Here");
        for (int i = 0; i < 100; i++)
        {
            GameObject go = 
                Instantiate<GameObject>(Resources.Load<GameObject>("Block"));
            go.transform.position = 
                new Vector3(
                    Random.Range(-3.5f, 3.5f),
                    0.5f,
                    i * 10 - 500);
            
            go.transform.Rotate(Vector3.up, 45);
            
            go.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
