using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highScore : MonoBehaviour
{
    float highTime;
    // Start is called before the first frame update
    void Start()
    {
        highTime = PlayerPrefs.GetFloat("highScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
