using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    Text text;
    float startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        startTime = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + (Time.realtimeSinceStartup - startTime);
    }
}
