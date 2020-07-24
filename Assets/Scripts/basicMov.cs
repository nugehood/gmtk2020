using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicMov : MonoBehaviour
{
    public SpriteRenderer wolfGfx;
    public float movementSpeed;
    public Rigidbody2D rb;
    public GameObject pausePanel;
    Vector2 movement;
    float x,y;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        movement = new Vector2(x, y) * movementSpeed;
        rb.velocity = movement;
        if(x < 0)
        {
            wolfGfx.flipX = true;
        }
        else
        {
            wolfGfx.flipX = false;
        }
    }
}
