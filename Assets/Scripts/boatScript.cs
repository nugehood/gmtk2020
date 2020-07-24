using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatScript : MonoBehaviour
{
    bool occupy,second;
    public Transform playerBody,newBoat,originalBoat,spawnLocation,secondLocation;
    public GameObject sheep;

    
   
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")&&!second)
        {
            playerBody.position = secondLocation.position;
            transform.position = newBoat.position;
            second = true;
        }

        else if (collision.gameObject.CompareTag("Player") &&second&&!occupy)
        {
            playerBody.position = spawnLocation.position;
            transform.position = originalBoat.position;
            second = false;
        }

        else if (collision.gameObject.CompareTag("Player") && second && occupy)
        {
            transform.position = originalBoat.position;
            playerBody.position = spawnLocation.position;
            Instantiate(sheep, spawnLocation.position, spawnLocation.rotation);
            second = false;
            occupy = false;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("sheep")&&!occupy)
        {
            occupy = true;
            Destroy(collision.gameObject);
        }
    }
}
