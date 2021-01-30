using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    public GameObject[] obstacles;
    
    // Start is called before the first frame update
    void Start()
    {
        print("Here");
        for (int i = 0; i < 100; i++)
        {
            GameObject go = 
                Instantiate<GameObject>(obstacles[Random.Range(0,3)]);
            
            go.transform.parent = transform;
            
            go.transform.localPosition = 
                new Vector3(
                    Random.Range(-3.5f, 3.5f),
                    0,
                    i * 10 - 500);
            
            go.transform.Rotate(Vector3.up, 45);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
