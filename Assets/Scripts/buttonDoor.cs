using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonDoor : MonoBehaviour
{
    public SpriteRenderer buttonSprite;
    public Sprite pushedSprite, normalSprite;
    public GameObject[] openableDoor;

    public AudioSource source;
    public AudioClip pushed, notPushed;

    bool isPushed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            source.PlayOneShot(pushed);
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        buttonSprite.sprite = pushedSprite;
        openDoor();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        buttonSprite.sprite = normalSprite;
        closeDoor();
    }

    public void openDoor()
    {
        for(int i = 0;i<= openableDoor.Length; i++)
        {
            openableDoor[i].active = false;
        }
    }

    public void closeDoor()
    {
        source.PlayOneShot(notPushed);
        for (int i = 0; i <= openableDoor.Length; i++)
        {
            openableDoor[i].active = true;
        }
    }
}
