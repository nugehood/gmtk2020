using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barkSignal : MonoBehaviour
{
    float a,b;

    public LayerMask sheepLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a+= 0.5f;
        b += 0.2f;

        transform.localScale = new Vector3(a,a,a);

        Collider2D[] Hitsheep = Physics2D.OverlapCircleAll(transform.position, b, sheepLayer); 

        foreach(Collider2D sheep in Hitsheep)
        {
            sheep.GetComponent<sheepState>().wolfBark = true;
        }

        if(a >= 12)
        {
            Destroy(gameObject);
        }

        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, b);
    }


}
