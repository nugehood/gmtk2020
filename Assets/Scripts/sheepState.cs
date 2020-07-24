using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepState : MonoBehaviour
{
    public bool stress, wolfClose, wolfBark;

    Transform wolfPosition;

    Rigidbody2D rb;

    public float movementSpeed;

    public float toplayerDistance;

    Vector2 decMovement;

    // Start is called before the first frame update
    void Start()
    {
        wolfPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        toplayerDistance = Vector3.Distance(transform.position, wolfPosition.position);
        decMovement = transform.position - wolfPosition.position;

        
    }

    private void FixedUpdate()
    {
        if (wolfBark)
        {
            transform.position = Vector2.MoveTowards(transform.position, wolfPosition.position,2f * Time.fixedDeltaTime);
            Invoke("ignore", 10f);
        }

        if (toplayerDistance < 2&&!wolfBark)
        {
            
            transform.Translate(decMovement * movementSpeed * Time.fixedDeltaTime);
        }
       

        
    }


    public void ignore()
    {
        wolfBark = false;
    }
}
