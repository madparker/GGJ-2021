using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    public GameObject[] obstacles;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 200; i++)
        {
            GameObject go = 
                Instantiate<GameObject>(obstacles[Random.Range(0,obstacles.Length)]);
            
            go.transform.parent = transform;
            
            go.transform.localPosition = 
                new Vector3(
                    Random.Range(-3.5f, 3.5f),
                    0,
                    i * 7.5f - 500);
            
            go.transform.Rotate(Vector3.up, Random.Range(0,360));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
