using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerActive : MonoBehaviour
{
    public GameObject[] activeObj;
    public bool triggerexitShow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            for(int i = 0;i <= activeObj.Length; i++)
            {
                activeObj[i].SetActive(true);
                if(activeObj == null)
                {
                    return;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && triggerexitShow)
        {
            for(int i = 0;i <= activeObj.Length; i++)
            {
                activeObj[i].SetActive(false);
            }
        }
    }

}
