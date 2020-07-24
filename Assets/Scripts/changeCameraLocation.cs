using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCameraLocation : MonoBehaviour
{
    public Transform cameraPosition;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cameraPosition.position = transform.position;
        }
    }
}
