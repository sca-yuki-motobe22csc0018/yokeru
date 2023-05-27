using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float basespeed=5.0f;
    public float speed;
    public float speeddown;
    // Start is called before the first frame update
    void Start()
    {
        basespeed = basespeed*0.001f;

        speed = basespeed;
        speeddown=speed/2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        

        if (Input.GetKey("left"))
        {
            position.x -= speed;
        }
        if (Input.GetKey("right"))
        {
            position.x += speed;
        }
        if (Input.GetKey("up"))
        {
            position.y += speed;
        }
        if (Input.GetKey("down"))
        {
            position.y -= speed;
        }

        if (Input.GetKey("Space"))
        {
            speed=speeddown;
        }
        else
        {
            speed=basespeed;
        }

        transform.position = position;
    }
}
