using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proceduralLevel : MonoBehaviour
{
    public GameObject[] Levels;
    public collectSheep sheepCollector;
    int randomLevel;

    // Start is called before the first frame update
    void Start()
    {
        randomLevel = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        Levels[randomLevel].SetActive(true);
        sheepCollector.enabled = true;

    }
}
