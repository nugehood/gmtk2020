using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectSheep : MonoBehaviour
{
    public Text sheepLeftText,timerText,highScoreText;

    float high;

    public sheepState[] sheepState;

    int sheepLeft;

    float timer;

    public GameObject GameOverPanel;

    private void Awake()
    {
        sheepState = FindObjectsOfType<sheepState>();
        sheepLeft = sheepState.Length;
    }
    // Start is called before the first frame update
    void Start()
    {
        sheepState = FindObjectsOfType<sheepState>();
        sheepLeft = sheepState.Length;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sheepLeft != 0)
        {
            timer += Time.deltaTime;

        }



        timerText.text = timer.ToString();
        sheepLeftText.text = sheepLeft.ToString();

        if (sheepLeft <= 0)
        {
            high = PlayerPrefs.GetFloat("highScore");
            if(timer < high)
            {
                PlayerPrefs.SetFloat("highScore", timer);
                highScoreText.text = high.ToString();
            }
            Time.timeScale = 0;
            Win();
        }


    }

    public void Win()
    {
 
        GameOverPanel.SetActive(true);


        timerText = GameObject.Find("Time").GetComponent<Text>();


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("sheep"))
        {
            sheepLeft -= 1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("sheep"))
        {
            sheepLeft += 1;
        }
    }
}
