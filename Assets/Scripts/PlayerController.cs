using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float basespeed=3.0f;
    public float speed;
    public float speedup;
    public AudioClip se;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        basespeed = basespeed*0.001f;

        speed = basespeed;
        speedup=speed*2;

        audioSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        
        if(position.x >= -4.5f)
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= speed;
        }

        if (position.x <= 4.5f)
        if (Input.GetKey(KeyCode.D))
        {
            position.x += speed;
        }

        if(position.y <= 4.5f)
        if (Input.GetKey(KeyCode.W))
        {
            position.y += speed;
        }

        if (position.y >= -4.5f)
        if (Input.GetKey(KeyCode.S))
        {
            position.y -= speed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            speed=speedup;
        }
        else
        {
            speed=basespeed;
        }

        transform.position = position;
    }

    
}
